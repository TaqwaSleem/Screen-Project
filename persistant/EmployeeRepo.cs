using ScreenProject.Interfaces;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.persistant
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {
        private MyAppContext _AppContext;

        public EmployeeRepo(MyAppContext appContext) : base(appContext)
        {
            _AppContext = appContext;

        }

        public List<Employee> GetAll()
        {
            return _AppContext.Employees.ToList();
        }


    }
}
