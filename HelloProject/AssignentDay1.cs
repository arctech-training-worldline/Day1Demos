using System;

class AssignentDay1
{
    static void Main()
    {
        /*
        Console.WriteLine("Hello World");

        string[] fruits = { "apple", "mango", "papaya", "banana", "guava", "pinepapple" };

        // Display all fruits except if any fruits contains the letter p
        // then skip the next fruit.
        // move back and forth inside the array
        for (int i = 0; i < fruits.Length; i++)
        {
            string fruit = fruits[i];
            Console.WriteLine(fruit);

            if (fruit.Contains("p"))
                i++;
        }
        
        //for (int i = fruits.Length - 1; i >= 0; i--)
        //    Console.WriteLine(fruits[i]);
        Console.WriteLine("-----------------------------------");

        // forward only loop
        foreach (string fruit in fruits)
            Console.WriteLine(fruit);
        */
        Console.WriteLine("-----------------------------------");
        // Ask user to enter age
        // Validate age if < 18 then display "NO ENTRY", else display "PLEASE WELCOME"

        Console.Write("Enter your age: ");
        string ageText = Console.ReadLine();

        int age = Convert.ToInt32(ageText);

        Console.Write("Enter your salary: ");
        string salaryText = Console.ReadLine();

        double salary = Convert.ToDouble(salaryText);

        if (age < 18)
            Console.WriteLine("NO ENTRY");
        else
            Console.WriteLine("PLEASE WELCOME");

        Console.WriteLine("-----------------------------------");

        // Compile time error
        // int a = "Avinash";
        // Run time error
        // Enter a text when prompted to enter age in the above example. This will show runtime error        

        int employeeAge = 10;
        string employeeName = "Avinash Tauro";

        double employeeSalary = 15.553413543;
        float employeeBonus = 15.553413543f;        

        Console.WriteLine($"Salary={employeeSalary} & Bonus={employeeBonus}");
    }
}
