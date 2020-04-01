using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCLL_Quizine.Test
{
    public class GameTests
    {
        [Test]
        public void CreateGameTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsNotNull(game);
        }

        [Test]
        public void GameCodeIsNotNullTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsNotNull(game.GameCode);
        }

        [Test]
        public void GameMaxNumberOfPlayersIsNotNullTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsNotNull(game.MaxNumberOfPlayers);
        }

        [Test]
        public void GamePlayersIsNotNullTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsNotNull(game.Players);
        }

        [Test]
        public void GameQuestionsIsNotNullTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsNotNull(game.Questions);
        }

        [Test]
        public void GameStartedsIsFalseTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.IsFalse(game.Started);
        }

        [Test]
        public void GameCodeIsCorrectTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.AreEqual(gameCode, game.GameCode);
        }

        [Test]
        public void GameCodeIsCorrectTwoTest()
        {
            var gameCode = "wxyz";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.AreEqual(gameCode, game.GameCode);
        }

        [Test]
        public void GameMaxNumberOfPlayersIsCorrectTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 2;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.AreEqual(maxNumberOfPlayers, game.MaxNumberOfPlayers);
        }

        [Test]
        public void GameMaxNumberOfPlayersIsCorrectTwoTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);
            Assert.AreEqual(maxNumberOfPlayers, game.MaxNumberOfPlayers);
        }
    }
}
