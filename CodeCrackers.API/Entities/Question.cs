using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Entities
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int CorrectAnswerId { get; set; }
        public List<Answer> Answers { get; set; } = new();
    }
}
