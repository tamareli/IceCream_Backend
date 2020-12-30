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
    }
}
