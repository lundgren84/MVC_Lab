using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    public class Picture
    {
        public int id { get; set; }
        public string Title { get; set; }
      
        public string url { get; set; }
        public decimal Size { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public Picture()
        {
            this.Comments =new HashSet<Comment>();           
        }
    }
}