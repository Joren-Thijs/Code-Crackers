using System;
using System.Collections.Generic;
using System.Linq;

namespace UCLL_Quizine
{
    public class Question
    {
        public Question() {}

        public Question(string questionText, List<Answer> answers, List<char> correctAnswerIds)
        {
            if (String.IsNullOrWhiteSpace(questionText))
            {
                throw new ArgumentNullException("Question text cannot be empty.");
            }

            if (answers == null)
            {
                throw new ArgumentNullException(nameof(answers));
            }

            if (correctAnswerIds == null)
            {
                throw new ArgumentNullException(nameof(correctAnswerIds));
            }

            // Varify question has a correct answer.
            var matchingAnswers = correctAnswerIds.Where(x => answers.Any(y => y.AnswerId == x)).ToList();
            if (matchingAnswers.Count == 0)
            {
                throw new ArgumentException("The given question has no correct answer.");
            }

            // Varify question has at least two possible answers
            if (answers.Count < 2)
            {
                throw new ArgumentException("The given question must have at least two possible answers.");
            }

            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIds = correctAnswerIds;
        }

        public string QuestionText { get; set; } = "";
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public List<char> CorrectAnswerIds { get; set; } = new List<char>();
    }
}