using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class OrderToProductDto
    {
        public int OrderId { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int sizeId { get; set; }
        public string sizeName { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public string image { get; set; }
        public List<OrderToProductToppingDto> toppings { get; set; }
        public OrderToProductDto()
        {

        }
        public OrderToProductDto(OrderToProduct o)
        {
            OrderId = o.OrderId;
            productId = o.productId;
            sizeId = o.sizeId;
            price = o.price;
            amount = Convert.ToInt32(o.amount);

        }
        public static OrderToProduct ToDal(OrderToProductDto op,int orderId)
        {
            return new OrderToProduct
            {
                OrderId = orderId,
                productId = op.productId,
                sizeId=op.sizeId,
                price=op.price,
                amount=op.amount
            };

        }
    }
}
