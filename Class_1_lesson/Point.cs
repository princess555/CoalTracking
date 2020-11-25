using System;
using System.Collections.Generic;
using System.Text;

namespace Class_1_lesson
{
    class Point
    {
        private int num1;
        private int num2;
        private string text;

        public Point(int num1, int num2, string text)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.text = text;
        }

        public  int Num1 { get { return num1; } }
        public int Num2 { get { return num2; } }

        public string Text { get { return text; } }
    }
}
