using HotelBookingService.Core.Abstractions.Repositories;
using HotelBookingService.Core.Abstractions.Services;
using HotelBookingService.DataAccess;
using HotelBookingService.DataAccess.Repositories;
using HotelBookingService.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();

builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IHotelService, HotelService>();

builder.Services.AddDbContext<HotelBookingDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(HotelBookingDbContext)));
    });

builder.Services.AddHttpClient<IRestaurantService, RestaurantService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5257");
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
