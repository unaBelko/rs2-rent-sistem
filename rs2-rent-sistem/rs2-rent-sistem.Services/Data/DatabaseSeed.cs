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
            //SeedReviews(modelBuilder);
            SeedCarts(modelBuilder);
            SeedCartItems(modelBuilder);
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
                new EquipmentCategory { ID = 1, Name = "Football", Description = "Equipment for football and soccer" },
                new EquipmentCategory { ID = 2, Name = "Basketball", Description = "Basketball equipment and accessories" },
                new EquipmentCategory { ID = 3, Name = "Tennis", Description = "Tennis rackets and gear" },
                new EquipmentCategory { ID = 4, Name = "Baseball", Description = "Baseball bats, gloves, and equipment" },
                new EquipmentCategory { ID = 5, Name = "Cycling", Description = "Bikes and cycling gear" },
                new EquipmentCategory { ID = 6, Name = "Running", Description = "Running shoes and accessories" },
                new EquipmentCategory { ID = 7, Name = "Swimming", Description = "Swimming gear and equipment" },
                new EquipmentCategory { ID = 8, Name = "Golf", Description = "Golf clubs and accessories" },
                new EquipmentCategory { ID = 9, Name = "Boxing", Description = "Boxing gloves and equipment" },
                new EquipmentCategory { ID = 10, Name = "Fitness", Description = "Fitness and gym equipment" }
            );
        }

        private static void SeedManufacturer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ID = 1, Name = "Nike", Description = "Sportswear and equipment manufacturer" },
                new Manufacturer { ID = 2, Name = "Adidas", Description = "Global sports equipment manufacturer" },
                new Manufacturer { ID = 3, Name = "Puma", Description = "Sporting goods and apparel manufacturer" },
                new Manufacturer { ID = 4, Name = "Under Armour", Description = "Performance apparel and gear" },
                new Manufacturer { ID = 5, Name = "Reebok", Description = "Footwear and sports equipment" },
                new Manufacturer { ID = 6, Name = "Wilson", Description = "Sports equipment, especially in tennis" },
                new Manufacturer { ID = 7, Name = "Spalding", Description = "Basketball and sporting goods manufacturer" },
                new Manufacturer { ID = 8, Name = "Yonex", Description = "Badminton and tennis equipment manufacturer" },
                new Manufacturer { ID = 9, Name = "Callaway", Description = "Golf equipment and accessories" },
                new Manufacturer { ID = 10, Name = "Everlast", Description = "Boxing equipment and apparel manufacturer" }
            );
        }

        public static void SeedEquipment(ModelBuilder modelBuilder)
        {
            var equipmentItems = new List<Equipment>
            {
              new Equipment { ID = 1, ItemName = "Soccer Ball", ImageUrl = "soccerball.jpg", StockQuantity = 30, MinQuantity = 5, MaxQuantity = 50, Description = "Official size and weight.", CostPerUse = 2.99m, DateAdded = DateTime.Now, ManufacturerID = 1, EquipmentCategoryId = 1, AddedByUserID = 1, IsDeleted = false },
              new Equipment { ID = 2, ItemName = "Basketball", ImageUrl = "basketball.jpg", StockQuantity = 20, MinQuantity = 5, MaxQuantity = 40, Description = "High-quality leather basketball.", CostPerUse = 3.49m, DateAdded = DateTime.Now, ManufacturerID = 2, EquipmentCategoryId = 2, AddedByUserID = 1, IsDeleted = false },
              new Equipment { ID = 3, ItemName = "Tennis Racket", ImageUrl = "tennisracket.jpg", StockQuantity = 15, MinQuantity = 2, MaxQuantity = 25, Description = "Lightweight racket for professional use.", CostPerUse = 4.99m, DateAdded = DateTime.Now, ManufacturerID = 3, EquipmentCategoryId = 3, AddedByUserID = 1, IsDeleted = false },
            };

            for (int i = 4; i <= 50; i++)
            {
                equipmentItems.Add(new Equipment
                {
                    ID = i,
                    ItemName = $"Equipment {i}",
                    ImageUrl = $"equipment{i}.jpg",
                    StockQuantity = new Random().Next(10, 50),
                    MinQuantity = 5,
                    MaxQuantity = 50,
                    Description = $"Description for Equipment {i}",
                    CostPerUse = Math.Round((decimal)(new Random().NextDouble() * 10), 2),
                    DateAdded = DateTime.Now,
                    ManufacturerID = new Random().Next(1, 10),
                    EquipmentCategoryId = new Random().Next(1, 10),
                    AddedByUserID = 1,
                    IsDeleted = false
                });
            }

            modelBuilder.Entity<Equipment>().HasData(equipmentItems);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { ID = 1, UserID = 3, DatePlaced = DateTime.Now.AddDays(-10), TotalPrice = 59.94m, IsActive = true },
                new Order { ID = 2, UserID = 4, DatePlaced = DateTime.Now.AddDays(-8), TotalPrice = 89.85m, IsActive = true },
                new Order { ID = 3, UserID = 4, DatePlaced = DateTime.Now.AddDays(-5), TotalPrice = 29.97m, IsActive = true },
                new Order { ID = 4, UserID = 5, DatePlaced = DateTime.Now.AddDays(-7), TotalPrice = 19.98m, IsActive = true },
                new Order { ID = 5, UserID = 5, DatePlaced = DateTime.Now.AddDays(-4), TotalPrice = 99.90m, IsActive = true },
                new Order { ID = 6, UserID = 6, DatePlaced = DateTime.Now.AddDays(-3), TotalPrice = 49.95m, IsActive = true },
                new Order { ID = 7, UserID = 7, DatePlaced = DateTime.Now.AddDays(-2), TotalPrice = 69.93m, IsActive = true },
                new Order { ID = 8, UserID = 8, DatePlaced = DateTime.Now.AddDays(-1), TotalPrice = 39.96m, IsActive = true },
                new Order { ID = 9, UserID = 9, DatePlaced = DateTime.Now.AddDays(-6), TotalPrice = 149.85m, IsActive = true },
                new Order { ID = 10, UserID = 10, DatePlaced = DateTime.Now.AddDays(-9), TotalPrice = 29.97m, IsActive = true }
            );
        }

        private static void SeedOrderItems(ModelBuilder modelBuilder)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem { ID = 1, OrderID = 1, EquipmentID = 1, Quantity = 2, CostPerUse = 2.99m, Price = 5.98m, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(-9) },
                new OrderItem { ID = 2, OrderID = 1, EquipmentID = 3, Quantity = 1, CostPerUse = 4.99m, Price = 4.99m, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(-8) },
                new OrderItem { ID = 3, OrderID = 2, EquipmentID = 2, Quantity = 3, CostPerUse = 3.49m, Price = 10.47m, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(-7) },
                new OrderItem { ID = 4, OrderID = 2, EquipmentID = 1, Quantity = 4, CostPerUse = 2.99m, Price = 11.96m, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(-6) },
                new OrderItem { ID = 5, OrderID = 3, EquipmentID = 3, Quantity = 2, CostPerUse = 4.99m, Price = 9.98m, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(-4) },
                new OrderItem { ID = 6, OrderID = 4, EquipmentID = 1, Quantity = 1, CostPerUse = 2.99m, Price = 2.99m, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(-6) },
                new OrderItem { ID = 7, OrderID = 5, EquipmentID = 2, Quantity = 5, CostPerUse = 3.49m, Price = 17.45m, StartDate = DateTime.Now.AddDays(-4), EndDate = DateTime.Now.AddDays(-2) },
                new OrderItem { ID = 8, OrderID = 6, EquipmentID = 3, Quantity = 3, CostPerUse = 4.99m, Price = 14.97m, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-1) },
                new OrderItem { ID = 9, OrderID = 7, EquipmentID = 1, Quantity = 2, CostPerUse = 2.99m, Price = 5.98m, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(1) },
                new OrderItem { ID = 10, OrderID = 8, EquipmentID = 2, Quantity = 3, CostPerUse = 3.49m, Price = 10.47m, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now },
                new OrderItem { ID = 11, OrderID = 9, EquipmentID = 3, Quantity = 1, CostPerUse = 4.99m, Price = 4.99m, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(-4) },
                new OrderItem { ID = 12, OrderID = 9, EquipmentID = 1, Quantity = 5, CostPerUse = 2.99m, Price = 14.95m, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(-5) },
                new OrderItem { ID = 13, OrderID = 10, EquipmentID = 2, Quantity = 2, CostPerUse = 3.49m, Price = 6.98m, StartDate = DateTime.Now.AddDays(-9), EndDate = DateTime.Now.AddDays(-8) }
            };
            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }

        private static void SeedReviews(ModelBuilder modelBuilder)
        {
            var reviews = new List<Review>
            {
                new Review { ID = 1, DateAdded = DateTime.Now.AddDays(-9), Description = "Great quality and very durable!", NumberOfStars = 4.5m, AddedByUserID = 3, OrderItemID = 1, IsDeleted = false },
                new Review { ID = 2, DateAdded = DateTime.Now.AddDays(-8), Description = "Not as expected, could be better.", NumberOfStars = 2.0m, AddedByUserID = 4, OrderItemID = 2, IsDeleted = false },
                new Review { ID = 3, DateAdded = DateTime.Now.AddDays(-7), Description = "Perfect for my needs, highly recommended!", NumberOfStars = 5.0m, AddedByUserID = 5, OrderItemID = 3, IsDeleted = false },
                new Review { ID = 4, DateAdded = DateTime.Now.AddDays(-6), Description = "Good value for the price.", NumberOfStars = 4.0m, AddedByUserID = 6, OrderItemID = 4, IsDeleted = false },
                new Review { ID = 5, DateAdded = DateTime.Now.AddDays(-5), Description = "Satisfactory but delivery was delayed.", NumberOfStars = 3.0m, AddedByUserID = 7, OrderItemID = 5, IsDeleted = false },
                new Review { ID = 6, DateAdded = DateTime.Now.AddDays(-4), Description = "Excellent performance and quality.", NumberOfStars = 5.0m, AddedByUserID = 8, OrderItemID = 6, IsDeleted = false },
                new Review { ID = 7, DateAdded = DateTime.Now.AddDays(-3), Description = "Decent product but could use some improvements.", NumberOfStars = 3.5m, AddedByUserID = 9, OrderItemID = 7, IsDeleted = false },
                new Review { ID = 8, DateAdded = DateTime.Now.AddDays(-2), Description = "Very satisfied with the purchase.", NumberOfStars = 4.5m, AddedByUserID = 10, OrderItemID = 8, IsDeleted = false },
                new Review { ID = 9, DateAdded = DateTime.Now.AddDays(-1), Description = "The item was okay, nothing special.", NumberOfStars = 3.0m, AddedByUserID = 3, OrderItemID = 9, IsDeleted = false },
                new Review { ID = 10, DateAdded = DateTime.Now, Description = "Amazing product! Will buy again.", NumberOfStars = 5.0m, AddedByUserID = 4, OrderItemID = 10, IsDeleted = false }
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
                new CartItem { ID = 1, CartID = 1, EquipmentID = 1, Quantity = 2, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(-5) },
                new CartItem { ID = 2, CartID = 1, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(-5) },
                new CartItem { ID = 3, CartID = 2, EquipmentID = 3, Quantity = 1, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(-4) },
                new CartItem { ID = 4, CartID = 3, EquipmentID = 1, Quantity = 3, StartDate = DateTime.Now.AddDays(-4), EndDate = DateTime.Now.AddDays(-3) },
                new CartItem { ID = 5, CartID = 3, EquipmentID = 2, Quantity = 2, StartDate = DateTime.Now.AddDays(-4), EndDate = DateTime.Now.AddDays(-3) },
                new CartItem { ID = 6, CartID = 4, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-2) },
                new CartItem { ID = 7, CartID = 4, EquipmentID = 3, Quantity = 1, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-2) },
                new CartItem { ID = 8, CartID = 5, EquipmentID = 1, Quantity = 2, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(-1) },
                new CartItem { ID = 9, CartID = 6, EquipmentID = 3, Quantity = 3, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now },
                new CartItem { ID = 10, CartID = 7, EquipmentID = 2, Quantity = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) }
            };
            modelBuilder.Entity<CartItem>().HasData(cartItems);
        }
    }
}
