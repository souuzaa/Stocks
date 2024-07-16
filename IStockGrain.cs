
public interface IStockGrain : IGrainWithStringKey
{
    Task<int> GetPrice();
}
