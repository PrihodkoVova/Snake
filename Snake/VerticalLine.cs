using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, symbol);
                pList.Add(p);
            }
        }
        
    }
}
