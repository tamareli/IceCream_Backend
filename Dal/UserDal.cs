﻿using System;
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
    }
}