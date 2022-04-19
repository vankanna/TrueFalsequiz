using System;
using System.Collections.Generic;
using System.Text;

namespace TrueFalsequiz
{
    public class Question
    {
        public string question { get; set; }
        public bool answer { get; set; }
        public Question(string question, bool answer)
        {
            this.question = question;
            this.answer = answer;
        }

    }
}
