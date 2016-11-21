using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PictureGallery_Lab.Models
{
    public class PictureViewModel
    {
        public Guid id { get; set; }
        public string Title { get; set; }

        public string url { get; set; }
        public int Size { get; set; }
        public Guid AccountID { get; set; }
        public Guid AlbumID { get; set; }
        public virtual List<Guid> CommentsID { get; set; }
    }
}