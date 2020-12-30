using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ToppingDal
    {
        public static List<Topping> GetToppingsById(int catgId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var toppings = db.GetToppingsByIdFun(catgId);
                return toppings.ToList<Topping>();
            }
        }
        public static List<Topping> GetToppingsForCatgProduct(int catgProductId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {

                var categories = db.GetToppingsForCatgProductFun(catgProductId);//storedProcedure
                return categories.ToList<Topping>();
            }
        }
    }
}
