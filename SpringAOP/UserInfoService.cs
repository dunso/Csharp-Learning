using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAOP
{
    class UserInfoService : IUserInfoService
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int DoubleAdd(int b)
        {
            return b + b;
        }
    }
}
