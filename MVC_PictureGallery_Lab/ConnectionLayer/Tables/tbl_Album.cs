using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
    class tbl_Album
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public GalleryTopics Topic { get; set; }

        public ICollection<tbl_Picture> Pictures { get; set; }
    }
}
