using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class OrderDal
    {
        public static bool addOrder(Order o)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                db.Orders.Add(o);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Order> GetOrdersForUser(int userId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var orders = db.GetOrdersForUserFun(userId);
                return orders.ToList<Order>();
            }
        }
    }
}
