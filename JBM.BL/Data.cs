using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBM.DAL;

namespace JBM.BL
{
    public class Data : ICRUD<Datos>
    {
        public void Add(Datos ENTITY)
        {
            using (QuizEntities context = new QuizEntities())
            {

                context.Datos.Add(ENTITY);
                context.SaveChanges();
            }
        }

        public void delete(Datos ENTITY)
        {
            throw new NotImplementedException();
        }

        public void Find(Datos ENTITY)
        {
            throw new NotImplementedException();
        }

        public void update(Datos ENTITY)
        {
            throw new NotImplementedException();
        }
    }
}
