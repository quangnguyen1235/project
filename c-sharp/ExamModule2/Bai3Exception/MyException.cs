using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3Exception
{
    class MyException: Exception
    {
        public MyException(string message) :base (message)
        {
            
        }
    }
}
