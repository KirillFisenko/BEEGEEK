using GeniyIdiotClassLibrary;
using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите свое имя: ");                
                var user = new User(Console.ReadLine());
                var game = new Game(user);

                while(!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();
                    Console.WriteLine(game.GetQuestionNumberText());                    
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = GetNumber();

                    game.AcceptAnswer(userAnswer);

                }
                var message = game.CalculateDiagnose();                
                Console.WriteLine(message);                

                var userchoice = GetUserChoice("Хотите пройти просмотреть все результаты? Ответьте 'да' или 'нет': ");
                if (userchoice)
                {
                    UsersResultStorage.ShowUserResult();
                }

                userchoice = GetUserChoice("Хотите добавить новый вопрос? Ответьте 'да' или 'нет': ");
                if (userchoice)
                {
                    AddNewQuestion();
                }

                userchoice = GetUserChoice("Хотите удалить вопрос? Ответьте 'да' или 'нет': ");
                if (userchoice)
                {
                    RemoveQuestion();
                }

                userchoice = GetUserChoice("Хотите пройти тест снова? Ответьте 'да' или 'нет': ");
                if (!userchoice)
                {
                    break;
                }
            }
        }
        static void AddNewQuestion()
        {
            Console.Write("Введите новый вопрос: ");
            var text = Console.ReadLine();
            Console.Write("Введите ответ на вопрос: ");
            var answer = GetNumber();
            var newQuestion = new Question(text, answer);
            QuestionsStorage.Add(newQuestion);
        }

        static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер удалямеого вопроса: ");
            var questions = QuestionsStorage.GetAll();
            for (var i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + questions[i].Text);
            }
            var removeQuestionNumber = GetNumber();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = GetNumber();
            }
            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionsStorage.Remove(removeQuestion);
        }

        static int GetNumber()
        {
            int number;
            while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            return number;
        }

        static bool GetUserChoice(string qustion)
        {
            Console.Write(qustion);
            while (true)
            {
                var userChoice = Console.ReadLine();
                if (userChoice.ToLower() == "да")
                {
                    return true;
                }
                if (userChoice.ToLower() == "нет")
                {
                    return false;
                }
                else
                {
                    Console.Write("Пожалуйста, введите только 'да' или 'нет': ");
                }
            }
        }
    }
}