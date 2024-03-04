using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal class PlayerException : Exception
    {
        public PlayerException() : base()
        {

        }
        public PlayerException(string message) : base(message)
        {

        }

        public PlayerException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
