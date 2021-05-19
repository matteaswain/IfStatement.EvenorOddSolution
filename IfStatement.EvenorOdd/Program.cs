using System;

namespace IfStatement.EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var runAgain = true;
            while (runAgain == true) 
            { 
            Console.Write("Enter an interger :");
            var answerStir = Console.ReadLine();
            var answer = int.Parse(answerStir);
            var evenNumber = answer % 2 == 0;
            if(evenNumber == true) 
            {
                Console.WriteLine($"{answer} is Even.");            
            }
            else 
            {
                Console.WriteLine($"{answer} is Odd.");
            }
            Console.Write("Continue? (Y if yes) :");
                answerStir = Console.ReadLine();
               if (answerStir == "y" || answerStir == "Y")
                {
                    runAgain = true;
                } else
                {
                    runAgain = false;
                }

            }


        }
    }
}
