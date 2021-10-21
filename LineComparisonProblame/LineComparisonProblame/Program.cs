using System;

namespace LineComparisonProblame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME!");

            UC1 useCase1 = new UC1();
            useCase1.LengthOfLine();

            UC2 useCase2 = new UC2();
            useCase2.EqualityOfLine();

            UC3 useCase3 = new UC3();
            useCase3.CompareTwoLine();
        }
    }
}
