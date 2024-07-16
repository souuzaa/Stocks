using Orleans.Runtime;

List<string> _symbols = new() { "MSFT", "GOOG", "AAPL", "GME", "AMZN" };

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseOrleans(static builder => 
    {
        builder.UseLocalhostClustering();
        builder.UseDashboard(options => {});
    });
builder.Services.AddHostedService<StocksHostedService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();  

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", static () => "Welcome to the Orleans Stock API!");

app.MapGet("/stock/{symbol:required}",
static async (IGrainFactory grains, string symbol) =>
{
    // Retrieve the grain using the shortened ID and url to the original URL
    var symbolGrain = grains.GetGrain<IStockGrain>(symbol);

    var result = await symbolGrain.GetPrice();

    return result;
});

app.Run();