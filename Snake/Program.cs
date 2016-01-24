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
            Console.Title = "Snake";
            Console.SetBufferSize(80, 30);
            Console.SetWindowSize(80, 30);

            Walls wall = new Walls(80, 30, '+');
            wall.Draw();
            Point p = new Point(3,3,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 30, '$');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Yellow;
            food.Draw();

            while (true)
            {
                
                if ( wall.IsHit(snake) || snake.IsHitTail() )
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ChangeDirection(key.Key);
                }
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(32,10);
            Console.Write("****************");
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("Game over!");
            Console.SetCursorPosition(35, 12);
            Console.Write("Points:{0}",snake.Points);
            Console.SetCursorPosition(32, 13);
            Console.Write("****************");
            Console.ReadLine();
        }
    }
}
