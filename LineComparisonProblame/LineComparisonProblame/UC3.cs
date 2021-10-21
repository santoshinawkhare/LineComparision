using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblame
{
    class UC3
    {
        public void CompareTwoLine()
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
            int diffrence = line1.CompareTo(line2);

            if (diffrence == 0)
            {
                Console.WriteLine(" The line are equal in length");
            }
            else if (diffrence > 0)
            {
                Console.WriteLine("The first line is gratter in length than second line");
            }
            else
            {
                Console.WriteLine("The first line is gratter in length than second line");
            }
        }
    }
}
