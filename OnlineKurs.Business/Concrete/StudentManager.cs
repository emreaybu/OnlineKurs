using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using OnlineKurs.Business.Abstract;
using OnlineKurs.DataAccess.Abstract;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.Business.Concrete
{
     public class StudentManager:IStudentService
     {
         private IStudentDal _studentDal;

         public StudentManager(IStudentDal studentDal)
         {
             _studentDal = studentDal;
         }
         public List<Student> GetAll()
         {
             return _studentDal.GetAll();
         }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }
    }
}
