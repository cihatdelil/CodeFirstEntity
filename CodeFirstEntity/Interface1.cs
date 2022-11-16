using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity
{
public interface Interface1<T>
    {
        void Add(T entity);
       
        List<T> All();
    }
}
