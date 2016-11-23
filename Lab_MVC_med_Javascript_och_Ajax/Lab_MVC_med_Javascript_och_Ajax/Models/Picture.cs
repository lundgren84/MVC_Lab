using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    public class Picture
    {
        public int id { get; set; }
        public string Title { get; set; }
        [Required]
        public string url { get; set; }
        [Required]
        public int Size { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public Picture()
        {
            this.Comments =new HashSet<Comment>();           
        }
    }
 
}