using BenchmarkSingletonServices.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<UtilityService>();
builder.Services.AddSingleton<InjectedService11>();
builder.Services.AddSingleton<InjectedService12>();
builder.Services.AddSingleton<InjectedService13>();
builder.Services.AddSingleton<InjectedService14>();
builder.Services.AddSingleton<InjectedService15>();
builder.Services.AddSingleton<InjectedService21>();
builder.Services.AddSingleton<InjectedService22>();
builder.Services.AddSingleton<InjectedService23>();
builder.Services.AddSingleton<InjectedService24>();
builder.Services.AddSingleton<InjectedService25>();
builder.Services.AddSingleton<InjectedService31>();
builder.Services.AddSingleton<InjectedService32>();
builder.Services.AddSingleton<InjectedService33>();
builder.Services.AddSingleton<InjectedService34>();
builder.Services.AddSingleton<InjectedService35>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();

