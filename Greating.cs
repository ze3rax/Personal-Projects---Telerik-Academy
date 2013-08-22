/* Write a method that askes the user for his name and prints "Hello, <name>" */

using System;
using System.Linq;

class Greating
{
    static string name;
    static string answer;
    static readonly string connecting = "*\n*\n*\n*\n*\n*\nInitializing connection...";
    static readonly string questionOne = "- Hello. Who's there ?";
    static readonly string questionTwo = "- You don't say! What is your name, really ?";
    static readonly string watch = "- Do you have a watch to check the time?";

    static readonly string time = string.Format(" Great then! The time is : {0}", DateTime.Now.ToLongTimeString());
    static readonly DayOfWeek today = DateTime.Today.DayOfWeek;
    static readonly string end = "\n*\n*\n*\nSystem Terminated\n*\n*\n*";

    static void Question()
    {
        foreach (var ch in connecting)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();

        foreach (var ch in questionOne)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();

        name = Console.ReadLine();

        if (name == "Me" | name == "I" | name == "me")
        {
            foreach (var ch in questionTwo)
            {
                Console.Write(ch);
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();
            name = Console.ReadLine();
            Name();
        }
        else
        {
            Name();
        }

        //Watch question
        if (answer == "No" | answer == "no")
        {
            Watch();
        }
        else
        {
            Terminate();
        }

    }

    static void Name()
    {
        string greeting = string.Format("- It was not that scary, right?\n Hello then, {0}. Today is {1}", name, today);

        foreach (var ch in greeting)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();

        foreach (var ch in watch)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();

        answer = Console.ReadLine();
    }

    static void Watch()
    {
        foreach (var ch in time)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();
        Terminate();
    }

    static void Terminate()
    {
        foreach (var ch in end)
        {
            Console.Write(ch);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    //Printing comunication with AI
    static void Main()
    {
        Question();
    }
}


/* Each foreach cycle could be put in a method */
