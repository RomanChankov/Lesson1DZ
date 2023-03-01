using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Training
{
    internal class Program
    {
        static void startQuix()
        {
            string[] questions =
            { "Самая высокая гора? ",
              "Самая длинная река? ",
              "Самая большая страна? "
            };
            string[] answer =
            {
                "эверест","амазонка","россия"
            };
            int countOfRightAnswer = 0;
            string userAnswer;
           
            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answer[i])
                {
                    countOfRightAnswer++;
                    WriteLine("Ответ верный.");
                }
                else
                {
                    WriteLine("Ответ неверный");
                }
            }
            WriteLine("Правильных ответов " + countOfRightAnswer);
            if(countOfRightAnswer <= 1)
            {
                WriteLine(" Ваши баллы - ''");
            }
            
            else if (countOfRightAnswer == 2)
            {
                WriteLine(" Ваша оценка - '2'");
            }

            else
            {
                WriteLine(" Ваша оценка - '3'");
            }

        }

        static void guessNumber()
        {
            WriteLine("***** Угадай число от 0 до 100! *****");
            WriteLine("***** У вас 5 попыток! *****");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            do
            {
                WriteLine("Введите число");
                userNumber = Int32.Parse(ReadLine());
                count++;
                int ostatok = 5 - count;
                if (userNumber > 0 && userNumber > 100)
                {
                    WriteLine("Вы ввели число вне заданного диапазона ");
                    return;
                }
                if (userNumber < magicNumber)
                {
                   
                    if (count== 5)
                    {
                        Console.WriteLine("Попытки закончились");
                        return ;
                    }
                    WriteLine("Ваше число меньше загаданного ");
                    WriteLine($"Осталось {ostatok} попыток");
                }
                else if (userNumber > magicNumber)
                {
                   
                    if (count ==5)
                    {
                        Console.WriteLine("Попытки закончились");
                        return;
                    }
                    WriteLine("Ваше число больше загаданного");
                    WriteLine($"Осталось {ostatok} попыток");
                }
                else if (userNumber == magicNumber)
                {
                    Console.WriteLine("Ты угадал число " + magicNumber);
                    // WriteLine("Вы сделали " + count + " попыток.");
                    WriteLine($"Вы сделали {count} попыток");
                    break;
                }
            }
            while (userNumber != magicNumber);

        }
        static void showMenu()
        {

                int choice;
            do
            {
                WriteLine("Привет! Сыграем? Нажмите 1 - Викторина, нажмите 2 - Угадай число, хотите выйти -нажмите любое другое число. ");
                choice = Int32.Parse(ReadLine());

                switch (choice)
                {
                    case 1:
                        startQuix();
                        break;

                    case 2:
                        guessNumber();
                        break;

                    default:
                        WriteLine("До встречи!");
                        Environment.Exit(0);
                        break;
                } 
            }
            while (choice == 1 || choice == 2);
        }
        static void Main(string[] args)
        {
            showMenu();

        }
    }
}