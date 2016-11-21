using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDLL
{
    interface ICrud
    {
        void Delete(object objToDelete);
        void Create(object objtoCreate);
        object Read(Guid id);


    }
}
