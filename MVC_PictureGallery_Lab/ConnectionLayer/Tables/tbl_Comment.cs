using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
    public class tbl_Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public int? PictureRefID { get; set; }
        [ForeignKey(name: "PictureRefID")]
        public virtual tbl_Picture Picture { get; set; }
        public Guid? UserRefID { get; set; }
        [ForeignKey(name: "UserRefID")]
        public virtual tbl_Account Account { get; set; }
     
    }
}
