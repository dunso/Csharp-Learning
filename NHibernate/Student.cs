using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate
{
    class Student
    {
        public virtual int id { get; set; }
        public virtual string SName { get; set; }
        public virtual DateTime SubTime { get; set; }
    }
}
