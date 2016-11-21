using InterfaceDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PictureGallery_Lab.Models
{
    public class FakeDB : ICrud
    {
        public  List<AlbumViewModel> Albums { get; set; }
        public  List<AccountViewModel> Accounts { get; set; }
        public  List<PictureViewModel> Pictures { get; set; }
        public  List<CommentViewModel> Comments { get; set; }

        public void Delete(object objToDelete)
        {
            if (objToDelete is AlbumViewModel)
            {
                var r = Albums.Where(x => x.id == ((AlbumViewModel)objToDelete).id).FirstOrDefault();
                Albums.Remove(r);
            }
            else if (objToDelete is AccountViewModel)
            {
                var r = Accounts.Where(x => x.id == ((AccountViewModel)objToDelete).id).FirstOrDefault();
                Accounts.Remove(r);
            }
            else if (objToDelete is CommentViewModel)
            {
                var r = Comments.Where(x => x.id == ((CommentViewModel)objToDelete).id).FirstOrDefault();
                Comments.Remove(r);
            }
            else if (objToDelete is PictureViewModel)
            {
                var r = Pictures.Where(x => x.id == ((PictureViewModel)objToDelete).id).FirstOrDefault();
                Pictures.Remove(r);
            }
        }

        public void Create(object objtoCreate)
        {
            if (objtoCreate is AlbumViewModel)
            {
                Albums.Add(objtoCreate as AlbumViewModel);
            }
            else if (objtoCreate is AccountViewModel)
            {
                Accounts.Add(objtoCreate as AccountViewModel);
            }
            else if (objtoCreate is CommentViewModel)
            {
                Comments.Add(objtoCreate as CommentViewModel);
            }
            else if (objtoCreate is PictureViewModel)
            {
                Pictures.Add(objtoCreate as PictureViewModel);
            }
        }

        public object Read(Guid id,string Type)
        {
            throw new NotImplementedException();
        }
        public object Read(string Type)
        {
            if(Type == "Picture")
            {
                return Pictures;
            }
            return new List<PictureViewModel>();
        }
    }
}