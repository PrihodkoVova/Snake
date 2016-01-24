using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int xmax;
        int ymax;
        char sym;
        Random random = new Random();
        public FoodCreator(int x, int y, char symbol)
        {
            xmax = x;
            ymax = y;
            sym = symbol;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, xmax - 2);
            int y = random.Next(2, ymax - 2);
            return new Point(x, y, sym);
        }
    }
}
