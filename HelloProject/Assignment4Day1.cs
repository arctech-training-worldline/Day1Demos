using HelloProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject
{
    /// <summary>
    /// Create a employee entry screen to add employees. When done, display all newly 
    /// joined employee
    /// Ensure proper architecture and system design
    /// </summary>
    /// 
    internal class Assignment4Day1
    {
        static void Main()
        {
            AdminUi adminUi = new AdminUi();

            string answer;
            do
            {
                adminUi.InputData();

                Console.Write("Do you want to add another employee entry [y/n]? ");
                answer = Console.ReadLine();

            } while (answer == "y");

            adminUi.DisplayData();
        }

    class AdminUi
    {
        //Employee[] employees = new Employee[100];
        List<Employee> employees = new List<Employee>();

        public void InputData()
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

            employees.Add(employee);
        }

        public void DisplayData()
        {
            // Display Report
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Newly joined Employee Report");
            Console.WriteLine("----------------------------");

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.name} Age: {employee.age} Salary: {employee.salary} Telephone: {employee.telephoneNumber}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
