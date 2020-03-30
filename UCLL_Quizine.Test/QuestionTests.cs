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

        [Test]
        public void CreateQuestionFilledTest()
        {
            var questionText = "Question";
            var answers = new List<Answer>()
            {
                new Answer('A', "Answer 1"),
                new Answer('B', "Answer 2"),
                new Answer('C', "Answer 3"),
                new Answer('D', "Answer 4")
            };
            var correctAnswerIds = new List<char>()
            {
                'A'
            };
            var question = new Question(questionText, answers, correctAnswerIds);
            Assert.IsNotNull(question);
        }

        [Test]
        public void QuestionFilledTextIsNotNullTest()
        {
            var questionText = "Question";
            var answers = new List<Answer>()
            {
                new Answer('A', "Answer 1"),
                new Answer('B', "Answer 2"),
                new Answer('C', "Answer 3"),
                new Answer('D', "Answer 4")
            };
            var correctAnswerIds = new List<char>()
            {
                'A'
            };
            var question = new Question(questionText, answers, correctAnswerIds);
            Assert.IsNotNull(question.QuestionText);
        }

        [Test]
        public void QuestionFilledAnswersIsNotNullTest()
        {
            var questionText = "Question";
            var answers = new List<Answer>()
            {
                new Answer('A', "Answer 1"),
                new Answer('B', "Answer 2"),
                new Answer('C', "Answer 3"),
                new Answer('D', "Answer 4")
            };
            var correctAnswerIds = new List<char>()
            {
                'A'
            };
            var question = new Question(questionText, answers, correctAnswerIds);
            Assert.IsNotNull(question.Answers);
        }

        [Test]
        public void QuestionFilledCorrectAnswerIdsIsNotNullTest()
        {
            var questionText = "Question";
            var answers = new List<Answer>()
            {
                new Answer('A', "Answer 1"),
                new Answer('B', "Answer 2"),
                new Answer('C', "Answer 3"),
                new Answer('D', "Answer 4")
            };
            var correctAnswerIds = new List<char>()
            {
                'A'
            };
            var question = new Question(questionText, answers, correctAnswerIds);
            Assert.IsNotNull(question.CorrectAnswerIds);
        }

        [Test]

        public void AssertQuestionMustHaveCorrectAnswerTest()
        {
            Assert.Throws<ArgumentException>(QuestionMustHaveCorrectAnswerTest);
        }

        private void QuestionMustHaveCorrectAnswerTest()
        {
            var questionText = "Question";
            var answers = new List<Answer>()
            {
                new Answer('A', "Answer 1"),
                new Answer('B', "Answer 2"),
                new Answer('C', "Answer 3"),
                new Answer('D', "Answer 4")
            };
            var correctAnswerIds = new List<char>()
            {
                'Z'
            };
            var question = new Question(questionText, answers, correctAnswerIds);
        }
    }
}
