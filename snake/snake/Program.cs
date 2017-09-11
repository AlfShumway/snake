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
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '#');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> Figures = new List<Figure>();
            Figures.Add(fSnake);
            Figures.Add(v1);
            Figures.Add(h1);

            foreach (var f in Figures)
            {
                f.Draw();
            }
        }
        static void Draw (Figure figure)
        {
            figure.Draw();
        }     
    }
}
