using Ninject;
using OnlineKurs.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Business.DependencyResolves
{
    public  class InstanceFactory
    {
        public static T GetInstance <T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
        
    }
}
