using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);


    }
}
