using System;
using System.Collections.ObjectModel;

namespace UCLL_Quizine
{
    public class Game
    {
        public string GameCode { get; set; }

        public ObservableCollection<Player> Players { get; set; }

        public ObservableCollection<Question> Questions { get; set; }
     }
}
