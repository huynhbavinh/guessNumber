using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int A = 0, B = 100;
            int count = 1;
            while (B > A+1)
            {
                int c = (A + B) / 2;
                Console.WriteLine("Question : {0} : Does ur number Greater than {1} ?",count,c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    A = c+1;
                }
                else if (answer == "N")
                {
                    B = c;
                }
            }
            Console.WriteLine("Question {0} : Is your number {1} ?",count,A);
            answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine("{0} IS YOUR NUMBER",A);
            }
            else if (answer == "N")
            {
                Console.WriteLine("{0} IS YOUR NUMBER", B);
            }
        }
    }
}
