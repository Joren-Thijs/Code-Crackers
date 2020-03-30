using System;

namespace UCLL_Quizine
{
    public class Answer
    {
        public Answer() {}

        public Answer(char answerId, string answerText)
        {
            if (String.IsNullOrWhiteSpace(answerText))
            {
                throw new ArgumentNullException("The answer text cannot be null or empty.");
            }

            AnswerId = answerId;
            AnswerText = answerText;
        }

        public char AnswerId { get; set; } = 'Z';
        public string AnswerText { get; set; } = "";
    }
}