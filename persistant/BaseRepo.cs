using ScreenProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.persistant
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseModel
    {
        public MyAppContext _myHelperContext;
        public BaseRepo(MyAppContext context)
        {
            _myHelperContext = context;

        }

        // GET: api/<controller>
        public List<T> GetAll()
        {
            return _myHelperContext.Set<T>().ToList();
        }


        public T Get(int id)
        {
            T t = _myHelperContext.Set<T>().Where(c => c.Id == id).FirstOrDefault();
            return t;
        }

        // POST api/values
        public void Add(T t)
        {
            _myHelperContext.Set<T>().Add(t);
            _myHelperContext.SaveChanges();
        }

        // PUT api/values/5

        public void Update(int id, T up_t)
        {
            _myHelperContext.Update(up_t);
            _myHelperContext.SaveChanges();

        }

        public void Delete(int id)
        {
            _myHelperContext.Set<T>().Remove(Get(id));
            _myHelperContext.SaveChanges();

        }
    }

}
