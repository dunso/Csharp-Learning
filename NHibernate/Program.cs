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
            var session = sessionFactory.OpenSession();//the same to ef context
            var trans = session.BeginTransaction();

            Student student = new Student();
            student.SName = "dunso";
            student.SubTime = DateTime.Now;
            session.Save(student);
            trans.Commit();
            session.Close();
            
        }
    }
}
