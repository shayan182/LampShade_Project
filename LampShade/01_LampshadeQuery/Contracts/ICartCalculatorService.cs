using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;
using SopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Contracts
{
    public interface ICartCalculatorService
    {
        Cart ComputeCart(List<CartItem> cartItems);
    }
}
