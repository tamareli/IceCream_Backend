using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class SizeDal
    {
        public static List<Size> GetSizes(int catgId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var sizes = db.GetSizesByCatgIdFun(catgId);
                return sizes.ToList<Size>();
            }
        }
    }
}
