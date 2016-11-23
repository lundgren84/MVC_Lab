using ConnectionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PictureGallery_Lab.Models
{
    public class AlbumViewModel
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public AlbumTopic Topic { get; set; }
        public List<PictureViewModel> Pictures { get; set; }
    }
}