using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomException : Exception
    {
        public override string Message
        {
            get
            {
                return "Divisor Cannot be Odd Number";
            }
        }

    }
}
