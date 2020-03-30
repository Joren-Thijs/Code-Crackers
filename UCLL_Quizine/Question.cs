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
            // Varify question has a correct answer.
            var matchingAnswers = CorrectAnswerIds.Where(x => answers.Any(y => y.AnswerId == x)).ToList();
            if (matchingAnswers == null)
            {
                throw new ArgumentException("The given question has no correct answer.");
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