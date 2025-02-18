using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.DataAccess.Abstract
{
    public interface IStudentDal:IEntityRepository<Student>
    {
        
    }
}
