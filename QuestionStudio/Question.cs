using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionStudio
{
    public class Question
    {
        public string Questions { get; set; }
        public string Answer { get; set; }

        public List<string>Options = new List<string>();

        public Question(string questions, string answer)
        {
            Questions = questions;
            Answer = answer;
        }
    }
}
