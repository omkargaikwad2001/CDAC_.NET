using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Exception
{
    class PasswordToLongException: Exception
    {
        public PasswordToLongException(string msg):base(msg) { }
    }

    class PasswordToShortException : Exception
    {
        public PasswordToShortException(string msg):base(msg) { }
    }
}
