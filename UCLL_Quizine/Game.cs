using System;
using System.Collections.ObjectModel;

namespace UCLL_Quizine
{
    public class Game
    {
        public string GameCode { get; private set; }
        public ObservableCollection<Player> Players { get; private set; }
        public ObservableCollection<Question> Questions { get; set; }
        public bool Started { get; private set; }
    }
}
