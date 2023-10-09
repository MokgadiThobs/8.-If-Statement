using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The test that can be either true or false
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are Female");
            }
            //can aslo test 2 conditions with and ie && in C#, or is ||
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall");
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("You are tall but you are male");
            }
            else
            {
                Console.WriteLine("You are either tall or not male");
            }
        }
    }
}