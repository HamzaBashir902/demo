using Microsoft.EntityFrameworkCore;
using EMS.Application.UOW;
using EMS.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // Unit of Work Interface scoped ki hai
builder.Services.AddDbContext<EmployeeDbContext>(options =>
{
    options.UseSqlServer("Server=.;Database=EMS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");  // API URL

}); // add the connection of Database and inject DB context class

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
