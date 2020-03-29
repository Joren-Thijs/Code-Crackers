﻿using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace UCLL_Quizine
{
    public class Game
    {
        public string GameCode { get; private set; }
        public int MaxNumberOfPlayers { get; private set; }
        public ObservableCollection<Player> Players { get; private set; }
        public ObservableCollection<Question> Questions { get; set; }
        public bool Started { get; private set; }

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
    }
}
