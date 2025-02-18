using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using OnlineKurs.Business.Abstract;
using OnlineKurs.Business.Concrete;
using OnlineKurs.DataAccess.Abstract;
using OnlineKurs.DataAccess.Concrete;

namespace OnlineKurs.Business.DependencyResolves
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
        }
    }
}
