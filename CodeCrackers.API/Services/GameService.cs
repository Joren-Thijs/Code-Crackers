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
        public string CreateGame()
        {
            var game = new Game();
            game.GameId = IdGenerator.GenerateRandomString(4);
            _games.Add(game);
            return game.GameId;
        }

        public void AddPlayer(string gameId, string playerName)
        {
            var game = _games.FirstOrDefault(g => g.GameId == gameId);

            if (game == null)
            {
                throw new GameNotFoundException($"There is no game with code {gameId}");
            }

            if (game.Players.Any(p => p.Name.ToLower() == playerName.ToLower()))
            {
                throw new PlayerAlreadyExistsException($"Player with name {playerName} already exists");
            }

            game.Players.Add(new Player { Name = playerName });
        }

        public void RemovePlayer(string gameId, string playerName)
        {
            var game = _games.FirstOrDefault(g => g.GameId == gameId);

            if (game == null)
            {
                throw new GameNotFoundException($"There is no game with code {gameId}");
            }

            var player = game.Players.FirstOrDefault(p => p.Name.ToLower() == playerName.ToLower());

            game.Players.Remove(player);
        }
    }
}
