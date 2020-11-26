using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class ToppingDto
    {
        public int toppingId { get; set; }
        public string toppingName { get; set; }
        public int categoryId { get; set; }
        public double price { get; set; }
        public bool active { get; set; }
        public int order { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string image { get; set; }

        public ToppingDto(Topping t)
        {
            toppingId = t.toppingId;
            toppingName = t.toppingName;
            categoryId = t.categoryId;
            price = t.price;
            active = t.active;
            order = t.order;
            createDate = t.createDate;
            updateDate = t.updateDate;
            image = t.image;
        }
        public ToppingDto()
        {

        }
    }
}
