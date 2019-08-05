using ScreenProject.Interfaces;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.persistant
{
    public class TemplateRepo : BaseRepo<Template>, ITemplateRepo
    {
        private MyAppContext _AppContext;

        public TemplateRepo(MyAppContext appContext) : base(appContext)
        {
            _AppContext = appContext;

        }
        public List<Template> GetAll()
        {
            
            return _AppContext.Templates.ToList();
        }
    }
}
