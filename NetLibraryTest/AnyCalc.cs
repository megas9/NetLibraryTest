using System;

namespace NetLibraryTest
{
    public class AnyCalc
    {
        /*
        Library for calc area of cicle and triangle
        Features: autodect figures, unit test 
        */
        public struct Figure // type figure for return result
        {
            public string type; // type of figure
            public double area; // area
            public string message; // details
        }


        public Figure AnyFigure(double a) // if we have 1 arguments
        {
           
            double s = Math.PI * Math.Pow(a, 2);
            Figure f = new Figure
            {
                type = "Cicle",
                area = s,
                message = "Cicle, Area: " + s
            };
            return f;

        }
        public Figure AnyFigure(double a, double b, double c) // if we have 3 arguments
        {
            double s = (a + b + c) / 2;

            Figure f = new Figure
            {
                area = s
            };


            if (System.Math.Pow(c, 2) == System.Math.Pow(a, 2) + System.Math.Pow(b, 2)) //if right triangle
            {
                f.type = "Triangle";
                f.message = f.type + ", area: " + s;
            }
            else
            {
                f.type = "Right triangle";
                f.message = f.type + ", area: " + s;
            }
           
            return f;

        }

    }
}
