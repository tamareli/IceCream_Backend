using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class SizeDto
    {
        public int sizeId { get; set; }
        public string sizeName { get; set; }
        public int categoryId { get; set; }
        public double price { get; set; }

        public SizeDto()
        {

        }
        public SizeDto(Size s)
        {
            sizeId = s.sizeId;
            sizeName = s.sizeName;
            categoryId = s.categoryId;
            price = s.price;

        }

    }
}
