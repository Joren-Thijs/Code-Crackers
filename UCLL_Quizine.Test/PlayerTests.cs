using NUnit.Framework;
using System;

namespace UCLL_Quizine.Test
{
    public class PlayerTests
    {
        [Test]
        public void CreatePlayerTest()
        {
            var player = new Player("John");
            Assert.IsNotNull(player);
        }

        [Test]
        public void PlayerScoreIsZeroTest()
        {
            var player = new Player("John");
            Assert.AreEqual(player.Score, 0);
        }

        [Test]
        public void PlayerNameIsCorrectTest()
        {
            var playerName = "John";
            var player = new Player(playerName);
            Assert.AreEqual(player.Name, playerName);
        }

        [Test]
        public void AssertPlayerNameCannotBeNullTest()
        {
            Assert.Throws<ArgumentNullException>(PlayerNameCannotBeNullTest);
        }

        private void PlayerNameCannotBeNullTest()
        {
            var player = new Player(null);
        }

        [Test]
        public void AddPlayerTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result = game.AddPlayer(gameCode, "John");
            Assert.IsTrue(result);
        }

        [Test]
        public void AddTwoPlayersTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result = 
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold");
            Assert.IsTrue(result);
        }

        [Test]
        public void AddThreePlayersTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold") &&
                game.AddPlayer(gameCode, "Sarah");
            Assert.IsTrue(result);
        }

        [Test]
        public void AddFourPlayersTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold") &&
                game.AddPlayer(gameCode, "Sarah") &&
                game.AddPlayer(gameCode, "Linda");
            Assert.IsTrue(result);
        }

        [Test]
        public void AssertAddPlayerWithWrongCode()
        {
            Assert.Throws<ArgumentException>(AddPlayerWithWrongCode);
        }

        private void AddPlayerWithWrongCode()
        {
            var gameCode = "abcd";
            var incorrectGamecode = "wxyz";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result = game.AddPlayer(incorrectGamecode, "John");
        }
    }
}