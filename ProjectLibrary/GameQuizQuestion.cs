using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class GameQuizQuestion : QuizQuestion
    {
        public string GameTitle { get; set; }

        public override string CorrectAnswer => GameTitle;

        public override bool ValidateAnswer(string userAnswer)
        {
            return string.Equals(userAnswer, GameTitle, StringComparison.OrdinalIgnoreCase);
        }
    }
}
