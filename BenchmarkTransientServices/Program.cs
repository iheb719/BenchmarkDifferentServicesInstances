using BenchmarkTransientServices.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<UtilityService>();
builder.Services.AddTransient<InjectedService11>();
builder.Services.AddTransient<InjectedService12>();
builder.Services.AddTransient<InjectedService13>();
builder.Services.AddTransient<InjectedService14>();
builder.Services.AddTransient<InjectedService15>();
builder.Services.AddTransient<InjectedService21>();
builder.Services.AddTransient<InjectedService22>();
builder.Services.AddTransient<InjectedService23>();
builder.Services.AddTransient<InjectedService24>();
builder.Services.AddTransient<InjectedService25>();
builder.Services.AddTransient<InjectedService31>();
builder.Services.AddTransient<InjectedService32>();
builder.Services.AddTransient<InjectedService33>();
builder.Services.AddTransient<InjectedService34>();
builder.Services.AddTransient<InjectedService35>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();

