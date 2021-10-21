using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblame
{
    class UC1
    {
       
        public void LengthOfLine()
        {
            int X1, X2, Y1, Y2;
            Console.WriteLine("Enter the value of X1 and Y1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of X2 and Y2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());
            double lineLength = (Math.Sqrt((X2 - X1)^2 + (Y2 - Y1)));
            Console.WriteLine("The length of line is : " + lineLength);
        }
    }
}
