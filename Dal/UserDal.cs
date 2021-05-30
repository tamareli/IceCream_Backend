using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal
    {
        public static int Register(Client u)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var userForEmailCheck = (from c in db.Clients where c.email == u.email select c).FirstOrDefault<Client>();
                if(userForEmailCheck == null)
                {
                   return AddUser(u);
                }
            }
            return 0;
        }
        public static int AddGuestUser(Client u)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                   return AddUser(u);
            }
        }

        public static int AddUser(Client user)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {     
                    db.Clients.Add(user);
                    db.SaveChanges();
                    return user.clientId;     
            }
        }
        public static Client ValidateUser(string email, string password)
        {
            using(IceCreamEntities db = new IceCreamEntities())
            {
                var user = from u in db.Clients where u.email == email && u.password == password select u;
                return user.FirstOrDefault();
            }
        }
        public static Client GetUser(int id)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var user = from u in db.Clients where u.clientId == id && u.password != "guestUser" select u;
                return user.FirstOrDefault();
            }
        }

        public static string GetPasswordByemail(string email)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var user = from u in db.Clients where u.email == email && u.password != "guestUser" select u;
                if (user.FirstOrDefault() != null)
                    return user.FirstOrDefault().password;
                else return null;
            }
        }

    }
}
