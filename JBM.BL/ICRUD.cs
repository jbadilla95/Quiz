using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBM.BL
{
  public   interface ICRUD<T>
    {
         void Add(T ENTITY);
         void delete(T ENTITY );
         void update(T ENTITY);
        void Find(T ENTITY);


    }
}
