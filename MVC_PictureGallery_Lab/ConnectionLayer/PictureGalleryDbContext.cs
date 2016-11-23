using ConnectionLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer
{
   public class PictureGalleryDbContext:DbContext
    {
        public DbSet<tbl_Account> Accounts { get; set; }
        public DbSet<tbl_Album> Albums { get; set; }
        public DbSet<tbl_Comment> Comments { get; set; }
        public DbSet<tbl_Picture> Pictures { get; set; }
    }
}
