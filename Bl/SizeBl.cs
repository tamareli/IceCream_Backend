using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl
{
    public class SizeBl
    {
        public static List<SizeDto> GetSizes(int catgId)
        {
            List<Size> sizes = SizeDal.GetSizes(catgId);
            List<SizeDto> dtoSizes = new List<SizeDto>();
            for (int i = 0; i < sizes.Count; i++)
            {
                dtoSizes.Add(new SizeDto(sizes[i]));
            }
            return dtoSizes;
        }
    }
}
