using CodeCrackers.API.Entities;
using CodeCrackers.API.Exceptions;
using CodeCrackers.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Services
{
    public class GameService
    {
        private readonly List<Game> _games = new();
        private readonly object _gamesLock = new();

        public string CreateGame(string playerName)
        {
            var game = new Game();
            game.GameId = IdGenerator.GenerateRandomString(4);
            game.Players.Add(new Player { Name = playerName });
            lock (_gamesLock)
            {
                _games.Add(game);
            }
            
            return game.GameId;
        }

        public void AddPlayer(string gameId, string playerName)
        {
            Game game;
            lock (_gamesLock)
            {
                game = _games.FirstOrDefault(g => g.GameId == gameId);
            }

            if (game == null)
            {
                throw new GameNotFoundException($"There is no game with code {gameId}");
            }

            if (game.Players.Any(p => p.Name.ToLower() == playerName.ToLower()))
            {
                throw new PlayerAlreadyExistsException($"Player with name {playerName} already exists");
            }

            lock (_gamesLock)
            {
                game.Players.Add(new Player { Name = playerName });
            }
        }

        public void RemovePlayer(string gameId, string playerName)
        {
            Game game;
            lock (_gamesLock)
            {
                game = _games.FirstOrDefault(g => g.GameId == gameId);
            }

            if (game == null)
            {
                throw new GameNotFoundException($"There is no game with code {gameId}");
            }

            var player = game.Players.FirstOrDefault(p => p.Name.ToLower() == playerName.ToLower());

            lock (_gamesLock)
            {
                game.Players.Remove(player);
            }
        }
    }
}
