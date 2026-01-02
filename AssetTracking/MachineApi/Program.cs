using MachineApi.Data;
using MachineApi.Services;
using MachineApi.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<MongoDbContext>();


builder.Services.AddScoped<IDatareader,MongoDataReader>();
builder.Services.AddScoped<DataImportService>();
builder.Services.AddScoped<MachineService>();


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseCors("AllowBlazor");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "");
app.Run();
