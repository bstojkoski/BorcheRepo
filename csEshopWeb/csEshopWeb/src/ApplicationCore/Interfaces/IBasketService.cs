using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task<int> GetBasketItemCountAsync(string userName);
        Task TransferBasketAsync(string anonymousId, string userName);
        Task AddItemToBasket(int basketId, int quantity, decimal price, int catalogItemId);
        Task SetQuantities(int basketId, Dictionary<string, int> quantities);
        Task DeleteBasketAsync(int basketId);
    }
}
