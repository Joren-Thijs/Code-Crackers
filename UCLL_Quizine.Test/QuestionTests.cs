using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCLL_Quizine.Test
{
    public class QuestionTests
    {
        [Test]
        public void CreateQuestionTest()
        {
            var question = new Question();
            Assert.IsNotNull(question);
        }

        [Test]
        public void QuestionTextIsNotNullTest()
        {
            var question = new Question();
            Assert.IsNotNull(question.QuestionText);
        }

        [Test]
        public void QuestionAnswersIsNotNullTest()
        {
            var question = new Question();
            Assert.IsNotNull(question.Answers);
        }

        [Test]
        public void QuestionCorrectAnswerIdsIsNotNullTest()
        {
            var question = new Question();
            Assert.IsNotNull(question.CorrectAnswerIds);

        }
    }
}
