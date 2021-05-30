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
                    OrderToProductTopping topping = OrderToProductToppingDto.ToDal(item, id);
                    b = OrderToProductToppingDal.addToppingsToProductInOrder(topping);
            }
            return b;
        }
        public static List<OrderToProductToppingDto> GetOrderToProductToppings(int orderToProductId)
        {
            List<OrderToProductTopping> toppings = OrderToProductToppingDal.GetOrderToProductToppings(orderToProductId);
            List<OrderToProductToppingDto> dtoToppings = new List<OrderToProductToppingDto>();
            for (int i = 0; i < toppings.Count; i++)
            {
                OrderToProductToppingDto topping = new OrderToProductToppingDto(toppings[i]);
                using (IceCreamEntities db = new IceCreamEntities())
                {
                    topping.toppingName = db.Toppings.Where(x => x.toppingId == topping.toppingId).FirstOrDefault().toppingName;
                }
                dtoToppings.Add(topping);
            }
            return dtoToppings;
        }
    }
}
