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

        public GameRound(Question question, int roundTime, List<Player> players)
        {
            Question = question ??
                throw new ArgumentNullException(nameof(question));
            RoundTime = roundTime;

            if (players == null)
            {
                throw new ArgumentNullException(nameof(players));
            }
            if (players.Count < 2)
            {
                throw new ArgumentException("The minimum amount of players to play is two.");
            }
            Players = players;

        }

        public Question Question { get; set; }
        public List<Player> Players { get; private set; } = new List<Player>();
        public Dictionary<Player, List<char>> Answers { get; private set; } = new Dictionary<Player, List<char>>();
        public int RoundTime { get; private set; } = 0;
        public int ElapsedRoundTime { get; private set; } = 0;
        public Timer Timer { get; private set; } = new Timer();
        public event EventHandler RoundStartedEvent;
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

            RoundStartedEvent?.Invoke(this, new EventArgs());
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
            // Check if the player is part of this game
            if (!Players.Contains(player))
            {
                throw new ArgumentException("The player is not part of this game.");
            }

            // Check if round has started yet
            if (!Timer.Enabled)
            {
                return false;
            }

            // Check if player has already answered
            if (Answers.ContainsKey(player))
            {
                return false;
            }

            Answers.Add(player, playerAnswers);

            // Check if all players have answered
            if (Answers.Count == Players.Count)
            {
                EndRound();
            }

            return true;
        }

        private void EndRound()
        {
            // Disable Timer
            Timer.Enabled = false;
            Timer.Elapsed -= TimerElapsed;

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
