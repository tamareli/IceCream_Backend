using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal
    {
        public static bool Register(Client u)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                db.Clients.Add(u);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static Client ValidateUser(string email, string password)
        {
            using(IceCreamEntities db = new IceCreamEntities())
            {
                var userList = from u in db.Clients select u;
                var user = userList.FirstOrDefault(x => x.email == email && x.password == password);
                return user;
            }
        }
        public static Client LogIn(int id)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var userList = from u in db.Clients select u;
                var user = userList.FirstOrDefault(x => x.clientId == id);
                return user;
            }
        }


    }
}
