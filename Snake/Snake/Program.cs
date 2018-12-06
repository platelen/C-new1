﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Draw(Figure figure)
        {
            figure.Drow();
        }
      
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(80, 28);
            Console.SetBufferSize(80,28);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreatFood();
            food.Draw();

            while(true)
            {
                if ((walls.IsHit(snake)) || snake.IsHitTail())
                    {
                    break;
                    }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreatFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Console.CursorVisible = false;
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
