using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class OrderToProductToppingDal
    {
        public static bool addToppingsToProductInOrder(OrderToProductTopping topping)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                db.OrderToProductToppings.Add(topping);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
