using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Draw();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Draw();

            Console.ReadKey();

            Point p = new Point(3, 3, '*');
            Snake s = new Snake(p, 5, Direction.LEFT);
        }
        
    }
}
