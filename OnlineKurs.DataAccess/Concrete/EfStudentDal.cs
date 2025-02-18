using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using OnlineKurs.DataAccess.Abstract;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.DataAccess.Concrete
{
    public class EfStudentDal:EfRepositoryBase<Student,OnlineKursContext>,IStudentDal
    {
        

    }
}
