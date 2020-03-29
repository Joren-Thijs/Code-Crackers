namespace UCLL_Quizine
{
    public class Player
    {
        public Player(string playerName)
        {
            this.Name = playerName;
            this.Score = 0;
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
}