using NUnit.Framework;
using System;

namespace UCLL_Quizine.Test
{
    public class PlayerTests
    {
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