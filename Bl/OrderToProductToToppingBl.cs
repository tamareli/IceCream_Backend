using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl
{
    public class OrderToProductToToppingBl
    {
        public static bool addToppingsToProductInOrder(List<OrderToProductToppingDto> toppings, int id)
        {
            bool b = false;
            foreach (var item in toppings)
            {
                if (item.amount > 0)
                {
                    OrderToProductTopping topping = OrderToProductToppingDto.ToDal(item, id);
                    b = OrderToProductToppingDal.addToppingsToProductInOrder(topping);
                }

            }
            return b;
        }
    }
}
