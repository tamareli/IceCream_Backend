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
        public int sizeId { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public List<OrderToProductToppingDto> toppings { get; set; }
        public OrderToProductDto()
        {

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
