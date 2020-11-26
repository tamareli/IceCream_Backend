using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bl
{
    public class ToppingBl
    {
        public static List<ToppingDto> GetToppingsById(int catgId)
        {
            //products from dataBase for certain category
            List<Topping> toppings = ToppingDal.GetToppingsById(catgId);
            List<ToppingDto> dtoToppings = new List<ToppingDto>();
            //converting Dal Object to Dto
            for (int i = 0; i < toppings.Count; i++)
            {
                dtoToppings.Add(new ToppingDto(toppings[i]));
            }
            return dtoToppings;
        }
        public static List<ToppingDto> GetToppingsForCatgProduct(int catgProductId)
        {
            //categories from dataBase
            List<Topping> toppings = ToppingDal.GetToppingsForCatgProduct(catgProductId);
            List<ToppingDto> dtoToppings = new List<ToppingDto>();
            for (int i = 0; i < toppings.Count; i++)
            {
                dtoToppings.Add(new ToppingDto(toppings[i]));
            }
            return dtoToppings;
        }
    }
}
