using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bl
{
    public class OrderToProductBl
    {
        public static bool addOrdersProducts(List<OrderToProductDto> orderItems, int orderId)
        {
            bool b = false;
            foreach (var item in orderItems)
            {
                OrderToProduct op = OrderToProductDto.ToDal(item, orderId);
                b = OrderToProductDal.addOrderItem(op);
                bool c = OrderToProductToToppingBl.addToppingsToProductInOrder(item.toppings, op.OrderToProductId);
            }
            return b;
        }
    }
}
