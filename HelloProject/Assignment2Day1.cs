using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject
{    
    internal class Assignment2Day1
    {
        /// <summary>
        /// Create a employee entry screen to add employees. When done, display all newly 
        /// joined employee
        /// New requirement REQ01: Add new field telephone number
        /// </summary>
        static void Main()
        {
            string answer;

            string[] names = new string[100];
            int[] ages = new int[100];
            double[] salaries = new double[100];

            // REQ01
            string[] telephoneNumbers = new string[50];

            int employeeIndex = 0;
            do
            {
                Console.Write("Enter Name: ");
                string nameText = Console.ReadLine();
                Console.Write("Enter Age: ");
                string ageText = Console.ReadLine();
                Console.Write("Enter Salary: ");
                string salaryText = Console.ReadLine();

                // REQ01
                Console.Write("Enter Telephone number: ");
                string telephoneText = Console.ReadLine();

                names[employeeIndex] = nameText;
                ages[employeeIndex] = Convert.ToInt32(ageText);
                salaries[employeeIndex] = Convert.ToDouble(salaryText);
                
                // REQ01
                telephoneNumbers[employeeIndex] = telephoneText;

                employeeIndex++;

                Console.Write("Do you want to add another employee entry [y/n]? ");
                answer = Console.ReadLine();
            
            } while (answer == "y");

            // Display Report
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Newly joined Employee Report");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < employeeIndex; i++)
            {
                // REQ01
                Console.WriteLine($"Name: {names[i]} Age: {ages[i]} Salary: {salaries[i]} Telephone: {telephoneNumbers[i]}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
