using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DeliveryTypesDal
    {
        public static List<DeliveriesType> GetDeliveryTypes()
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {

                var types = db.GetDeliveryTypesFun();//stored Procedure
                return types.ToList<DeliveriesType>();
            }
        }
    }
}
