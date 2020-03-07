using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{
    public class Input
    {
        public static double res = 0;
        public  bool exit = true;
        Operat operat;

        
        public void Start()
        {
            while (exit == true)
            {

                Console.WriteLine("What do you want to do?\n" +
                    "1)+\n" +
                    "2)-\n" +
                    "3)*\n" +
                    "4)/\n" +
                    "5)^\n" +
                    "6)delete\n" +
                    "0)exit\n");
                int q = Convert.ToInt32(Console.ReadLine());

                if (q == 1)
                {
                    if (res == 0)
                    {
                        Console.WriteLine("Input 2 numbers: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.SumAB(res, b);
                        Console.WriteLine("Result= " + res);
                    }
                    else
                    {
                        Console.WriteLine("Input number: ");
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.SumAB(res, b);
                        Console.WriteLine("Result= " + res);
                    }
                }
                else if (q == 2)
                {
                    if (res == 0)
                    {
                        Console.WriteLine("Input 2 numbers: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.MinusAB(a, b);
                        Console.WriteLine("Result= " + res);
                    }
                    else
                    {
                        Console.WriteLine("Input number: ");
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.MinusAB(res, b);
                        Console.WriteLine("Result= " + res);
                    }
                }
                else if(q == 3)
                {
                    if (res == 0)
                    {
                        Console.WriteLine("Input 2 numbers: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.MultAB(a, b);
                        Console.WriteLine("Result= " + res);
                    }
                    else
                    {
                        Console.WriteLine("Input number: ");
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.MultAB(res, b);
                        Console.WriteLine("Result= " + res);
                    }
                }
                else if (q == 4)
                {
                    if (res == 0)
                    {
                        Console.WriteLine("Input 2 numbers: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.DelAB(a, b);
                        Console.WriteLine("Result= " + res);
                    }
                    else
                    {
                        Console.WriteLine("Input number: ");
                        var b = Convert.ToDouble(Console.ReadLine());
                        res = Operat.DelAB(res, b);
                        Console.WriteLine("Result= " + res);
                    }
                }
                else if (q == 5)
                {
                    if (res == 0)
                    {
                        Console.WriteLine("Input 2 numbers: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        var b = Convert.ToInt32(Console.ReadLine());
                        res = Operat.Degree(a, b);
                        Console.WriteLine("Result= " + res);
                    }
                    else
                    {
                        Console.WriteLine("Input number: ");
                        var b = Convert.ToInt32(Console.ReadLine());
                        res = Operat.Degree(res, b);
                        Console.WriteLine("Result= " + res );

                    }
                }
                else if (q == 6)
                {
                    res = 0;
                    Console.WriteLine("Result= " + res);
                }
                else if ( q == 0)
                {
                    exit = false;
                    Console.WriteLine("Thanks for using!Goodbye!");
                    Console.ReadKey();
                }
            }


        }
    }
}
