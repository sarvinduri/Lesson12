using Lesson12.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Circle c;
        Rectangle r;
        Triangle t;
        double p, s;
        Console.WriteLine("Введите значение радиуса окружности");
        c = new Circle(Convert.ToDouble(Console.ReadLine()));
        p = c.Perimetr();
        s = c.Square();
        Console.WriteLine("Периметр окружности равер {0:0.00}; площадь равна {1:0.00}", p,s);
        Console.WriteLine("Введите значение сторон прямоугольника(одно значение на строке)");
        r = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        p = r.Perimetr();
        s = r.Square();
        Console.WriteLine("Периметр прямоугольника равен {0:0.00}; площадь равна {1:0.00}", p,s);
        Console.WriteLine("Введите значение сторон треугольника(одно значение на строке)");
        t = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        if (t.Exist)
        {
            p = t.Perimetr();
            s = t.Square();
            Console.WriteLine("Периметр трекгольника равен {0:0.00}; площадь равна {1:0.00}", p, s);
        }
        else Console.WriteLine("С заданными длинами сторон треугольник не может быть построен");
        Console.WriteLine("Нажмите на любую клавишу для завершения работы...");
    }
}
