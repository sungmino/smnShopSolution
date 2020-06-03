using System;
using System.Collections.Generic;
using System.Text;

namespace smnShopSolutio.Utilities.Exceptions
{
    public class SMNShopException : Exception
    {
        public SMNShopException()
        {
        }

        public SMNShopException(string message)
            : base(message)
        {
        }

        public SMNShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
