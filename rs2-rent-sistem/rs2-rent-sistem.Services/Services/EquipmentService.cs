using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;
using Equipment = rs2_rent_sistem.Model.Models.Equipment;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentService : CRUDService<Equipment, Database.Equipment, EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>, IEquipmentService
    {
        static MLContext mlContext = null;
        static object isLocked = new object();
        static ITransformer model = null;
        public EquipmentService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public List<Equipment> GetRecommended(int id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();
                    var orders = _context.Orders.Include("OrderItems").ToList();

                    var data = new List<ProductEntry>();

                    foreach (var order in orders)
                    {
                        if (order.OrderItems.Count > 0)
                        {
                            var distinctItemIds = order.OrderItems.Select(x => x.EquipmentID).ToList();
                            foreach (var item in distinctItemIds)
                            {
                                var relatedItems = order.OrderItems.Where(y => y.EquipmentID != item);

                                foreach (var relatedItem in relatedItems)
                                {
                                    data.Add(new ProductEntry()
                                    {
                                        ProductID = (uint)item,
                                        CoPurchaseProductID = (uint)relatedItem.EquipmentID,
                                    });
                                }
                            }
                        }
                    }

                    var trainData = mlContext.Data.LoadFromEnumerable(data);

                    MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                    options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                    options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                    options.LabelColumnName = "Label";
                    options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                    options.Alpha = 0.01;
                    options.Lambda = 0.025;
                    // For better results use the following parameters
                    options.NumberOfIterations = 100;
                    options.C = 0.00001;

                    var estimator = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = estimator.Fit(trainData);
                }
            }

            var equipments = _context.Equipment.Where(e => e.ID != id);
            var predictionResult = new List<Tuple<Database.Equipment, float>>();

            foreach (var equipment in equipments)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionEngine.Predict(
                        new ProductEntry()
                        {
                            ProductID = (uint)id,
                            CoPurchaseProductID = (uint)equipment.ID,
                        });
                predictionResult.Add(new Tuple<Database.Equipment, float>(equipment, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2).Take(3).Select(x => x.Item1).ToList();

            //if (!finalResult.Any())
            //{
            //    finalResult = _context.Equipment
            //        .Where(e => e.ID != id)
            //        .OrderByDescending(e => e.Popularity)
            //        .Take(3)
            //        .ToList();
            //}

            return _mapper.Map<List<Equipment>>(finalResult);
        }
    }

    public class Copurchase_prediction
    {
        public float Score { get; set; }
    }

    public class ProductEntry
    {
        [KeyType(count: 10)]
        public uint ProductID { get; set; }

        [KeyType(count: 10)]
        public uint CoPurchaseProductID { get; set; }

        public float Label { get; set; }
    }
}
