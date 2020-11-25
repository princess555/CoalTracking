using System;
using System.Collections.Generic;
using System.Text;

namespace Class_1_lesson
{
    class Figure
    {
        Point[] point;
        public string Types { get; set; }

        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3];

            point[0] = p1;
            point[1] = p2;
            point[2] = p3;

            Types = "Треугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4];


            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;

            Types = "Квадрат";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5];
                        point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;

            Types = "Многоугольник";
        }

        
        public double LengthSide(Point a, Point b)
        {
            //формула расчета длины между двумя точками
            return (Math.Sqrt(Math.Pow((a.Num1 - a.Num2), 2) + Math.Pow((b.Num2 - b.Num1), 2)));
        }

        public void PerimeterCalculator()
        {
            //длину умножить на кол-во сторон
            double values = 0;

            for (int i = 0; i < point.Length; i++)
            {
                values += LengthSide(point[i], point[i]);//не понятное место
            }

            Console.WriteLine(values);
        }

    }
}
