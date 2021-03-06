﻿using System;

namespace Classes
{
    class Point
    {
        private int _x = 0;
        private int _y = 0;
        private static int objectCount = 0;
        public Point()
        {
            Console.WriteLine("Default constructor called");
            _x = -1;
            _y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            Console.WriteLine($"x:{x}, y:{y}");
            _x = x;
            _y = y;
            objectCount++;
        }
        public double DistanceTo(Point other)
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
