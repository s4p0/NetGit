using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Services
{
    public interface IService<T>
    {
        IEnumerable<T> FindAll();

        T FindOne(int id);

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(T entity);
    }
}
