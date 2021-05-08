using System;

namespace ConsoleApp18_TotalNoOfTurns
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://stackoverflow.com/questions/62082461/cut-m-and-n-letters-from-end-of-string-then-find-number-of-turns-to-get-back-or

            //input 1: original string
            //input 2: m(less than length of string): cut m alphabets from end of string and then add to begining of string.
            //input 3: n(less than length of string) : cut n alphabets from end of string obtained from above step and then add to begining of that string.

            string inputStr = "arya";
            int m = 1, n = 2;

            int mod = 5 % 2; // o/p: 1 (reminder)
            int div = 5 / 2; //o/p : 2 (quotient)

            Console.WriteLine("TotalNoOfTurns : " + GetTotalNoOfTurns(inputStr, m, n)); // o/p : 3

            ////ARYA
            
            //AARY - h
            //RYAA - p

            //ARYA - h
            //YAAR - p

            //RYAA - h
            //AARY - P

            //YAAR - h
            //ARYA - p

            // 4 rounds
        }

        private static int GetTotalNoOfTurns(string input, int m, int n)
        {
            int noOfTurns = 0;
            string oldStr = input, newStr = "";
            while (input != newStr)
            {
                noOfTurns++;
                
                string harryEndStr = oldStr.Substring(0, oldStr.Length - m);
                string harryStartStr = oldStr.Substring(oldStr.Length - m);

                string potterStr = harryStartStr + harryEndStr;

                string potterEndStr = potterStr.Substring(0, potterStr.Length - n);
                string potterStartStr = potterStr.Substring(potterStr.Length - n);

                newStr = potterStartStr + potterEndStr;
                oldStr = newStr;
            }

            return noOfTurns;
        }
    }
}
