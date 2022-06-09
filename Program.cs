using System;

namespace Calculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcomme Message
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            //Switch
            Console.WriteLine("Pick you choice\n" + "[1] = Plus" + "\n");
            Console.Write("You choice? ");
            switch (Console.ReadLine())
            {
                case "1": //Plus
                    Console.Clear();
                    Console.WriteLine("choice = Add");
                    Console.WriteLine("------------------------\n");

                    Console.WriteLine("Type a number, and then press Enter");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type another number, and then press Enter");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    //mere +
                    Console.WriteLine("\n" + "More Add? \n [1] = Yes \n [2] = No");
                    Console.Write("You choice? ");
                    int add1 = Convert.ToInt32(Console.ReadLine());
                    if(add1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You number " + $"{num1} + {num2}" + "\n");
                        Console.WriteLine("Type 3th number, and then press Enter");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} + {num2} + {num3} = " + (num1 + num2 + { num3}));
                    } else if(add1 == 2)
                    {
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    }
                    break;
            }
        }
    }
}
