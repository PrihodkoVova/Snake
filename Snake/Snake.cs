using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private Direction direction;
        public int Points
        {
            get
            {
                return pList.Count;
            }
        }
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }
        
        public Point GetNextPoint()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Point next = new Point(pList.Last());
            next.Move(1, direction);
            return next;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }
        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count-2; i++)
            {
                if (head.isHit(pList[i]))
                {
                    return true;
                }   
            }
            return false;
        }
        public void ChangeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && direction!=Direction.RIGHT)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow && direction != Direction.LEFT)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow && direction != Direction.DOWN)
               direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow && direction != Direction.UP)
                direction = Direction.DOWN;
        }
    }
}
