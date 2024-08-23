using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem.Services.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add AutoMapper configuration
builder.Services.AddAutoMapper(typeof(Program), typeof(MappingProfile));

// Add services to the container
builder.Services.AddTransient<IEquipmentCategoryService, EquipmentCategoryService>();
builder.Services.AddTransient<IManufacturerService, ManufacturerService>();
builder.Services.AddTransient<IEquipmentService, EquipmentService>();
builder.Services.AddTransient<ICartService, CartService>();
builder.Services.AddTransient<IUsersService, UserService>();
builder.Services.AddTransient<IOrderService, OrderService>();

// Add Controllers
builder.Services.AddControllers();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework Core with SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RentSistemDbContext>(options =>
        options.UseSqlServer(connectionString));

// Configure Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

// Configure Authorization
builder.Services.AddAuthorization(options =>
{
    // Define policies if needed
    // options.AddPolicy("MyCustomPolicy", policy => policy.RequireClaim("MyClaimType"));
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
