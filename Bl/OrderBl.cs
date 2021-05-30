using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl
{
    public class OrderBl
    {
        public static bool addOrder(OrderDto order)
        {
            Order o = OrderDto.ToDal(order);
            bool b = OrderDal.addOrder(o);
            bool c = OrderToProductBl.addOrdersProducts(order.orderItems,o.orderId);
            return b&&c;

        }
        public static List<OrderDto> getOrders(int userId)
        {
            //categories from dataBase
            List<Order> orders = OrderDal.GetOrdersForUser(userId);
            List<OrderDto> dtoOrders = new List<OrderDto>();
            for (int i = 0; i < orders.Count; i++)
            {
                OrderDto order = new OrderDto(orders[i]);
                using (IceCreamEntities db = new IceCreamEntities())
                {
                    order.deliveryTypeName = db.DeliveriesTypes.Where(x => x.deliveryTypeId == order.deliveryTypeId).FirstOrDefault().deliveryDescription;
                }
                order.orderItems = OrderToProductBl.GetOrderToProduct(orders[i].orderId);
                dtoOrders.Add(order);
            }
            return dtoOrders;
        }
    }
}
