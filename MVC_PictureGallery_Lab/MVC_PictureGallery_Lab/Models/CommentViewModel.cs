using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PictureGallery_Lab.Models
{
    public class CommentViewModel
    {
        public Guid id { get; set; }
        public string content { get; set; }
        public Guid PictureID { get; set; }     
        public Guid AccountID { get; set; }    
     
    }
}