using Microsoft.EntityFrameworkCore;
using DCOneCrypto.Api.Services;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;

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
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "DCOneCryptoApi Documentation",
            Version = "v1",
            Description = "This is a DCOneCryptoApi.",
            Contact = new OpenApiContact
            {
                Name = "DCOne Crypto",
                Email = "admin@dconecrypto.finance"
            },
            Extensions = new Dictionary<string, IOpenApiExtension>
            {
              {"x-logo", new OpenApiObject
                {
                   {"url", new OpenApiString("https://dconecrypto.finance/Common/Images/app-logo-on-dark.svg")},
                   { "altText", new OpenApiString("DCOneCryptoApi")}
                }
              }
            }
        });
});;

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    options.SwaggerEndpoint("/swagger/v1/swagger.json",
    "DConecrypto Demo Documentation v1"));

    app.UseReDoc(options =>
    {
        options.DocumentTitle = "DConecrypto Demo Documentation";
        options.SpecUrl = "/swagger/v1/swagger.json";
    });
}
// app.UseSwagger();
// app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json",
//             $"{builder.Environment.ApplicationName} v1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
