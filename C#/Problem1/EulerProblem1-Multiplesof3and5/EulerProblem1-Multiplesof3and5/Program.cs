using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem1_Multiplesof3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //Going through all numbers untill upper range i.e. 1000
            //Thats Bruteforce solution
            for (int i = 0; i < 1000; i++)
            {
                if ((i%3==0) || (i%5==0)) //Checking if its multiple of 3 or 5
                {
                    sum += i; //If true, add to sum initiated by zero
                }
            }
            Console.WriteLine(sum); //Print the calculated result
            Console.Read();
        }
    }
}
