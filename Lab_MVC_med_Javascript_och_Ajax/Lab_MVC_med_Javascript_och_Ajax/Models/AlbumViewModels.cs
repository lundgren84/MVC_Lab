using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    //[Required(ErrorMessage = "Required")]
    //[StringLength(10, MinimumLength = 1, ErrorMessage = "1-10 Character")]
    //[DataType(DataType.Date)]
    public enum AlbumTopic
    {
        Love, Fun, Hollyday, Party, Family, Friends, Kids
    }
    public class AlbumViewModels
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "1-10 Character")]      
        public string Name { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public AlbumTopic Topic { get; set; }
        public AlbumViewModels()
        {
            Pictures = new HashSet<Picture>();
        }
    }
}