using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public delegate void QuestionChangedHandler(GameQuizQuestion question);
    public class GameLogic
    {
        public event QuestionChangedHandler OnQuestionChanged;

        public List<GameQuizQuestion> QuizQuestions;
        public int QuizCount;
        public int currentQuestionIndex;
        public int Score;

        public GameLogic()
        {
            LoadQuestions("Pytania.txt");
            QuizCount = 5;
            currentQuestionIndex = 0;
            Score = 0;
        }

        public void LoadQuestions(string filePath)
        {
            
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Plik z pytaniami nie istnieje!");
            }
            QuizQuestions = File.ReadAllLines(filePath)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Split('|'))
                .Where(parts => parts.Length == 2)
                .Select(parts => new GameQuizQuestion
                {
                    ImagePath = parts[0],
                    GameTitle = parts[1],
                }).ToList();
        }
        public void AddQuestion(GameQuizQuestion question)
        {
            QuizQuestions.Add(question);
            SaveQuestionsToFile("Pytania.txt");
        }
        public void RemoveQuestion(GameQuizQuestion question) 
        { 
            QuizQuestions.Remove(question);
            SaveQuestionsToFile("Pytania.txt");
        }
        public void RandomiseOrder()
        {
            Random random = new Random();
            QuizQuestions = QuizQuestions.OrderBy(q => random.Next()).ToList();
        }
        public void SaveQuestionsToFile(string filePath)
        {
            var lines = QuizQuestions.Select(q => $"{q.ImagePath}|{q.GameTitle}").ToList();
            File.WriteAllLines(filePath, lines);
        }
        public void LoadNextQuestion()
        {
            Console.WriteLine(currentQuestionIndex);
            var currentQuestion = QuizQuestions[currentQuestionIndex];
            OnQuestionChanged(currentQuestion);
            currentQuestionIndex++;
        }
    }
}
