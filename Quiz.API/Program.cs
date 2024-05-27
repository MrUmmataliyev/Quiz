using Quiz.Application;
using Quiz.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddQuizInfrastructureDependencyInjection(builder.Configuration);
builder.Services.AddQuizApplicationDependencyInjection();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors(ops =>
{
    ops.AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin();
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
