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
        public void PlayerNameIsCorrectTwoTest()
        {
            var playerName = "Harold";
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
        public void AssertPlayerNameCannotBeEmptyTest()
        {
            Assert.Throws<ArgumentNullException>(PlayerNameCannotBeEmptyTest);
        }

        private void PlayerNameCannotBeEmptyTest()
        {
            var player = new Player("");
        }

        [Test]
        public void AssertPlayerNameCannotBeWhiteSpaceTest()
        {
            Assert.Throws<ArgumentNullException>(PlayerNameCannotBeWhiteSpaceTest);
        }

        private void PlayerNameCannotBeWhiteSpaceTest()
        {
            var player = new Player("   ");
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
        public void AssertAddPlayerWithWrongCodeTest()
        {
            Assert.Throws<ArgumentException>(AddPlayerWithWrongCodeTest);
        }

        private void AddPlayerWithWrongCodeTest()
        {
            var gameCode = "abcd";
            var incorrectGamecode = "wxyz";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result = game.AddPlayer(incorrectGamecode, "John");
        }

        [Test]
        public void AssertAddPlayerOverMaxNumberOneTest()
        {
            Assert.Throws<ApplicationException>(AddPlayerOverMaxNumberOneTest);
        }

        private void AddPlayerOverMaxNumberOneTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 1;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold");
        }

        [Test]
        public void AssertAddPlayerOverMaxNumberTwoTest()
        {
            Assert.Throws<ApplicationException>(AddPlayerOverMaxNumberTwoTest);
        }

        private void AddPlayerOverMaxNumberTwoTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 2;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold") &&
                game.AddPlayer(gameCode, "Sarah");
        }

        [Test]
        public void AssertAddPlayerOverMaxNumberThreeTest()
        {
            Assert.Throws<ApplicationException>(AddPlayerOverMaxNumberThreeTest);
        }

        private void AddPlayerOverMaxNumberThreeTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 3;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold") &&
                game.AddPlayer(gameCode, "Sarah") &&
                game.AddPlayer(gameCode, "Linda");
        }

        [Test]
        public void AssertAddPlayerOverMaxNumberFourTest()
        {
            Assert.Throws<ApplicationException>(AddPlayerOverMaxNumberFourTest);
        }

        private void AddPlayerOverMaxNumberFourTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "Harold") &&
                game.AddPlayer(gameCode, "Sarah") &&
                game.AddPlayer(gameCode, "Linda") &&
                game.AddPlayer(gameCode, "Julia");
        }

        [Test]
        public void AssertAddPlayerWithExistingNameTest()
        {
            Assert.Throws<ArgumentException>(AddPlayerWithExistingNameTest);
        }

        private void AddPlayerWithExistingNameTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            var result =
                game.AddPlayer(gameCode, "John") &&
                game.AddPlayer(gameCode, "John");
        }

        [Test]
        public void RemovePlayerTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            game.AddPlayer(gameCode, "John");
            var result = game.RemovePlayer("John");
            Assert.IsTrue(result);
        }

        [Test]
        public void RemovePlayersTwoTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            game.AddPlayer(gameCode, "John");
            game.AddPlayer(gameCode, "Harold");
            var result = game.RemovePlayer("John") &&
                game.RemovePlayer("Harold");
            Assert.IsTrue(result);
        }

        [Test]
        public void RemovePlayersThreeTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            game.AddPlayer(gameCode, "John");
            game.AddPlayer(gameCode, "Harold");
            game.AddPlayer(gameCode, "Sarah");
            var result = game.RemovePlayer("John") &&
                game.RemovePlayer("Harold") &&
                game.RemovePlayer("Sarah");
            Assert.IsTrue(result);
        }

        [Test]
        public void RemovePlayersFourTest()
        {
            var gameCode = "abcd";
            var maxNumberOfPlayers = 4;
            var game = new Game(gameCode, maxNumberOfPlayers);

            game.AddPlayer(gameCode, "John");
            game.AddPlayer(gameCode, "Harold");
            game.AddPlayer(gameCode, "Sarah");
            game.AddPlayer(gameCode, "Linda");
            var result = game.RemovePlayer("John") &&
                game.RemovePlayer("Harold") &&
                game.RemovePlayer("Sarah") &&
                game.RemovePlayer("Linda");
            Assert.IsTrue(result);
        }
    }
}