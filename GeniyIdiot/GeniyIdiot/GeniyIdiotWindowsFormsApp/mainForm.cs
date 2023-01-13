using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        Game game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var welcomForm = new WelcomeForm();
            welcomForm.ShowDialog();
            var user = new User(welcomForm.userNameBox.Text);
            game = new Game(user);
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = game.GetQuestionNumberText();            
        }        

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);

            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);
                
                if (game.End())
                {
                    var message = game.CalculateDiagnose();
                    MessageBox.Show(message);
                }
                else
                {
                    ShowNextQuestion();
                }                
            }            
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            GameResult gameResult = new GameResult();
            gameResult.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void показатьПредыдущиеРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameResult = new GameResult();
            gameResult.ShowDialog();
        }
    }
}