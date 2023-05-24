using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalc;

public static class MyCalc
{
    private static (double, double) Get2Nums()
    {
        bool t1 = false;
        bool t2 = false;

        double a = default;
        double b = default;

        do
        {
            Console.Clear();
            Console.WriteLine("input 2 nums:");

            t1 = double.TryParse(Console.ReadLine(), out a);
            t2 = double.TryParse(Console.ReadLine(), out b);
            
        } while (!t1 || !t2);

        return (a, b);
    }
    public static double Sum()
    {
        double a;
        double b;

        (a, b)= MyCalc.Get2Nums();

        double res = a + b;

        Console.Clear();
        Console.WriteLine($"{a} + {b} = {res}");
        Thread.Sleep(3000);

        return res;
    }

    public static double Dif()
    {
        double a;
        double b;

        (a, b) = MyCalc.Get2Nums();

        double res = a - b;

        Console.Clear();
        Console.WriteLine($"{a} - {b} = {res}");
        Thread.Sleep(3000);

        return res;
    }

    public static double Mult()
    {
        double a;
        double b;

        (a, b) = MyCalc.Get2Nums();

        double res = a * b;

        Console.Clear();
        Console.WriteLine($"{a} * {b} = {res}");
        Thread.Sleep(3000);

        return res;
    }

    public static double Div()
    {
        double a;
        double b;

        (a, b) = MyCalc.Get2Nums();

        if (b == 0)
            throw new DivideByZeroException("div by zero error occured!!!");

        double res = a / b;

        Console.Clear();
        Console.WriteLine($"{a} / {b} = {res}");
        Thread.Sleep(3000);

        return res;
    }
}
