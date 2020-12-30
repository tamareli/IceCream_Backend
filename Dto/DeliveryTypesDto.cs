using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class DeliveryTypesDto
    {
        public int deliveryTypeId { get; set; }
        public string deliveryDescription { get; set; }
        public double price { get; set; }
        public DeliveryTypesDto()
        {

        }
        public DeliveryTypesDto(DeliveriesType dt)
        {
            deliveryTypeId = dt.deliveryTypeId;
            deliveryDescription = dt.deliveryDescription;
            price = dt.price;
        }
    }
}
