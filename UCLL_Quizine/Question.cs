using System.Collections.Generic;

namespace UCLL_Quizine
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
        public List<char> CorrectAnswerIds { get; set; }
    }
}