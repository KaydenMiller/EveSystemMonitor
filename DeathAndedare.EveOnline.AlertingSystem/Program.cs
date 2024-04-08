using DeathAndedare.EveOnline.AlertingSystem.Endpoints;
using DeathAndedare.EveOnline.AlertingSystem.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointModulesAssemblyWithType<Program>();
builder.Services.AddSingleton<AlertService>();
builder.Services.AddSingleton<MongoDatabase>();
builder.Services.Configure<MongoDatabaseOptions>(
    builder.Configuration.GetRequiredSection(MongoDatabaseOptions.SECTION_NAME));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseEndpointModules();

app.Run();