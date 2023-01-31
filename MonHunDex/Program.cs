using MonHunDex.Data;
using MonHunDex.Services.Ailment;
using MonHunDex.Services.Behavior;
using MonHunDex.Services.Element;
using MonHunDex.Services.Location;
using MonHunDex.Services.LocationType;
using MonHunDex.Services.Monster;
using MonHunDex.Services.MonsterAilments;
using MonHunDex.Services.MonsterClass;
using MonHunDex.Services.MonsterElement;
using MonHunDex.Services.MonsterLocation;
using MonHunDex.Services.MonsterMove;
using MonHunDex.Services.MonsterTitle;
using MonHunDex.Services.MonsterWeakness;
using MonHunDex.Services.Move;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Services
builder.Services.AddScoped<IAilmentService, AilmentService>();
builder.Services.AddScoped<IBehaviorService, BehaviorService>();
builder.Services.AddScoped<IElementService, ElementService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationTypeService, LocationTypeService>();
builder.Services.AddScoped<IMonsterService, MonsterService>();
builder.Services.AddScoped<IMonsterAilmentService, MonsterAilmentService>();
builder.Services.AddScoped<IMonsterClassService, MonsterClassService>();
builder.Services.AddScoped<IMonsterElementService, MonsterElementService>();
builder.Services.AddScoped<IMonsterLocationService, MonsterLocationService>();
builder.Services.AddScoped<IMonsterMoveService, MonsterMoveService>();
builder.Services.AddScoped<IMonsterTitleService, MonsterTitleService>();
builder.Services.AddScoped<IMonsterWeaknessService, MonsterWeaknessService>();
builder.Services.AddScoped<IMoveService, MoveService>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddCors(options => options.AddPolicy(name: "MonHunDexOrigins", policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MonHunDexOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
