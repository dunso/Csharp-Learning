using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInfoService userInfoService = new UserInfoService();
            int result = userInfoService.add(3,4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
