using MonHunDex.Data;
using MonHunDex.Services.Monster;
using MonHunDex.Services.Move;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Services
builder.Services.AddScoped<IMonsterService, MonsterService>();
builder.Services.AddScoped<IMoveService, MoveService>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
