using Orleans.Providers;

namespace Stocks.Grains;

[StorageProvider(ProviderName = "OrleansMemoryProvider")]
public sealed class StockGrain : Grain, IStockGrain
{
    public Task<int> GetPrice()
    {
        var rand = new Random();
        return Task.FromResult(rand.Next(0,100));
    } 
}