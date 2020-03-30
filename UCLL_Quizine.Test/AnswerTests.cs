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
    }
}
