using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;
using WebMVC.Models.CartModels;
using WebMVC.Models.OrderModels;

namespace WebMVC.Services
{
    public interface ICartService
    {
        Task<Cart> GetCart(ApplicationUser user);
        Task AddItemsToCart(ApplicationUser user, CartItem product);
        Task<Cart> UpdateCart(Cart cart);
        Task<Cart> SetQuantities(ApplicationUser user, Dictionary<string, int> quantities);
        Task ClearCart(ApplicationUser user);
        Order MapCartToOrder(Cart cart);
    }
}
