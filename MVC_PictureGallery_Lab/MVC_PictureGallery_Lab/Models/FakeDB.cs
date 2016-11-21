using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PictureGallery_Lab.Models
{
    public class FakeDB
    {
        public List<AlbumViewModel> Albums { get; set; }
        public List<AccountViewModel> Accounts { get; set; }
        public List<PictureViewModel> Pictures { get; set; }
    }
}