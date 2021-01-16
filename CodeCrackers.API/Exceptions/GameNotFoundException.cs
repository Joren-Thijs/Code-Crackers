using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Exceptions
{
    public class GameNotFoundException : NotFoundException
    {
        public GameNotFoundException(string message) : base(message)
        {
        }
    }
}
