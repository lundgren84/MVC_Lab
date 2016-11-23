using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    public enum AlbumTopic
    {
        Love, Fun, Hollyday, Party, Family, Friends, Kids
    }
    public class AlbumViewModels
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public AlbumTopic Topic { get; set; }
        public AlbumViewModels()
        {
            Pictures = new HashSet<Picture>();
        }
    }
}