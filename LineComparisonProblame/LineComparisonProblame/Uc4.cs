using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblame
{
    class Uc4
    {
        class CompareToLines
        {
            public void Comparision()
            {
                int x1, x2, x3, x4, y1, y2, y3, y4;
                Console.WriteLine("Enter value of X1 and Y1");
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of X2 and Y2");
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of X3 and Y3");
                x3 = Convert.ToInt32(Console.ReadLine());
                y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of X4 and Y4");
                x4 = Convert.ToInt32(Console.ReadLine());
                y4 = Convert.ToInt32(Console.ReadLine());
                double line1 = (Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
                double line2 = (Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2));
                int variation = line1.CompareTo(line2);
                Boolean variation2 = line1.Equals(line2);
                if (variation2 == true)
                    Console.WriteLine("Both Lines are equal in length");
                else
                    Console.WriteLine("Both are not equal in length");

                if (variation == 0)
                    Console.WriteLine("Both Lines are equal in length");
                else if (variation > 0)
                    Console.WriteLine("First Line is greater than Second Line");
                else
                    Console.WriteLine("First Line is smaller than Second Line");
            }
        }
    }
}
