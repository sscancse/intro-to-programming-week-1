using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

// do some configuration of the services
builder.Services.AddSingleton<DateUtils>();
var app = builder.Build();

app.MapGet("/break/{minutes}", (string minutes, DateUtils utils) =>
{
    return Results.Ok("Take a break for " + minutes + $" minutes! Return at {utils.TakeABreak(int.Parse(minutes))}");
});

app.Run(); // Blocking