using NUnit.Framework;

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
    }
}