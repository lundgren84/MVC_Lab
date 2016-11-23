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
        public PictureViewModel Picture { get; set; }
        public AccountViewModel Account { get; set; }        
    }
}