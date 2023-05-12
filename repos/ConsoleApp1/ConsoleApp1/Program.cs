using ConsoleAp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class program
    {

        static List<Developer> developers = new List<Developer>();

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("1. CREATE ONCONTRACT DEVELOPER");
                Console.WriteLine("2. CREATE ONPAYROLL DEELOPER");
                Console.WriteLine("3. EXIT FOR MORE OPTIONS");

                Console.Write("Enter your own choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateOnContractDeveloper();
                        break;

                    case 2:
                        CreateOnPayrollDeveloper();
                        break;

                    case 3:
                        Console.WriteLine("Exit application");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 3);

            Console.WriteLine("Display your developer Details");
            DisplayDetails();


            

            int c = 0;
            do
            {

                Console.WriteLine("Please enter a choise\n1. Dispaly all developer  records \n2. Display all records where net salary is more than 20000\n3. Display all records where name contains 'D'");
                Console.WriteLine("4. Exit if you want ");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        DispalyAllRecords();
                        break;
                    case 2:
                        DisplaySalaryMoreThan20000();
                        break;
                    case 3:
                        DisplayNameD();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;




                }


            } while (c < 4);
        }

        static void DispalyAllRecords()
        {
            
            foreach (var dev in developers)
            {
                Console.WriteLine(dev);
            }
        }
        static void DisplaySalaryMoreThan20000()
        {
            var highPaidDevs = developers.Where(dev => dev.NetSalary > 20000);
            foreach (var dev in highPaidDevs)
            {
                Console.WriteLine(dev);
            }

        }
        static void DisplayNameD()
        {
            var devsWithNameD = developers.Where(dev => dev.DeveloperName.Contains("D"));
            foreach (var dev in devsWithNameD)
            {
                Console.WriteLine(dev);
            }

        }
        static void CreateOnContractDeveloper()
        {
            Console.WriteLine("Creating On Contract Developer...");
            Console.Write("Enter developer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter developer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter joining date (dd/mm/yyyy): ");
            DateTime joiningDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter project assigned: ");
            string project = Console.ReadLine();
            Console.Write("Enter duration of contract (in days): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter charges per day: ");
            decimal charges = decimal.Parse(Console.ReadLine());

            OnContract developer = new OnContract(id, name, joiningDate, project, duration, charges);
            developers.Add(developer);

            Console.WriteLine("On Contract Developer created successfully.");
        }

        static void CreateOnPayrollDeveloper()
        {
            Console.WriteLine("Creating On Payroll Developer...");
            Console.Write("Enter developer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter developer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter joining date (dd/mm/yyyy): ");
            DateTime joiningDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter project assigned: ");
            string project = Console.ReadLine();
            Console.Write("Enter department: ");
            string dept = Console.ReadLine();
            Console.Write("Enter manager name: ");
            string manager = Console.ReadLine();
            Console.Write("Enter basic salary: ");
            decimal basicSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter experience (in years): ");
            int exp = int.Parse(Console.ReadLine());

            OnPayroll developer = new OnPayroll(id, name, joiningDate, project, dept, manager, basicSalary, exp);
            developers.Add(developer);

            Console.WriteLine("On Payroll Developer created successfully.");
        }
        static void DisplayDetails()
        {
            if (developers.Count == 0)
            {
                Console.WriteLine("\nNo developers found.\n");
                return;
            }
            foreach (Developer dev in developers)
            {
                dev.CalculateSalary();
                Console.WriteLine(dev.ToString());
            }

            
        }
    }
}