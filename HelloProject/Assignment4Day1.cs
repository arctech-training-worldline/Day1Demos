using HelloProject.Entities;
using HelloProject.Services;
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
    }
}