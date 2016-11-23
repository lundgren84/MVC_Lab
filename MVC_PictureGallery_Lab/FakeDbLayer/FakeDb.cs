using InterfaceDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDbLayer
{
   public class FakeDb : GalleryCrud
    {
        List



        public void Create(object objtoCreate)
        {
            throw new NotImplementedException();
        }

        public void Delete(object objToDelete)
        {
            throw new NotImplementedException();
        }

        public object GetPictures()
        {
            throw new NotImplementedException();
        }

        public object Read(string Type)
        {
            throw new NotImplementedException();
        }

        public object Read(Guid id, string Type)
        {
            throw new NotImplementedException();
        }

   
    }
}
