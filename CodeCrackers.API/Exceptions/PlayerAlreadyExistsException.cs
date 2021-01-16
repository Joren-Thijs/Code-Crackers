using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Exceptions
{
    public class PlayerAlreadyExistsException : ArgumentException
    {
        public PlayerAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
