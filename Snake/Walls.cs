using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int x, int y, char sym)
        {
            wallList = new List<Figure>();
            HorizontalLine h = new HorizontalLine(0, x-2, 0, sym);
            HorizontalLine h1 = new HorizontalLine(0, x-2, y-1, sym);
            VerticalLine v = new VerticalLine(0, y-1, 0, sym);
            VerticalLine v1 = new VerticalLine(0, y-1, x-2, sym);
            wallList.Add(h);
            wallList.Add(h1);
            wallList.Add(v);
            wallList.Add(v1);
        }
        public bool IsHit(Figure figure)
        {
            foreach (Figure item in wallList)
            {
                if (item.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Figure f in wallList)
            {
                f.Draw();
            }
        }
    }
}
