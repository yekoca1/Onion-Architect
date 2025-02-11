using ETicaretAPI.Persistance;
var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;//Confşguration dosyası için 


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger'ı düzgün çalıştırmak için daha açıklayıcı hale getiriyoruz.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "E-Ticaret API",
        Version = "v1",
        Description = "E-Ticaret API'si ile ürün yönetimi"
    });
});

builder.Services.AddPersistanceServices(); //çalışabilmesi için peresentation'ın persistance'ı referans etmesi gerekiyor.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "E-Ticaret API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();


builder.Configuration
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();