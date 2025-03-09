using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddEndpointsApiExplorer();  // Shton Explorer për API
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.

/*using (var scope = app.Services.CreateScope()){
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    DataContext.Seed(context);
}*/

//app.UseAuthorization();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.MapControllers();

app.Run();
