using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public int? PictureRefID { get; set; }
        [ForeignKey(name: "PictureRefID")]
        public virtual Picture Picture { get; set; }
        public Guid? UserRefID { get; set; }
        [ForeignKey(name:"UserRefID")]
        public virtual User User { get; set; }
    }
}