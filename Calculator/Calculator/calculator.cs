using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class calculator
    {
        double x;
        double y;
        double answer;

        private calculator(double a, double b)
        {
            x = a;
            y = b;
        }

        private static void Addition(calculator Obj)
        {
            Obj.answer = Obj.x + Obj.y;
        }

        private static void Multiplication(calculator Obj)
        {
            Obj.answer = Obj.x * Obj.y;
        }

        private static void Subtraction(calculator Obj)
        {
            Obj.answer = Obj.x - Obj.y;
        }

        private static void Вivision(calculator Obj)
        {
            Obj.answer = Obj.x / Obj.y;
        }

        public static double Calculate(string s)
        {
            List<string> list = new List<string>();
            list = s.Split().ToList();
            calculator g = new calculator(Convert.ToDouble(list[0]), Convert.ToDouble(list[2]));
            switch (list[1])

            {
                case "+":
                    Addition(g);
                    break;
                case "-":
                    Subtraction(g);
                    break;
                case "*":
                    Multiplication(g);
                    break;
                case "/":
                    Вivision(g);
                    break;
                default:
                    throw new ArgumentException(String.Format("Invalid"));
            }

            return g.answer;
        }
    }
}