using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты должен спасти принцессу из плена всемирной сети. Что ты будешь делать?");
            Console.WriteLine("1. Играть в Overwatch");
            Console.WriteLine("2. Узнать, на каком сайте она застряла");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                return;
            }
            else if (answer == 2)
            {
                Console.WriteLine("Принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт  dontclickme.noob ");
            }
            Console.WriteLine("3. Послушаться совета в адресе сайта и пойти играть в Overwatch");
            Console.WriteLine("4. Перейти по ссылке");
            Console.WriteLine("5. Обновить антивирус и перейти по ссылке");

            int answer1 = int.Parse(Console.ReadLine());

            if (answer == 3)
            {
                return;
            }
            if (answer == 4)
            {
                return;
            }
            if (answer == 5)
            {
                Console.WriteLine("Вы встречаете Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет  2 + 2 * 2 ?");
            }
            Console.WriteLine("6. А, ну ее, математика для нубов! Пойду в Overwatch поиграю");
            Console.WriteLine("7. Проверить исходный код Капча-Монстра");
            Console.WriteLine("8. 6!");

            int answer2 = int.Parse(Console.ReadLine());

            if (answer == 6)
            {
                return;
            }
            if (answer == 7)
            {
                Console.WriteLine("Вы вскрываете код Капча-Монстра и видите, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");
            }
            if (answer == 8)
            {
                return;
            }
            Console.WriteLine("9. Круто, пойду попробую так в своей программе!");
            Console.WriteLine("10. 6!");
            Console.WriteLine("11. Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра");

            int answer3 = int.Parse(Console.ReadLine());

            if (answer == 9)
            {
                return;
            }
            if (answer == 10)
            {
                return;
            }
            if (answer == 11)
            {
                Console.WriteLine("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет  (2 + 2 ) * 2 ?");
            }
            Console.WriteLine("12. 8!");
            Console.WriteLine("13. Вам лень считать, и Вы идете играть в Overwatch");

            int answer4 = int.Parse(Console.ReadLine());

            if (answer == 12)
            {
                Console.WriteLine("Капча-Монстр обиженно сопит: Как ты догадался ? Я же спрятал скобки!, отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0.Файл - лекарство можно найти здесь: C:Antivirus.cure.exe");
            }
            if (answer == 13)
            {
                return;
            }
            Console.WriteLine("14. Отправить лекарство принцессе по почте и пойти в Overwatch");
            Console.WriteLine("15. Записать лекарство на флешку и пойти к принцессе домой");

            int answer5 = int.Parse(Console.ReadLine());

            if (answer == 14)
            {
                return;
            }
            if (answer == 15)
            {
                Console.WriteLine("Победа!");
            }
            Console.ReadLine();
        }
    }
}
