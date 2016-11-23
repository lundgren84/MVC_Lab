using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDLL
{
   public interface GalleryCrud
    {
        void Delete(object objToDelete);
        void Create(object objtoCreate);
        object Read(Guid id,string Type);
        object Read(string Type);
        object GetPictures();
      

    }
}
