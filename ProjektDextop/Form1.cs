using ProjectLibrary;
using static System.Formats.Asn1.AsnWriter;
namespace ProjektDextop
{
    public partial class Form1 : Form
    {
        private GameLogic game;
        public Form1()
        {
            try
            {
                game = new GameLogic();
            }
            catch (FileNotFoundException e) { MessageBox.Show($"Plik z pytaniami nie istnieje!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            game.OnQuestionChanged += UpdateUIForQuestion;
            InitializeComponent();
            buttonSubmit.Enabled = false;
            textBoxAnswer.Enabled = false;
        }

        private void UpdateUIForQuestion(GameQuizQuestion question)
        {
            pictureBox1.ImageLocation = question.ImagePath;
            textBoxAnswer.Text = String.Empty;
            listBoxHints.DataSource = null;
        }

        

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            var addGameForm = new AddGameForm();
            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                var newImagePath = Path.Combine("Images", Path.GetFileName(addGameForm.ImagePath));
                File.Copy(addGameForm.ImagePath, newImagePath, true);

                var newQuestion = new GameQuizQuestion
                {
                    ImagePath = newImagePath,
                    GameTitle = addGameForm.GameTitle
                };

                game.QuizQuestions.Add(newQuestion);
                game.SaveQuestionsToFile("Pytania.txt");
                MessageBox.Show("Gra zosta≥a dodana i zapisana!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            var removeGameForm = new RemoveGameForm(game.QuizQuestions);
            if (removeGameForm.ShowDialog() == DialogResult.OK)
            {
                var gameToRemove = game.QuizQuestions.FirstOrDefault(q => q.GameTitle == removeGameForm.SelectedGameTitle);
                if (gameToRemove != null)
                {
                    game.QuizQuestions.Remove(gameToRemove);
                    game.SaveQuestionsToFile("Pytania.txt");
                    MessageBox.Show("Gra zosta≥a usuniÍta i zapisane zmiany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonAddQuestion.Enabled = false;
            buttonRemoveQuestion.Enabled = false;
            buttonStart.Enabled = false;
            buttonSubmit.Enabled = true;
            textBoxAnswer.Enabled = true;
            game.RandomiseOrder();
            game.LoadNextQuestion();
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            var input = textBoxAnswer.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                var hints = game.QuizQuestions
                    .Where(q => q.GameTitle.Contains(input, StringComparison.OrdinalIgnoreCase))
                    .Select(q => q.GameTitle)
                    .OrderBy(q => random.Next())
                    .ToList();
                listBoxHints.DataSource = hints;
            }
            else
            {
                listBoxHints.DataSource = null;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userAnswer = textBoxAnswer.Text.Trim();
                var currentQuestion = game.QuizQuestions[game.currentQuestionIndex-1];

                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    throw new QuizException("Odpowiedü nie moøe byÊ pusta!");
                }

                if (currentQuestion.ValidateAnswer(userAnswer))
                {
                    game.Score++;
                    MessageBox.Show("Poprawna odpowiedü!", "Brawo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Niepoprawna odpowiedü! Poprawna: {currentQuestion.CorrectAnswer}", "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (game.currentQuestionIndex < game.QuizCount)
                {
                    game.LoadNextQuestion();
                }
                else
                {
                    MessageBox.Show($"Quiz zakoÒczony! TwÛj wynik: {game.Score}/{game.QuizCount}", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAddQuestion.Enabled = true;
                    buttonRemoveQuestion.Enabled = true;
                    buttonStart.Enabled = true;
                    buttonSubmit.Enabled = false;
                    textBoxAnswer.Enabled = false;
                }
            }
            catch (QuizException ex) { MessageBox.Show(ex.Message, "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
