using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab_MVC_med_Javascript_och_Ajax.Models;
using System.Data.Entity;
using InterfaceLibrary;

namespace Lab_MVC_med_Javascript_och_Ajax.DBConnection
{
    public class CRUD:ICrud
    {
        internal static List<Picture> GetPictures()
        {      
            using (var ctx = new GalleryDbContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                return ctx.Pictures.Include(x => x.Comments).ToList<Picture>();          
            }
        }

        internal static bool CheckLogin(User user)
        {
            bool success = false;
            using (var ctx = new GalleryDbContext())
            {
                var theUser = ctx.Users.FirstOrDefault(x=> x.email.Equals(user.email));
                string password = HelpClass.HashnSalt.GenerateSHA256Hash(user.hash, theUser.Salt);
                if(((ctx.Users.Where(x=>x.hash.Equals(password) && x.email.Equals(user.email))).ToList()).Count == 1)
                {
                    success = true;
                }


            }
            return success;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public object Get()
        {
            throw new NotImplementedException();
        }
    }
}