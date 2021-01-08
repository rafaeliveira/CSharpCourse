using AbstractMethods.Entities;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int iShapeNum = 0;

            char cType;
            
            double dWidth = 0d;
            double dHeight = 0d;
            double dRadius = 0d;

            Color color;

            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of Shapes: ");
            iShapeNum = int.Parse(Console.ReadLine());

            if(iShapeNum > 0)
            {
                for (int i = 1; i <= iShapeNum; i++)
                {
                    Console.WriteLine($"Shape #{i} data: ");

                    Console.WriteLine("Rectangle or Circle (r/c)? ");
                    cType = char.Parse(Console.ReadLine());

                    Console.WriteLine("Color (Black/Blue/Red): ");
                    color = Enum.Parse<Color>(Console.ReadLine());

                    if (cType == 'r')
                    {
                        Console.WriteLine("Width: ");
                        dWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine("Height: ");
                        dHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Rectangle(dWidth, dHeight, color));
                    }
                    else
                    {
                        Console.WriteLine("Radius: ");
                        dRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Circle(dRadius, color));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");

                foreach (Shape shape in list)
                {
                    Console.WriteLine("Area: " + shape.area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}