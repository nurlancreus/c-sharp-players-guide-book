using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Helpers
{
    internal class Exceptions
    {
        public class InvalidKeyException : Exception
        {
            public InvalidKeyException(string message) : base(message)
            {
            }
        }
    }
}
