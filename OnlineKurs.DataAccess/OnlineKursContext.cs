using OnlineKurs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.DataAccess
{
    public class OnlineKursContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
