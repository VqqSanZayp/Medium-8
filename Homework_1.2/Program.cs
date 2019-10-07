using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_1._2
{
    class Pointer
    {
        static private int _idNewPointer = 0;
        public int Id { get; private set; }
        public int Coordinate_x { get; private set; }
        public int Coordinate_y { get; private set; }
        public bool IsAlive { get; private set; }

        public Pointer(int x_coordinate, int y_coordinate)
        {
            Id = ++_idNewPointer;
            Coordinate_x = x_coordinate;
            Coordinate_y = y_coordinate;
            IsAlive = true;
        }

        private void Death()
        {
            IsAlive = false;
        }
        public void DifferentOrDeath(Pointer pointer)
        {
            if (Coordinate_x == pointer.Coordinate_x && Coordinate_y == pointer.Coordinate_y)
            {
                IsAlive = false;
                pointer.Death();
            }
        }

        public void ChangeCoordinates(int x, int y)
        {
            Coordinate_x += x;
            Coordinate_y += y;
        }
        
        public void СoordinatesBelowZero()
        {
            if (Coordinate_x < 0)
            {
                Coordinate_x = 0;
            }
            if (Coordinate_y < 0)
            {
                Coordinate_y = 0;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pointer> pointers = new List<Pointer> { new Pointer(5, 5), new Pointer(10, 10), new Pointer(15, 15) };

            Random random = new Random();

            while (true)
            {
                foreach(Pointer pointer in pointers)
                {
                    for (int i = pointer.Id+1; i <= pointers.Count(); i++)
                    {
                        pointer.DifferentOrDeath(pointers.FirstOrDefault(p => p.Id == i));
                    }

                    pointer.ChangeCoordinates(random.Next(-1, 1), random.Next(-1, 1));
                    pointer.СoordinatesBelowZero();

                    if (pointer.IsAlive == true)
                    {
                        Console.SetCursorPosition(pointer.Coordinate_x, pointer.Coordinate_y);
                        Console.Write(pointer.Id);
                    }
                }
            }
        }
    }
}
