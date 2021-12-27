using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!!");

        //// for
        //for (int i = 0; i < args.Length; i++)
        //    Console.WriteLine("For: " + i + ") " + args[i]);

        //// for each
        //foreach (string arg in args)
        //    Console.WriteLine("Foreach: " + arg);

        string name = "Vijay Chauhan";
        int age = 20;        


        Console.WriteLine("Name = " + name + " Age = " + age);


        Console.WriteLine($"Name = {name} Age = {age}");

            
        // Strings are immutable = once created cannot be changed.
        string s = "Avinash";     
        s = s + " is my name.";
        s = s + " And teaching is my game!!";

        Console.WriteLine(s);
    }
}
