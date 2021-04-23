using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class ShoppingCartItem
    {
        public int shoppingCartItemId { get; set; }
        public Pie Pie { get; set; }
        public int amountOfPies { get; set; }
        public string shoppingCartId { get; set; }
    }
}
