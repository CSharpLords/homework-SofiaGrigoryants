﻿using System;
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

        static int enemyAttack = 10;
        static int enemyHealth = 65;

        static int giantHealth = 80;
        static int giantAttack = 40;

        static string[] story = { "Green fields have appeared long ago", "Green fields are guarded by the Guardian of the Field - by me" };

        static string[] story2 = { "Савдо - маънои ҳаёти ман", "Ман дар ин ҷо якчанд муддат кор мекардам", "Ман тоҷик ҳастам" };

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
                ShowLocations();
            }
            if (answer3 == 2)
            {
                Random rand = new Random();
                int stor = rand.Next(0, 2);

                if (stor == 0)
                {
                    ShowLocations();
                }
                if (stor == 1)
                {
                    ShowLocations();
                }
            }
        }

        static void Dealer()
        {
            int money = 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ты в лавке торговца. Что будешь делать?");
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowOption("1. Выберу локацию");
            ShowOption("2. Продам коня");
            ShowOption("3. Прослушаю историю торговца");
            int answer5 = int.Parse(Console.ReadLine());
            if (answer5 == 1)
            {
                ShowLocations();
            }

            if (answer5 == 2)
            {
                money = 100;
                Console.WriteLine("Конь продан. Ты в лавке торговца. Что будешь делать?");
                Console.ForegroundColor = ConsoleColor.Gray;
                ShowOption("1. Выберу локацию");
                ShowOption("2. Куплю меч");
                ShowOption("3. Прослушаю историю торговца");
                int answer6 = int.Parse(Console.ReadLine());
                if (answer6 == 1)
                {
                    ShowLocations();
                }
                if (answer6 == 2)
                {
                    if (money == 100)
                    {
                        Console.WriteLine("Ты купил меч!");
                        attack = attack + 25;
                    }
                }
                if (answer6 == 3)
                {
                    Random ra = new Random();
                    int st = ra.Next(0, 3);
                    if (st == 0)
                    {
                        Console.WriteLine(story2[0]);
                    }
                    if (st == 1)
                    {
                        Console.WriteLine(story2[1]);
                    }
                    if (st == 2)
                    {
                        Console.WriteLine(story2[2]);
                    }
                }
                ShowLocations();
            }

            if (answer5 == 3)
            {
                Random ra = new Random();
                int st = ra.Next(0, 3);
                if (st == 0)
                {
                    Console.WriteLine(story2[0]);
                }
                if (st == 1)
                {
                    Console.WriteLine(story2[1]);
                }
                if (st == 2)
                {
                    Console.WriteLine(story2[2]);
                }
            }
        }

        static void Village()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ты в деревне. Здесь бушует великан. Кажется, он напал на тебя! Что будешь делать?");
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowOption("1. Буду сражаться!");
            ShowOption("2. Пойду на другую локацию");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Console.WriteLine("Хорошо. Твоё здоровье: " + health + ", твоя сила: " + attack);
                health = health - giantAttack;
                Console.WriteLine("Тебя бьют. Твоё здоровье: " + health);
                giantHealth = giantHealth - attack;
                Console.WriteLine("Теперь бьёшь ты. Здоровье великана: " + giantHealth);
                if (health <= 0)
                {
                    Console.WriteLine("Ты умер! Конец игры!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (giantHealth <= 0)
                {
                    Console.WriteLine("Гигант мёртв! Ты выиграл!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
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
                    Console.WriteLine("Разбойники мертвы! Ты выиграл! Лови бонус!");
                    health = 110;
                    attack = 60;
                    ShowLocations();
                }
                else
                {
                    Forest();
                }
            }
            else if (answer1 == 2)
            {
                ShowLocations();
                
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

        static void ShowLocations()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Выбирай локацию");
            ShowOption("1. Лес");
            ShowOption("2. Зелёные поля");
            ShowOption("3. Деревня");
            ShowOption("4. Лавка торговца");
            int answer4 = int.Parse(Console.ReadLine());
            if (answer4 == 1)
            {
                Forest();
            }
            if (answer4 == 2)
            {
                GreenFields();
            }
            if (answer4 == 3)
            {
                Village();
            }
            if (answer4 == 4)
            {
                Dealer();
            }
        }
    }
}
