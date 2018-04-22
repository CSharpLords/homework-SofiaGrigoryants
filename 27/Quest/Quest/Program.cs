using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Quest
{
    class Program
    {
        static int attack = 30;
        static int health = 60;

        static int enemyAttack = 20;
        static int enemyHealth = 65;

        static void Main(string[] args)
        {
            Field();
        }

        static void Field()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Привет! Ты находишься на Зелёных Полях. Что ты будешь делать?");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            ShowOption("1. Осмотрю поле");
            ShowOption("2. Пойду в лес");
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer1 == 1)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 3);
                if (num == 1)
                {
                    Console.WriteLine("Осмотришь поле? Хорошо! Ты нашёл " + "меч. Теперь ты в лесу!");
                    attack = attack + 25;
                    Forest();
                }
                else if (num == 2)
                {
                    Console.WriteLine("Осмотришь поле? Хорошо! Ты нашёл " + "броню. Теперь ты в лесу!");
                    health = health + 15;
                    Forest();
                }
                Console.ReadLine();
            }
            else if (answer1 == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Идём!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Forest();
            }
            else
            {
                ShowInvalidAlert();
            }
        }

        static void Forest()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Лес. Здесь живут разбойники. Кажется, на тебя напали! Что ты хочешь сделать?");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            ShowOption("1. Буду сражаться!");
            ShowOption("2. Побегу на Зелёные Поля");
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
                Console.WriteLine("Бежим!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Field();
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
