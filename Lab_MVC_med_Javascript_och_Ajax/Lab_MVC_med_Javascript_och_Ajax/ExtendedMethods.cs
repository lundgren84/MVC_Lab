using Lab_MVC_med_Javascript_och_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax
{
    public static class ExtendedMethods
    {
        public static Picture FillAllData(this Picture picture)
        {
            using (var ctx = new GalleryDbContext())
            {
                foreach (var item in picture.Comments)
                {
                    if (item.UserRefID != null)
                        item.User = ctx.Users.Find(item.UserRefID);
                }
            }
            return picture;
        }      
    }
}