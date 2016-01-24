using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        public virtual void Draw()
        {
            foreach (Point item in pList)
            {
                Console.SetCursorPosition(item.x, item.y);
                Console.Write(item.sym);
            }
        }
    }
}
