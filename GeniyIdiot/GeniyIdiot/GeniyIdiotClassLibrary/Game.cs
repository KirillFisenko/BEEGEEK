using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        int сountQuestions;
        int questionNumber;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            сountQuestions = questions.Count;
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questionNumber++;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }

            questions.Remove(currentQuestion);            
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос №" + (questionNumber);
        }

        public bool End()
        {
            return questions.Count == 0;
        }
        public string CalculateDiagnose()
        {
            var diagnose = UsersResultStorage.CalculateDiagnoses(сountQuestions, user.CountRightAnswers);
            user.Diagnose = diagnose;
            UsersResultStorage.Save(user);            
            return $"{user.Name} - {user.Diagnose}";
        }
    }
}