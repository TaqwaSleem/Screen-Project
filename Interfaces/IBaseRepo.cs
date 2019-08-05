using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Interfaces
{
   public interface IBaseRepo<T> where T : class, IBaseModel
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(int id, T t);
        void Delete(int id);
    }
}
