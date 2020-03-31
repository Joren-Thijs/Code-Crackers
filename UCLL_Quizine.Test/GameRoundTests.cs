using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
        public void GameRoundRoundTimeIsZeroTest()
        {
            var gameRound = new GameRound();
            Assert.AreEqual(0, gameRound.RoundTime);
        }

        [Test]
        public void GameRoundElapsedRoundTimeIsZeroTest()
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
        public void GameRoundFilledElapsedRoundTimeIsZeroTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(0, gameRound.ElapsedRoundTime);
        }

        [Test]
        public void GameRoundFilledQuestionIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(question, gameRound.Question);
        }

        [Test]
        public void GameRoundFilledRoundTimeIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            Assert.AreEqual(roundTime, gameRound.RoundTime);
        }

        [Test]
        public void GameRoundFilledRoundOverEventIsFiredTest()
        {
            var timeoutMilliseconds = 1500;
            var question = new Question();
            var roundTime = 1;
            var gameRound = new GameRound(question, roundTime);
            ManualResetEvent eventRaised = new ManualResetEvent(false);
            gameRound.RoundOverEvent +=
                (s, e) => 
                {
                    eventRaised.Set();
                };
            gameRound.StartRound();
            Assert.IsTrue(eventRaised.WaitOne(timeoutMilliseconds));
        }

        [Test]
        public void GameRoundFilledQuestionCannotBeAnsweredBeforeRoundStartsTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var result = gameRound.AnswerQuestion(player, new List<char> { 'A' });
            Assert.IsFalse(result);
        }
    }
}
