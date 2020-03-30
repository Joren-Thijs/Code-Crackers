using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCLL_Quizine.Test
{
    public class AnswerTests
    {
        [Test]
        public void CreateAnswerTest()
        {
            var answer = new Answer();
            Assert.IsNotNull(answer);
        }

        [Test]
        public void AnswerIdIsNotNullTest()
        {
            var answer = new Answer();
            Assert.IsNotNull(answer.AnswerId);
        }

        [Test]
        public void AnswerTextIsNotNullTest()
        {
            var answer = new Answer();
            Assert.IsNotNull(answer.AnswerText);
        }

        [Test]
        public void CreateAnswerFilledTest()
        {
            var answer = new Answer('A', "Answer");
            Assert.IsNotNull(answer);
        }

        [Test]
        public void AnswerFilledIdIsNotNullTest()
        {
            var answer = new Answer('A', "Answer");
            Assert.IsNotNull(answer.AnswerId);
        }

        [Test]
        public void AnswerFilledTextIsNotNullTest()
        {
            var answer = new Answer('A', "Answer");
            Assert.IsNotNull(answer.AnswerText);
        }

        [Test]
        public void AnswerFilledIdIsCorrect()
        {
            char answerId = 'A';
            string answerText = "Answer";
            var answer = new Answer(answerId, answerText);
            Assert.AreEqual(answerId, answer.AnswerId);
        }

        [Test]
        public void AnswerFilledTextIsCorrect()
        {
            char answerId = 'A';
            string answerText = "Answer";
            var answer = new Answer(answerId, answerText);
            Assert.AreEqual(answerText, answer.AnswerText);
        }
    }
}
