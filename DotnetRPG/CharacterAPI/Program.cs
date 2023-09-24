using CharacterAPI.Data;
using CharacterAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    var provider = builder.Configuration.GetValue("provider", "sqlserver").ToLower();
    switch(provider)
    {
        case "sqlserver":
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"));
            break;
        }
        case "mysql":
        {
            options.UseMySQL(builder.Configuration.GetConnectionString("MySQL"));
            break;
        }
        default:
        {
            throw new Exception("Invalid provider");
        }
    }
});

builder.Configuration.AddCommandLine(args);
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ICharacterService, CharacterService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
