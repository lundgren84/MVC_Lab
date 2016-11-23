using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
  public enum GalleryTopics
    {
        Hollyday, Work, Family, Fun, Love, Default,
    }
    public class tbl_Album
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public GalleryTopics Topic { get; set; }
        public virtual ICollection<tbl_Picture> Pictures { get; set; }
        public tbl_Album()
        {
            this.Pictures = new HashSet<tbl_Picture>();
        }
    }
}
