using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate
{
    class Program
    {
        static void Main(string[] args)
        {

            ISessionFactory sessionFactory =
            new Configuration().Configure().BuildSessionFactory();

            //create a session
            var session = sessionFactory.OpenSession();//相当于EF的上下文

        }
    }
}
