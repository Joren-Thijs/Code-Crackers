using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace UCLL_Quizine
{
    public class Game
    {
        public Game(string gameCode, int maxNumberOfPlayers)
        {
            this.GameCode = gameCode;
            this.MaxNumberOfPlayers = maxNumberOfPlayers;
        }

        public string GameCode { get; private set; }
        public int MaxNumberOfPlayers { get; private set; }
        public ObservableCollection<Player> Players { get; private set; } = new ObservableCollection<Player>();
        public Queue<Question> Questions { get; set; } = new Queue<Question>();
        public bool Started { get; private set; }

        public void Start()
        {
            Started = true;
        }

        public bool AddPlayer(string gameCode, string playerName)
        {
            // Check if gamecode matches
            if (gameCode != GameCode)
            {
                throw new ArgumentException("The GameCode does not match.");
            }

            // Check if game has not started yet
            if (Started)
            {
                throw new ApplicationException("The Game has already started.");
            }

            // Check if max number of players is already reached
            if (Players.Count >= MaxNumberOfPlayers)
            {
                throw new ApplicationException("The max number of players has already been reached.");
            }

            // Check if playerName is not taken already
            var existingPlayerWithName = Players.FirstOrDefault(x => x.Name == playerName);
            if (existingPlayerWithName != null)
            {
                throw new ArgumentException("A player with this name already exists.");
            }

            // Add player
            Players.Add(new Player(playerName));

            return true;
        }

        public bool RemovePlayer(string playerName)
        {
            // Check if game has not started yet
            if (Started)
            {
                throw new ApplicationException("The Game has already started.");
            }

            // Check if playerName exists
            var existingPlayerWithName = Players.FirstOrDefault(x => x.Name == playerName);
            if (existingPlayerWithName != null)
            {
                Players.Remove(existingPlayerWithName);
            }

            return true;
        }

        public Question GetNextQuestion()
        {
            return Questions.Dequeue();
        }
    }
}
