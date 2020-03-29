using System;

namespace UCLL_Quizine
{
    public class Player
    {
        public Player(string playerName)
        {
            if (String.IsNullOrWhiteSpace(playerName))
            {
                throw new ArgumentNullException("The playerName cannot be null or empty.");
            }

            this.Name = playerName;
            this.Score = 0;
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
}