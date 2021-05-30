using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class OrderToProductDal
    {
        public static bool addOrderItem(OrderToProduct op)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                db.OrderToProducts.Add(op);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<OrderToProduct> GetProductsInOrder(int orderId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var products = db.GetProductsInOrderFun(orderId);
                return products.ToList<OrderToProduct>();
            }
        }
    }
}
