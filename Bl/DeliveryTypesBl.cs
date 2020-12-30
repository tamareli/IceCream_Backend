using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bl
{
    public class DeliveryTypesBl
    {
        public static List<DeliveryTypesDto> GetDeliveryTypes()
        {
            List<DeliveriesType> types = DeliveryTypesDal.GetDeliveryTypes();
            List<DeliveryTypesDto> dtoTypes = new List<DeliveryTypesDto>();
            for (int i = 0; i < types.Count; i++)
            {
                dtoTypes.Add(new DeliveryTypesDto(types[i]));
            }
            return dtoTypes;
        }
    }
}
