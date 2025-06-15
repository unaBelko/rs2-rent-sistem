using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Services.Database;
using rs2_rent_sistem.Utilities;

namespace rs2_rent_sistem.Services.Data
{
    public class DatabaseSeed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            SeedRole(modelBuilder);
            SeedUser(modelBuilder);
            SeedUserRole(modelBuilder);
            SeedEquipmentCategory(modelBuilder);
            SeedManufacturer(modelBuilder);
            SeedEquipment(modelBuilder);
            SeedOrders(modelBuilder);
            SeedOrderItems(modelBuilder);
            SeedReviews(modelBuilder);
            SeedCarts(modelBuilder);
            SeedCartItems(modelBuilder);
            SeedDamages(modelBuilder);
        }

        private static void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { ID = 1, Name = "employee", Description = "Radnik u rent biznisu, koristi desktop app" },
                new Role { ID = 2, Name = "end-user", Description = "Krajnji korisnik, koristi mobilnu aplikaciju" });
        }

        private static void SeedUser(ModelBuilder modelBuilder)
        {
            var salt = UtilityFunctions.GenerateSalt();
            var passwordHash = UtilityFunctions.GenerateHash(salt, "test123");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    FirstName = "Una",
                    LastName = "Radnik",
                    Email = "una.belko+radnik@edu.fit.ba",
                    Phone = "0038763222111",
                    IsActive = true,
                    PasswordHash = passwordHash,
                    Salt = salt
                },
                new User
                {
                    ID = 2,
                    FirstName = "Una",
                    LastName = "Shopping",
                    Email = "una.belko+shopping@edu.fit.ba",
                    Phone = "0038763222111",
                    IsActive = true,
                    PasswordHash = passwordHash,
                    Salt = salt
                }, new User
                {
                    ID = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    Email = "michael.johnson+user@rental.com",
                    Phone = "555-8765",
                    IsActive = true,
                    PasswordHash = passwordHash,
                    Salt = salt
                },
        new User
        {
            ID = 4,
            FirstName = "Emily",
            LastName = "Davis",
            Email = "emily.davis+user@rental.com",
            Phone = "555-4321",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 5,
            FirstName = "William",
            LastName = "Brown",
            Email = "william.brown+user@rental.com",
            Phone = "555-6789",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 6,
            FirstName = "Ava",
            LastName = "Wilson",
            Email = "ava.wilson+user@rental.com",
            Phone = "555-2345",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 7,
            FirstName = "James",
            LastName = "Taylor",
            Email = "james.taylor+user@rental.com",
            Phone = "555-7890",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 8,
            FirstName = "Olivia",
            LastName = "Anderson",
            Email = "olivia.anderson+user@rental.com",
            Phone = "555-3456",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 9,
            FirstName = "Benjamin",
            LastName = "Thomas",
            Email = "benjamin.thomas+user@rental.com",
            Phone = "555-9012",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        },
        new User
        {
            ID = 10,
            FirstName = "Sophia",
            LastName = "Moore",
            Email = "sophia.moore+user@rental.com",
            Phone = "555-6543",
            IsActive = true,
            PasswordHash = passwordHash,
            Salt = salt
        }
                );
        }

        private static void SeedUserRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasData(
                new
                {
                    UserID = 1,
                    RoleID = 1
                },
                new
                {
                    UserID = 2,
                    RoleID = 2
                }, new UserRole
                {
                    UserID = 3,
                    RoleID = 2
                },
        new UserRole
        {
            UserID = 4,
            RoleID = 2
        },
        new UserRole
        {
            UserID = 5,
            RoleID = 2
        },
        new UserRole
        {
            UserID = 6,
            RoleID = 2
        },
        new UserRole
        {
            UserID = 7,
            RoleID = 2
        },
        new UserRole
        {
            UserID = 8,
            RoleID = 2
        },
        new UserRole
        {
            UserID = 9,
            RoleID = 2
        },
        new UserRole
        { UserID = 10, RoleID = 2 });
        }

        private static void SeedEquipmentCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EquipmentCategory>().HasData(
                new EquipmentCategory { ID = 1, Name = "Football", Description = "Equipment for football and soccer" , IsDeleted = false},
                new EquipmentCategory { ID = 2, Name = "Basketball", Description = "Basketball equipment and accessories", IsDeleted = false },
                new EquipmentCategory { ID = 3, Name = "Tennis", Description = "Tennis rackets and gear", IsDeleted = false },
                new EquipmentCategory { ID = 4, Name = "Baseball", Description = "Baseball bats, gloves, and equipment", IsDeleted = false },
                new EquipmentCategory { ID = 5, Name = "Cycling", Description = "Bikes and cycling gear", IsDeleted = false },
                new EquipmentCategory { ID = 6, Name = "Running", Description = "Running shoes and accessories", IsDeleted = false },
                new EquipmentCategory { ID = 7, Name = "Swimming", Description = "Swimming gear and equipment", IsDeleted = false },
                new EquipmentCategory { ID = 8, Name = "Golf", Description = "Golf clubs and accessories", IsDeleted = false },
                new EquipmentCategory { ID = 9, Name = "Boxing", Description = "Boxing gloves and equipment", IsDeleted = false },
                new EquipmentCategory { ID = 10, Name = "Fitness", Description = "Fitness and gym equipment", IsDeleted = false }
            );
        }

        private static void SeedManufacturer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ID = 1, Name = "Nike", Description = "Sportswear and equipment manufacturer", IsDeleted = false },
                new Manufacturer { ID = 2, Name = "Adidas", Description = "Global sports equipment manufacturer", IsDeleted = false },
                new Manufacturer { ID = 3, Name = "Puma", Description = "Sporting goods and apparel manufacturer", IsDeleted = false },
                new Manufacturer { ID = 4, Name = "Under Armour", Description = "Performance apparel and gear", IsDeleted = false },
                new Manufacturer { ID = 5, Name = "Reebok", Description = "Footwear and sports equipment", IsDeleted = false },
                new Manufacturer { ID = 6, Name = "Wilson", Description = "Sports equipment, especially in tennis", IsDeleted = false },
                new Manufacturer { ID = 7, Name = "Spalding", Description = "Basketball and sporting goods manufacturer", IsDeleted = false },
                new Manufacturer { ID = 8, Name = "Yonex", Description = "Badminton and tennis equipment manufacturer", IsDeleted = false },
                new Manufacturer { ID = 9, Name = "Callaway", Description = "Golf equipment and accessories", IsDeleted = false },
                new Manufacturer { ID = 10, Name = "Everlast", Description = "Boxing equipment and apparel manufacturer", IsDeleted = false }
            );
        }

        public static void SeedEquipment(ModelBuilder modelBuilder)
        {
            var photo = Convert.FromBase64String("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");
            var equipmentItems = new List<Equipment>
            {
              new Equipment { ID = 1, ItemName = "Soccer Ball", StockQuantity = 30, MinQuantity = 5, MaxQuantity = 50, Description = "Official size and weight.", CostPerUse = 2.99m, DateAdded = DateTime.Now, ManufacturerID = 1, EquipmentCategoryId = 1, IsDeleted = false, Photo = photo },
              new Equipment { ID = 2, ItemName = "Basketball", StockQuantity = 20, MinQuantity = 5, MaxQuantity = 40, Description = "High-quality leather basketball.", CostPerUse = 3.49m, DateAdded = DateTime.Now, ManufacturerID = 2, EquipmentCategoryId = 2, IsDeleted = false, Photo = photo },
              new Equipment { ID = 3, ItemName = "Tennis Racket", StockQuantity = 15, MinQuantity = 2, MaxQuantity = 25, Description = "Lightweight racket for professional use.", CostPerUse = 4.99m, DateAdded = DateTime.Now, ManufacturerID = 3, EquipmentCategoryId = 3, IsDeleted = false, Photo = photo },
            };

            for (int i = 4; i <= 50; i++)
            {
                equipmentItems.Add(new Equipment
                {
                    ID = i,
                    ItemName = $"Equipment {i}",
                    StockQuantity = new Random().Next(10, 50),
                    MinQuantity = 5,
                    MaxQuantity = 50,
                    Description = $"Description for Equipment {i}",
                    CostPerUse = Math.Round((decimal)(new Random().NextDouble() * 10), 2),
                    DateAdded = DateTime.Now,
                    ManufacturerID = new Random().Next(1, 10),
                    EquipmentCategoryId = new Random().Next(1, 10),
                    IsDeleted = false,
                    Photo = photo,
                });
            }

            modelBuilder.Entity<Equipment>().HasData(equipmentItems);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { ID = 1, UserID = 3, DatePlaced = DateTime.Now.AddDays(-10), TotalPrice = 59.94m, IsActive = true, Status = "returned" },
                new Order { ID = 2, UserID = 4, DatePlaced = DateTime.Now.AddDays(-8), TotalPrice = 89.85m, IsActive = true, Status = "paid" },
                new Order { ID = 3, UserID = 4, DatePlaced = DateTime.Now.AddDays(-5), TotalPrice = 29.97m, IsActive = true, Status = "rented" },
                new Order { ID = 4, UserID = 5, DatePlaced = DateTime.Now.AddDays(-7), TotalPrice = 19.98m, IsActive = true , Status = "rented" },
                new Order { ID = 5, UserID = 5, DatePlaced = DateTime.Now.AddDays(-4), TotalPrice = 99.90m, IsActive = true , Status = "returned" },
                new Order { ID = 6, UserID = 6, DatePlaced = DateTime.Now.AddDays(-3), TotalPrice = 49.95m, IsActive = true , Status = "rented" },
                new Order { ID = 7, UserID = 7, DatePlaced = DateTime.Now.AddDays(-2), TotalPrice = 69.93m, IsActive = true , Status = "returned" },
                new Order { ID = 8, UserID = 2, DatePlaced = DateTime.Now.AddDays(-1), TotalPrice = 39.96m, IsActive = true , Status = "paid" },
                new Order { ID = 9, UserID = 2, DatePlaced = DateTime.Now.AddDays(-6), TotalPrice = 149.85m, IsActive = true , Status = "rented" },
                new Order { ID = 10, UserID = 2, DatePlaced = DateTime.Now.AddDays(-9), TotalPrice = 29.97m, IsActive = true , Status = "returned" }
            );
        }

        private static void SeedOrderItems(ModelBuilder modelBuilder)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem { ID = 1, OrderID = 1, EquipmentID = 1, Quantity = 2, CostPerUse = 2.99m, Price = 5.98m, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(9), IsReviewedByUser = false },
                new OrderItem { ID = 2, OrderID = 1, EquipmentID = 3, Quantity = 1, CostPerUse = 4.99m, Price = 4.99m, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(8), IsReviewedByUser = false },
                new OrderItem { ID = 3, OrderID = 2, EquipmentID = 2, Quantity = 3, CostPerUse = 3.49m, Price = 10.47m, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(7), IsReviewedByUser = false },
                new OrderItem { ID = 4, OrderID = 2, EquipmentID = 1, Quantity = 4, CostPerUse = 2.99m, Price = 11.96m, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(6), IsReviewedByUser = false },
                new OrderItem { ID = 5, OrderID = 3, EquipmentID = 3, Quantity = 2, CostPerUse = 4.99m, Price = 9.98m, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(4), IsReviewedByUser = false },
                new OrderItem { ID = 6, OrderID = 4, EquipmentID = 1, Quantity = 1, CostPerUse = 2.99m, Price = 2.99m, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(6), IsReviewedByUser = false },
                new OrderItem { ID = 7, OrderID = 5, EquipmentID = 2, Quantity = 5, CostPerUse = 3.49m, Price = 17.45m, StartDate = DateTime.Now.AddDays(-4), EndDate = DateTime.Now.AddDays(2), IsReviewedByUser = false },
                new OrderItem { ID = 8, OrderID = 6, EquipmentID = 3, Quantity = 3, CostPerUse = 4.99m, Price = 14.97m, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(1), IsReviewedByUser = false },
                new OrderItem { ID = 9, OrderID = 7, EquipmentID = 1, Quantity = 2, CostPerUse = 2.99m, Price = 5.98m, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(1), IsReviewedByUser = false },
                new OrderItem { ID = 10, OrderID = 8, EquipmentID = 2, Quantity = 3, CostPerUse = 3.49m, Price = 10.47m, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now, IsReviewedByUser = false },
                new OrderItem { ID = 11, OrderID = 9, EquipmentID = 3, Quantity = 1, CostPerUse = 4.99m, Price = 4.99m, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(4), IsReviewedByUser = false },
                new OrderItem { ID = 12, OrderID = 9, EquipmentID = 1, Quantity = 5, CostPerUse = 2.99m, Price = 14.95m, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(5), IsReviewedByUser = false },
                new OrderItem { ID = 13, OrderID = 10, EquipmentID = 2, Quantity = 2, CostPerUse = 3.49m, Price = 6.98m, StartDate = DateTime.Now.AddDays(-9), EndDate = DateTime.Now.AddDays(8), IsReviewedByUser = false },
                new OrderItem { ID = 14, OrderID = 10, EquipmentID = 4, Quantity = 2, CostPerUse = 3.49m, Price = 6.98m, StartDate = DateTime.Now.AddDays(-9), EndDate = DateTime.Now.AddDays(8), IsReviewedByUser = true, HasDamageReportedByUser = true, }
            };
            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }

        private static void SeedDamages(ModelBuilder modelBuilder)
        {
            var damages = new List<Damage> {
                new Damage { ID = 1, DateAdded = DateTime.Now, OrderItemID = 14, Comment = "This got some scratches while we were using it."},
            };
            modelBuilder.Entity<Damage>().HasData(damages);
        }

        private static void SeedReviews(ModelBuilder modelBuilder)
        {
            var reviews = new List<Review>
            {
                new Review { ID = 1, DateAdded = DateTime.Now.AddDays(-9), Description = "Great quality and very durable!", NumberOfStars = 4.5m, OrderItemID = 1, IsDeleted = false },
                new Review { ID = 2, DateAdded = DateTime.Now.AddDays(-8), Description = "Not as expected, could be better.", NumberOfStars = 2.0m, OrderItemID = 2, IsDeleted = false },
                new Review { ID = 3, DateAdded = DateTime.Now.AddDays(-7), Description = "Perfect for my needs, highly recommended!", NumberOfStars = 5.0m, OrderItemID = 3, IsDeleted = false },
                new Review { ID = 4, DateAdded = DateTime.Now.AddDays(-6), Description = "Good value for the price.", NumberOfStars = 4.0m, OrderItemID = 4, IsDeleted = false },
                new Review { ID = 5, DateAdded = DateTime.Now.AddDays(-5), Description = "Satisfactory but delivery was delayed.", NumberOfStars = 3.0m, OrderItemID = 5, IsDeleted = false },
                new Review { ID = 6, DateAdded = DateTime.Now.AddDays(-4), Description = "Excellent performance and quality.", NumberOfStars = 5.0m, OrderItemID = 6, IsDeleted = false },
                new Review { ID = 7, DateAdded = DateTime.Now.AddDays(-3), Description = "Decent product but could use some improvements.", NumberOfStars = 3.5m, OrderItemID = 7, IsDeleted = false },
                new Review { ID = 8, DateAdded = DateTime.Now.AddDays(-2), Description = "Very satisfied with the purchase.", NumberOfStars = 4.5m, OrderItemID = 8, IsDeleted = false },
                new Review { ID = 9, DateAdded = DateTime.Now.AddDays(-1), Description = "The item was okay, nothing special.", NumberOfStars = 3.0m, OrderItemID = 9, IsDeleted = false },
                new Review { ID = 10, DateAdded = DateTime.Now, Description = "Amazing product! Will buy again.", NumberOfStars = 5.0m, OrderItemID = 14, IsDeleted = false }
            };
            modelBuilder.Entity<Review>().HasData(reviews);
        }

        private static void SeedCarts(ModelBuilder modelBuilder)
        {
            var carts = new List<Cart>
            {
                new Cart { ID = 1, UserID = 2, DateAdded = DateTime.Now.AddDays(-6), TotalPrice = 45.75m },
                new Cart { ID = 2, UserID = 3, DateAdded = DateTime.Now.AddDays(-5), TotalPrice = 120.00m },
                new Cart { ID = 3, UserID = 4, DateAdded = DateTime.Now.AddDays(-4), TotalPrice = 65.30m },
                new Cart { ID = 4, UserID = 5, DateAdded = DateTime.Now.AddDays(-3), TotalPrice = 78.40m },
                new Cart { ID = 5, UserID = 6, DateAdded = DateTime.Now.AddDays(-2), TotalPrice = 52.10m },
                new Cart { ID = 6, UserID = 7, DateAdded = DateTime.Now.AddDays(-1), TotalPrice = 98.25m },
                new Cart { ID = 7, UserID = 8, DateAdded = DateTime.Now, TotalPrice = 36.60m }
            };
            modelBuilder.Entity<Cart>().HasData(carts);
        }

        private static void SeedCartItems(ModelBuilder modelBuilder)
        {
            var cartItems = new List<CartItem>
            {
                new CartItem { ID = 1, CartID = 1, EquipmentID = 1, Quantity = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5) },
                new CartItem { ID = 2, CartID = 1, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5) },
                new CartItem { ID = 3, CartID = 2, EquipmentID = 3, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4) },
                new CartItem { ID = 4, CartID = 3, EquipmentID = 1, Quantity = 3, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3) },
                new CartItem { ID = 5, CartID = 3, EquipmentID = 2, Quantity = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3) },
                new CartItem { ID = 6, CartID = 4, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2) },
                new CartItem { ID = 7, CartID = 4, EquipmentID = 3, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2) },
                new CartItem { ID = 8, CartID = 5, EquipmentID = 1, Quantity = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) },
                new CartItem { ID = 9, CartID = 6, EquipmentID = 3, Quantity = 3, StartDate = DateTime.Now, EndDate = DateTime.Now },
                new CartItem { ID = 10, CartID = 7, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) }
            };
            modelBuilder.Entity<CartItem>().HasData(cartItems);
        }
    }
}