using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
	class Program {
		static void Main(string[] args) {
			SayHello("Маша");
			SayHello("Женя");
			SayHello("Петя");

			Console.ReadLine();
		}

		static void SayHello(string name) {
            string[] Hello = {"Привет, ", "Здравствуй, ", "Добрый день, "};
            Random rnd = new Random();
            int value = rnd.Next(0, 3);
            Console.WriteLine(Hello[value] + name);
		}
	}
}
