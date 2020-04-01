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
        public void GameRoundPlayersIsNotNullTest()
        {
            var gameRound = new GameRound();
            Assert.IsNotNull(gameRound.Players);
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
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.IsNotNull(gameRound);
        }

        [Test]
        public void AssertCreateGameRoundFilledQuestionCannotBeNullTest()
        {
            Assert.Throws<ArgumentNullException>(CreateGameRoundFilledQuestionCannotBeNullTest);
        }

        public void CreateGameRoundFilledQuestionCannotBeNullTest()
        {
            Question question = null;
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
        }

        [Test]
        public void AssertCreateGameRoundFilledPlayersCannotBeNullTest()
        {
            Assert.Throws<ArgumentNullException>(CreateGameRoundFilledQuestionPlayersCannotBeNullTest);
        }

        public void CreateGameRoundFilledQuestionPlayersCannotBeNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            List<Player> players = null;
            var gameRound = new GameRound(question, roundTime, players);
        }

        [Test]
        public void AssertCreateGameRoundFilledPlayersCannotBeLessThenTwoTest()
        {
            Assert.Throws<ArgumentException>(CreateGameRoundFilledQuestionPlayersCannotBeLessThenTwoTest);
        }

        public void CreateGameRoundFilledQuestionPlayersCannotBeLessThenTwoTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John") };
            var gameRound = new GameRound(question, roundTime, players);
        }

        [Test]
        public void GameRoundFilledQuestionIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.IsNotNull(gameRound.Question);
        }

        [Test]
        public void GameRoundFilledAnswersIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.IsNotNull(gameRound.Answers);
        }

        [Test]
        public void GameRoundFilledTimerIsNotNullTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.IsNotNull(gameRound.Timer);
        }

        [Test]
        public void GameRoundFilledElapsedRoundTimeIsZeroTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.AreEqual(0, gameRound.ElapsedRoundTime);
        }

        [Test]
        public void GameRoundFilledQuestionIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.AreEqual(question, gameRound.Question);
        }

        [Test]
        public void GameRoundFilledRoundTimeIsCorrectTest()
        {
            var question = new Question();
            var roundTime = 10;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            Assert.AreEqual(roundTime, gameRound.RoundTime);
        }

        [Test]
        public void GameRoundFilledRoundOverEventIsFiredTest()
        {
            var timeoutMilliseconds = 1500;
            var question = new Question();
            var roundTime = 1;
            var players = new List<Player>() { new Player("John"), new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
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
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            var result = gameRound.AnswerQuestion(player, new List<char> { 'A' });
            Assert.IsFalse(result);
        }

        [Test]
        public void GameRoundFilledQuestionCanBeAnsweredAfterRoundStartsTest()
        {
            var question = new Question();
            var roundTime = 10;
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
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
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
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
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
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
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
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
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            var answers = new List<char> { 'A', 'B', 'C', 'D' };
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, answers);

            var gameRoundAnswers = gameRound.Answers.GetValueOrDefault(player);
            var result = gameRoundAnswers.All(answers.Contains) && gameRoundAnswers.Count == answers.Count;
            Assert.IsTrue(result);
        }

        [Test]
        public void GameRoundFilledQuestionCannotBeAnsweredTwiceTest()
        {
            var question = new Question();
            var roundTime = 10;
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, new List<char> { 'A' });
            var result = gameRound.AnswerQuestion(player, new List<char> { 'A' });
            Assert.IsFalse(result);
        }

        [Test]
        public void GameRoundFilledQuestionCannotBeAnsweredTriceTest()
        {
            var question = new Question();
            var roundTime = 10;
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, new List<char> { 'A' });
            var result = gameRound.AnswerQuestion(player, new List<char> { 'A' }) && gameRound.AnswerQuestion(player, new List<char> { 'B' });
            Assert.IsFalse(result);
        }

        [Test]
        public void GameRoundFilledQuestionCannotBeAnsweredFoursTest()
        {
            var question = new Question();
            var roundTime = 10;
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            gameRound.StartRound();

            gameRound.AnswerQuestion(player, new List<char> { 'A' });
            var result = gameRound.AnswerQuestion(player, new List<char> { 'B' }) &&
                gameRound.AnswerQuestion(player, new List<char> { 'C' }) &&
                gameRound.AnswerQuestion(player, new List<char> { 'D' });
            Assert.IsFalse(result);
        }

        [Test]
        public void AssertGameRoundFilledQuestionCannotBeAnsweredByUnknownPlayerTest()
        {
            Assert.Throws<ArgumentException>(GameRoundFilledQuestionCannotBeAnsweredByUnknownPlayerTest);
        }

        public void GameRoundFilledQuestionCannotBeAnsweredByUnknownPlayerTest()
        {
            var question = new Question();
            var roundTime = 10;
            var player = new Player("John");
            var players = new List<Player>() { player, new Player("Harold") };
            var gameRound = new GameRound(question, roundTime, players);
            gameRound.StartRound();

            gameRound.AnswerQuestion(new Player("Julia"), new List<char> { 'A' });
        }
    }
}
