using ConnectionLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer
{
   public class Crud
    {
        public void AddAccount(tbl_Account acc)
        {
            using (var ctx = new PictureGalleryDbContext())
            {
                ctx.Accounts.Add(acc);
            }
        }
    }
}
