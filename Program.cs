using System;

namespace Calculator_Console
{
    class Program
    {
        public static void Main()
        {
            //Welcomme Message
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            //Switch
            Console.WriteLine("Pick you choice\n" + "[0] settings \n[1] = Plus" + "\n");
            Console.Write("You choice? ");
            switch (Console.ReadLine())
            {
                case "0": //reload 
                        settings();
                    break;
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
                        Console.WriteLine($"Your result: {num1} + {num2} + {num3} = " + (num1 + num2 + num3));
                        switch (Console.ReadLine())
                        {
                            case "1":
                                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                                break;
                            case "2":
                                Environment.Exit(0);
                                break;
                        }

                    } else if(add1 == 2)
                    {
                        Console.WriteLine($"Your result: {num1} + {num2}     = " + (num1 + num2));
                        //Restart
                        settings();
                    }
                    break;
                case "2": //Subtract
                    Console.Clear();
                    Console.WriteLine("choice = Add");
                    Console.WriteLine("------------------------\n");

                    Console.WriteLine("Type a number, and then press Enter");
                    //int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type another number, and then press Enter");
                    //int num2 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        
        public static void settings()
        {
            Console.WriteLine("\n" + "Will you like to restart the Calculator" + "\n [1] Restart" + "\n [2] Color" + "\n [3] Close");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Main();
                    break;
                case "2":
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
