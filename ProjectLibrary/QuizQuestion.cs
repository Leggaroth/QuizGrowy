using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public abstract class QuizQuestion
    {
        public string ImagePath { get; set; }
        public abstract string CorrectAnswer { get; }
        public abstract bool ValidateAnswer(string userAnswer);
    }
}
