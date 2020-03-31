using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Test]
        public void GameRoundFilledQuestionCanBeAnsweredAfterRoundStartsTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var answers = new List<char> { 'A' };
            gameRound.StartRound();

            var result = gameRound.AnswerQuestion(player, answers);
            Assert.IsTrue(result);
        }

        [Test]
        public void GameRoundFilledAnswerIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var answers = new List<char> { 'A' };
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, answers);

            var gameRoundAnswers = gameRound.Answers.GetValueOrDefault(player);
            var result = gameRoundAnswers.All(answers.Contains) && gameRoundAnswers.Count == answers.Count;
            Assert.IsTrue(result);
        }

        [Test]
        public void GameRoundFilledAnswerTwoIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var answers = new List<char> { 'A', 'B' };
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, answers);

            var gameRoundAnswers = gameRound.Answers.GetValueOrDefault(player);
            var result = gameRoundAnswers.All(answers.Contains) && gameRoundAnswers.Count == answers.Count;
            Assert.IsTrue(result);
        }

        [Test]
        public void GameRoundFilledAnswerThreeIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var answers = new List<char> { 'A', 'B', 'C' };
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, answers);

            var gameRoundAnswers = gameRound.Answers.GetValueOrDefault(player);
            var result = gameRoundAnswers.All(answers.Contains) && gameRoundAnswers.Count == answers.Count;
            Assert.IsTrue(result);
        }

        [Test]
        public void GameRoundFilledAnswerFourIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var gameRound = new GameRound(question, roundTime);
            var player = new Player("John");
            var answers = new List<char> { 'A', 'B', 'C', 'D' };
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, answers);

            var gameRoundAnswers = gameRound.Answers.GetValueOrDefault(player);
            var result = gameRoundAnswers.All(answers.Contains) && gameRoundAnswers.Count == answers.Count;
            Assert.IsTrue(result);
        }
    }
}
