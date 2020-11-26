using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class ToppingsForProductDto
    {
        public int toppingForProductId { get; set; }
        public Nullable<int> productCategoryId { get; set; }
        public Nullable<int> toppingCategoryId { get; set; }

        public ToppingsForProductDto()
        {

        }
        public ToppingsForProductDto(ToppingsForProduct topCategory)
        {
            toppingForProductId = topCategory.toppingForProductId;
            productCategoryId = topCategory.productCategoryId;
            toppingCategoryId = topCategory.toppingCategoryId;
        }
    }
}
