using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.ComponentModel.DataAnnotations;



namespace Dto
{
    public class OrderDto
    {
        public int orderId { get; set; }
        public int clientId { get; set; }
        public DateTime orderDate { get; set; }
        [Required]
        public int deliveryTypeId { get; set; }

        public string deliveryTypeName { get; set; }

        [Required]
        public double finalPrice { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }

        public List<OrderToProductDto> orderItems { get; set; }
        public OrderDto(Order o)
        {
            orderId = o.orderId;
            clientId = o.clientId;
            orderDate = (DateTime)o.orderDate;
            createDate = (DateTime)o.createDate;
            updateDate = (DateTime)o.updateDate;
            deliveryTypeId = o.deliveryTypeId;
            finalPrice = o.finalPrice;
        }
        public OrderDto()
        {
        }
        public static Order ToDal(OrderDto order)
        {
            return new Order
            {
                clientId = order.clientId,
                orderDate = DateTime.Now,
                createDate= DateTime.Now,
                updateDate= DateTime.Now,
                deliveryTypeId= order.deliveryTypeId,
                finalPrice= order.finalPrice
            };
        }
    }

}
