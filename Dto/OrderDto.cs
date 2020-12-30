using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class OrderDto
    {
        public int clientId { get; set; }
        public DateTime orderDate { get; set; }
        public int deliveryTypeId { get; set; }
        public double finalPrice { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }

        public List<OrderToProductDto> orderItems { get; set; }
        public OrderDto()
        {

        }
        public static Order ToDal(OrderDto order)
        {
            return new Order
            {
                clientId = order.clientId,
                orderDate = DateTime.Now,
                createDate=DateTime.Now,
                updateDate=DateTime.Now,
                deliveryTypeId=order.deliveryTypeId,
                finalPrice=order.finalPrice
            };
        }
    }

}
