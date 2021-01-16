using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Exceptions
{
    public class PlayerNotFoundException : NotFoundException
    {
        public PlayerNotFoundException(string message) : base(message)
        {
        }
    }
}
