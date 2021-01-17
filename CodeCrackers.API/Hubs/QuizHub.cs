using CodeCrackers.API.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Hubs
{
    public class QuizHub : Hub
    {
        private readonly GameService _gameService;

        public QuizHub(GameService gameService)
        {
            _gameService = gameService;
        }

        /// <summary>
        /// Create a new Quiz game
        /// </summary>
        public string NewGame(string playerName)
        {
            return _gameService.CreateGame(playerName);
        }
    }
}
