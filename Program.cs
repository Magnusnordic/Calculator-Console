﻿using System;

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
            Console.WriteLine("Pick you choice\n" + "[0] = settings");
            Console.WriteLine("[1] = Plus" + "\n[99] moms regn");
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
                    if(add1 == 1) //add num3
                    {
                        Console.Clear();
                        Console.WriteLine("You number " + $"{num1} + {num2}" + "\n");
                        Console.WriteLine("Type 3th number, and then press Enter");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} + {num2} + {num3} = " + (num1 + num2 + num3));
                        switch (Console.ReadLine())
                        {
                            case "1":
                                restart();
                                break;
                            case "2":
                                Environment.Exit(0);
                                break;
                        }

                    } else if(add1 == 2)
                    {
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        //Restart
                        restart();
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
                case "99":
                    moms();
                    break;
            }
            Console.Clear();
            Main();
        }
        public static void moms()
        {
            Console.Clear();
            Console.WriteLine("choice = Moms");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("[1] = Calculate Incl. VAT" + "\n[2] = Calculate Excl. VAT");
            Console.Write("You choice? ");
            switch (Console.ReadLine())
            {
                case "1": //læg moms på
                    Console.WriteLine("\nInsætte din pris du vil læg moms på");
                    int prisumoms = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("din pris med moms er " + (prisumoms * 1.25));
                    Console.WriteLine("Din moms der regns med er " + ((prisumoms * 1.25) - prisumoms));
                    restart();
                    break;
                case "2":
                    Console.WriteLine("\nInsætte din pris du vil udregn moms på");
                    int prismmoms = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("din pris med moms er " + (prismmoms / 1.25));
                    Console.WriteLine("Din moms der regns fra er " + (prismmoms - (prismmoms / 1.25)));
                    restart();
                    break;
            }
        }
        public static void restart()
        {
            Console.WriteLine("\n" + "Reset" + "\n [1] Restart" + "\n [2] Settings" + "\n [3] Close");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Main();
                    break;
                case "2":
                    settings();
                    break;
                case "3":
                    Environment.Exit(1);
                    break;
            }
        }
        public static void settings()
        {
            Console.WriteLine("\n" + "Settings" + "\n [1] Restart" + "\n [2] Color" + "\n [3] Close");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Main();
                    break;
                case "2":
                    colorconsole();
                    break;
                case "3":
                    Environment.Exit(1);
                    break;
            }
            Console.Clear();
            settings();
        }
        public static void colorconsole()
        {
            Console.Clear();
            Console.WriteLine("Tab: Settings/Color Console");
            Console.WriteLine("\n" + "Chance console color\n");
            Console.WriteLine("[1] Default Color" + "\n[2] Rød");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Main();
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Main();
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Main();
                    break;
            }
            Environment.Exit(1);
        }
    }
}
