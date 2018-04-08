using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin {
	class Program {
		static void Main(string[] args) {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

		static string GetMostNumerous(string[] penguins) {
            int emp = 0;
            int mac = 0;
            int lit = 0;
            for (int i = 0; i < penguins.Length; i++)
            {
                if (penguins[i] == "Emperor Penguin")
                {
                    emp = emp + 1;
                }

                if (penguins[i] == "Macaroni Penguin")
                {
                    mac = mac + 1;
                }

                if (penguins[i] == "Little Penguin")
                {
                    lit = lit + 1;
                }
            }

            if (emp > mac)
            {
                if (emp > lit)
                {
                    return "Emperor Penguin";
                }
            }

            else if (mac > emp)
            {
                if (mac > lit)
                {
                    return "Macaroni Penguin";
                }
            }

            else if (lit > emp)
            {
                if (lit > mac)
                {
                    return "Little Penguin";
                }
            }
            return "";
		}
	}
}
