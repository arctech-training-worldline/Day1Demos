using HelloProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject
{
    internal class Assignment3Day1
    {
        /// <summary>
        /// Create a employee entry screen to add employees. When done, display all newly 
        /// joined employee
        /// New requirement REQ02: Change the code from MainOld to use classes
        /// </summary>
        static void Main()
        {
            string answer;
            Employee[] employees = new Employee[100];

            int employeeIndex = 0;
            do
            {
                Console.Write("Enter Name: ");
                string nameText = Console.ReadLine();
                Console.Write("Enter Age: ");
                string ageText = Console.ReadLine();
                Console.Write("Enter Salary: ");
                string salaryText = Console.ReadLine();

                Console.Write("Enter Telephone number: ");
                string telephoneText = Console.ReadLine();

                Employee employee = new Employee();
                employee.name = nameText;
                employee.age = Convert.ToInt32(ageText);
                employee.salary = Convert.ToDouble(salaryText);
                employee.telephoneNumber = telephoneText;

                employees[employeeIndex++] = employee;

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
                Employee employee = employees[i];
                Console.WriteLine($"Name: {employee.name} Age: {employee.age} Salary: {employee.salary} Telephone: {employee.telephoneNumber}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
