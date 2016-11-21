using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
    class tbl_Picture
    {
        public int id { get; set; }
        public string Title { get; set; }

        public string url { get; set; }
        public decimal Size { get; set; }
        public Guid? AlbumRefID { get; set; }
        [ForeignKey(name: "AlbumRefID")]
        public virtual tbl_Album Album { get; set; }
        public virtual ICollection<tbl_Comment> Comments { get; set; }
        public tbl_Picture()
        {
            this.Comments = new HashSet<tbl_Comment>();
        }    
    }
}
