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

        public override async Task<Equipment> Insert(EquipmentUpsertObject equipmentUpsertObject)
        {
            if (equipmentUpsertObject == null)
                throw new ArgumentNullException(nameof(equipmentUpsertObject));

            byte[]? photoBytes = null;
            if (!string.IsNullOrEmpty(equipmentUpsertObject.PhotoBase64))
            {
                photoBytes = Convert.FromBase64String(equipmentUpsertObject.PhotoBase64);
            }
            //Zbog manjka vremena nije naisan mapper
            var equipmentEntity = new Database.Equipment
            {
                ItemName = equipmentUpsertObject.ItemName,
                ImageUrl = equipmentUpsertObject.ImageUrl,
                StockQuantity = equipmentUpsertObject.StockQuantity,
                MinQuantity = equipmentUpsertObject.MinQuantity,
                MaxQuantity = equipmentUpsertObject.MaxQuantity,
                Description = equipmentUpsertObject.Description,
                CostPerUse = equipmentUpsertObject.CostPerUse,
                DateAdded = equipmentUpsertObject.DateAdded ?? DateTime.UtcNow, // Use current date if DateAdded is null
                ManufacturerID = equipmentUpsertObject.ManufacturerID,
                EquipmentCategoryId = equipmentUpsertObject.EquipmentCategoryID,
                Photo = photoBytes
            };

            try
            {
                _context.Equipment.Add(equipmentEntity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding equipment: {ex.Message}");
                throw;
            }

            return _mapper.Map<Equipment>(equipmentEntity);
        }

        public override async Task<Equipment> GetById(int id)
        {
            var equipmentEntity = await _context.Equipment
                .Include(c => c.OrderItems)
                .FirstOrDefaultAsync(c => c.ID == id);

            if (equipmentEntity == null)
            {
                return null;
            }

            var today = DateTime.Today;
            var equipment = _mapper.Map<Equipment>(equipmentEntity);
            equipment.AvailableDates = new List<Model.Models.AvailableDate>();

            // Generate the next 14 days including today
            for (int i = 0; i < 28; i++)
            {
                var currentDate = today.AddDays(i);
                var curentDateEnd = today.AddDays(i).AddHours(23).AddMinutes(50);

                // Calculate the total quantity used on this day
                var totalUsedOnDate = equipmentEntity.OrderItems
                    .Where(orderItem => curentDateEnd >= orderItem.StartDate && currentDate <= orderItem.EndDate)
                    .Sum(orderItem => orderItem.Quantity);

                // Calculate available quantity
                var availableQuantity = equipmentEntity.StockQuantity - totalUsedOnDate;

                // Add the result to AvailableDates
                equipment.AvailableDates.Add(new Model.Models.AvailableDate
                {
                    Date = currentDate,
                    Quantity = availableQuantity
                });
            }

            return equipment;
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
