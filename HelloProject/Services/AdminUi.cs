using HelloProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject.Services
{
    internal class AdminUi
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
