 using System.Collections.Generic;
using System;
using System.Text;

namespace GeniyIdiotClassLibrary
{
    public class UsersResultStorage
    {
        public static string CalculateDiagnoses(int countQuestions, int countRightAnswers)
        {
            var percentRightAnswers = ((double)countRightAnswers / countQuestions) * 100;

            if (percentRightAnswers < 20)
            {
                return "Идиот";
            }
            if (percentRightAnswers < 40)
            {
                return "Кретин";
            }
            if (percentRightAnswers < 60)
            {
                return "Дурак";
            }
            if (percentRightAnswers < 80)
            {
                return "Нормальный";
            }
            if (percentRightAnswers < 100)
            {
                return "Талант";
            }
            return "Гений";
        }

        public static void Save(User user)
        {
            var value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnose}";
            FileProvider.Append("SaveUserResult.txt", value);
        }

        public static List<User> GetUserResult()
        {
            var value = FileProvider.GetValue("SaveUserResult.txt").Trim();
            var lines = value.Split('\n');
            var results = new List<User>();
            foreach (var line in lines)
            {
                var values = line.Split('#');
                var name = values[0];
                var countRightAnswers = Convert.ToInt32(values[1]);
                var diagnose = values[2];

                var user = new User(name);
                user.CountRightAnswers = countRightAnswers;
                user.Diagnose = diagnose;
                results.Add(user);
            }
            return results;
        }

        public static void ShowUserResult()
        {
            var result = GetUserResult();
            Console.WriteLine("{0, -20}{1, -28}{2, -10}", "Имя", "Кол-во правильных ответов", "Диагноз");
            foreach (var user in result)
            {
                Console.WriteLine("{0, -20}{1, -28}{2, -10}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }
    }
}