using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Quest_2
{
    class Program
    {

        static int attack = 30;
        static int health = 60;

        static int enemyAttack = 20;
        static int enemyHealth = 65;

        static string[] story = { "Green fields have appeared long ago", "Green fields are guarded by the Guardian of the Field - by me" };
        static void Main(string[] args)
        {
            GreenFields();
        }

        static void GreenFields()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ты на Зелёных Полях. Что будешь делать?");
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowOption("1. Выберу локацию");
            ShowOption("2. Послушаю историю Хранителя Поля");
            int answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Выбирай");
                ShowOption("1. Лес");
                ShowOption("2. Лавка торговца");
                ShowOption("3. Деревня");
                int answer4 = int.Parse(Console.ReadLine());
                if (answer4 == 1)
                {
                    Forest();
                }
                if (answer4 == 2)
                {
                    Dealer();
                }
                if (answer4 == 3)
                {
                    Village();
                }
            }
            if (answer3 == 2)
            {
                Random rand = new Random();
                int stor = rand.Next(
            }
        }

        static void Forest()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Лес. Здесь живут разбойники. Кажется, на тебя напали! Что ты хочешь сделать?");
            Console.ForegroundColor = ConsoleColor.Gray;

            ShowOption("1. Буду сражаться!");
            ShowOption("2. Пойду на другую локацию");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Console.WriteLine("Хорошо. Твоё здоровье: " + health + ", твоя сила: " + attack);
                health = health - enemyAttack;
                Console.WriteLine("Тебя бьют. Твоё здоровье: " + health);
                enemyHealth = enemyHealth - attack;
                Console.WriteLine("Теперь бьёшь ты. Здоровье разбойников: " + enemyHealth);
                if (health <= 0)
                {
                    Console.WriteLine("Ты умер! Конец игры!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Разбойники мертвы! Ты выиграл!");
                    health = 90;
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Forest();
                }
            }
            else if (answer1 == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Выбирай");
                ShowOption("1. Зелёные поля");
                ShowOption("2. Лавка торговца");
                ShowOption("3. Деревня");
                int answer2 = int.Parse(Console.ReadLine());
                if (answer2 == 1)
                {
                    GreenFields();
                }
                if (answer2 == 2)
                {
                    Dealer();
                }
                if (answer2 == 3)
                {
                    Village();
                }
                
            }
            else
            {
                ShowInvalidAlert();
            }
        }

        static void ShowInvalidAlert()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введен невалидный вариант! Конец игры");
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void ShowOption(string option)
        {
            Thread.Sleep(500);
            Console.WriteLine(option);
        }

        static void ShowComment(string comment)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(comment);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
