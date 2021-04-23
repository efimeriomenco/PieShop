using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PieShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string shoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            //Checking if the user has a cart Id

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            //If user has a cart id then it creates a new instance of a shopping cart

            return new ShoppingCart(context) { shoppingCartId = cartId };
        }

        public void AddToCart(Pie pie, int amount)
        {
            //Checking if that pie id can be found for that search in Shopping Cart
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Pie.pieId == pie.pieId && s.shoppingCartId == shoppingCartId);

            //If it is null (pie was not in the shopping cart yet) then create a new shopping cart and set the pie. 
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    shoppingCartId = shoppingCartId,
                    Pie = pie,
                    amountOfPies = 1
                };
                //Then add that shoppingCartItem to the list currently managed by _AppdbContext in its dbSet
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            //If it did already find it , then increase the amount(+1)
            {
                shoppingCartItem.amountOfPies++;
            }
            //And then call _appDbContext to save the changes
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Pie pie)
        //Pretty similar as the AddToCart.
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Pie.pieId == pie.pieId && s.shoppingCartId == shoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.amountOfPies > 1)
                {
                    shoppingCartItem.amountOfPies--;
                    localAmount = shoppingCartItem.amountOfPies;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }
        
        public List<ShoppingCartItem> GetShoppingCartItems()
        //GetShoppingCartItems will look if the shopping cart items were already previously retrieved in this current ShoppingCart instance.
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _appDbContext.ShoppingCartItems.Where(c => c.shoppingCartId == shoppingCartId)
                           .Include(s => s.Pie)
                           .ToList());
        }

        public void ClearCart()
        {
            //Removes the all shopping cart items that are associated with shopping cart id
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.shoppingCartId == shoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            //Calculate the all items from the shopping cart and returns that total.
            var total = _appDbContext.ShoppingCartItems.Where(c => c.shoppingCartId == shoppingCartId)
                .Select(c => c.Pie.piePrice * c.amountOfPies).Sum();
            return total;
        }
    }
}
