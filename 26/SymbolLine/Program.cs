using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolLine {
	class Program {
		static void Main(string[] args) {
			PrintSymbols("*", 10);
			PrintSymbols("+", 5);

			Console.ReadLine();
		}
        private static void PrintSymbols(string str, int num)
        {
            string ast = str;
            for (int i = 1; i <= num - 1; i++)
            {
                ast = ast + str;
            }
            Console.WriteLine(ast);
        }
	}
}
