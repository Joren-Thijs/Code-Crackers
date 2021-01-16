using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace CodeCrackers.API.Entities
{
    public class Round
    {
        public Question Question { get; set; }
        public List<PlayerAnswer> PlayerAnswers { get; set; }
        public Timer Timer { get; set; }
    }
}
