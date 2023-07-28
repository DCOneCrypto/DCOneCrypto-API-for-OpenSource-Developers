using Microsoft.EntityFrameworkCore;
using DCOneCrypto.Api.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<NetworkService>();
builder.Services.AddScoped<EpochService>();
builder.Services.AddScoped<BlockService>();
builder.Services.AddScoped<TransactionsService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AssetService>();
builder.Services.AddScoped<PoolService>();
builder.Services.AddScoped<ScriptService>();
builder.Services.AddScoped<StakeAccountService>();
builder.Services.AddApiVersioning(options => options.AssumeDefaultVersionWhenUnspecified = true).AddMvc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json",
            $"{builder.Environment.ApplicationName} v1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
