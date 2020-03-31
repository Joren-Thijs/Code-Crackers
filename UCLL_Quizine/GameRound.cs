using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace UCLL_Quizine
{
    public class GameRound
    {
        public GameRound() {}

        public GameRound(Question question, int roundTime)
        {
            Question = question;
            RoundTime = roundTime;
        }

        public Question Question { get; set; }
        public Dictionary<Player, List<char>> Answers { get; private set; } = new Dictionary<Player, List<char>>();
        public int RoundTime { get; private set; } = 0;
        public int ElapsedRoundTime { get; private set; } = 0;
        public Timer Timer { get; private set; } = new Timer();
        public event EventHandler RoundOverEvent;

        public void StartRound()
        {
            if (Question == null)
            {
                throw new NullReferenceException("Question cannot be null.");
            }

            // Setup timer
            Timer.AutoReset = true;
            Timer.Interval = 1000;
            Timer.Elapsed += TimerElapsed;
            Timer.Enabled = true;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            ElapsedRoundTime++;
            if (ElapsedRoundTime >= RoundTime)
            {
                EndRound();
            }
        }

        public bool AnswerQuestion(Player player, List<char> playerAnswers)
        {
            Answers.Add(player, playerAnswers);
            return true;
        }

        private void EndRound()
        {
            CheckAnswers();

            RoundOverEvent?.Invoke(this, new EventArgs());
        }

        private void CheckAnswers()
        {
            foreach (var answer in Answers)
            {
                var player = answer.Key;
                var playerAnswers = answer.Value;

                // Find correct answers from players
                var matchingAnswers = playerAnswers.Where(x => Question.CorrectAnswerIds.All(y => x == y)).ToList();

                // Assign score to players
                player.Score += matchingAnswers.Count * 100;
            }
        }
    }
}
