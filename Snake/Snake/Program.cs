using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(80, 28);
            Console.SetBufferSize(80,28);
            
            HorizontalLine leftLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine rightLine = new HorizontalLine(0, 78, 27, '+');
            VerticalLine upLine = new VerticalLine(0, 27, 0, '+');
            VerticalLine downLine = new VerticalLine(0, 27, 78, '+');
            leftLine.Drow();
            rightLine.Drow();
            upLine.Drow();
            downLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Console.CursorVisible = false;
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
