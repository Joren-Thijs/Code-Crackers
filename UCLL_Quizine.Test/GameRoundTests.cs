using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCLL_Quizine.Test
{
    public class GameRoundTests
    {
        [Test]
        public void CreateGameRoundTest()
        {
            var answer = new Answer();
            Assert.IsNotNull(answer);
        }

        [Test]
        public void CreateGameRoundFilledTest()
        {
            var question = new Question();
            var roundTime = 10;
            var answer = new GameRound(question, roundTime);
            Assert.IsNotNull(answer);
        }
    }
}
