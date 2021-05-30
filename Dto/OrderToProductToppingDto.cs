using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Dto
{
    public class OrderToProductToppingDto
    {
        public int orderToProductId { get; set; }
        public int toppingId { get; set; }
        public string toppingName { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public OrderToProductToppingDto()
        {

        }
        public OrderToProductToppingDto(OrderToProductTopping o)
        {
            orderToProductId = o.orderToProductId;
            toppingId = o.toppingId;
            price = Convert.ToDouble(o.price);
            amount = Convert.ToInt32(o.amount);
        }
        public static OrderToProductTopping ToDal(OrderToProductToppingDto opt, int id)
        {
            return new OrderToProductTopping
            {
                orderToProductId = id,
                toppingId = opt.toppingId,
                price = opt.price,
                amount = opt.amount
            };
        }
    }
}
