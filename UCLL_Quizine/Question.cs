using System.Collections.Generic;

namespace UCLL_Quizine
{
    public class Question
    {
        public Question() {}

        public Question(string questionText, List<Answer> answers, List<char> correctAnswerIds)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIds = correctAnswerIds;
        }

        public string QuestionText { get; set; } = "";
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public List<char> CorrectAnswerIds { get; set; } = new List<char>();
    }
}