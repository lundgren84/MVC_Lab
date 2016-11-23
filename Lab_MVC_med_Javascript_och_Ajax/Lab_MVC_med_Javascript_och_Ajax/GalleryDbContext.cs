using Lab_MVC_med_Javascript_och_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext() : base("name =GalleryDbContextConnectionString")
        {

        }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }     
        public DbSet<AlbumViewModels> AlbumViewModels { get; set; }
    }
}