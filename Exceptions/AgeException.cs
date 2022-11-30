using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_8.Exceptions
{
    internal class AgeException:Exception
    {
        public AgeException()
        {
            Console.WriteLine("Age's value cannot be zero and under");
        }
    }
}
