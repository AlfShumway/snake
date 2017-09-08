using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '#');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }
           
            Console.ReadLine();
        }      
    }
}
