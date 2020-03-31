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
            var gameRound = new GameRound();
            Assert.IsNotNull(gameRound);
        }

        [Test]
        public void GameRoundAnswersIsNotNullTest()
        {
            var gameRound = new GameRound();
            Assert.IsNotNull(gameRound.Answers);
        }

        [Test]
        public void GameRoundTimerIsNotNullTest()
        {
            var gameRound = new GameRound();
            Assert.IsNotNull(gameRound.Timer);
        }

        [Test]
        public void GameRoundRoundTimeIsZero()
        {
            var gameRound = new GameRound();
            Assert.AreEqual(0, gameRound.RoundTime);
        }

        [Test]
        public void GameRoundElapsedRoundTimeIsZero()
        {
            var gameRound = new GameRound();
            Assert.AreEqual(0, gameRound.ElapsedRoundTime);
        }

        [Test]
        public void CreateGameRoundFilledTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.IsNotNull(gameRound);
        }

        [Test]
        public void GameRoundFilledQuestionIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.IsNotNull(gameRound.Question);
        }

        [Test]
        public void GameRoundFilledAnswersIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.IsNotNull(gameRound.Answers);
        }

        [Test]
        public void GameRoundFilledTimerIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.IsNotNull(gameRound.Timer);
        }

        [Test]
        public void GameRoundFilledElapsedRoundTimeIsZero()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(0, gameRound.ElapsedRoundTime);
        }

        [Test]
        public void GameRoundFilledQuestionIsCorrect()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(question, gameRound.Question);
        }

        [Test]
        public void GameRoundFilledRoundTimeIsCorrect()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(roundTime, gameRound.RoundTime);
        }
    }
}
