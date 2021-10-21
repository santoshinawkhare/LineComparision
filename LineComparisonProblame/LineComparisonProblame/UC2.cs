using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblame
{
    class UC2
    {

        public void EqualityOfLine()
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
              if (line1 == line2)
            {
                Console.WriteLine(" The given line have equal length");
            }
              else
            {
                Console.WriteLine(" The given line do not have equal length");
            }
 
        }
    }
}
