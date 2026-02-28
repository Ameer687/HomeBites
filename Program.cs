using HomeBites.Data;
using HomeBites.Services.Implementations;
using HomeBites.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Controller services
builder.Services.AddControllers();

// Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "HomeBites API",
        Version = "v1"
    });
});

// Database service
builder.Services.AddDbContext<HomeBitesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Custom services
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IVendorService, VendorService>();
builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();

var app = builder.Build();

// Enable Swagger UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeBites API V1");
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
