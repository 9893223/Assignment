using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Developer: Ben de Rijk
//Student ID:9893223
//Project: Payroll system
namespace Assignement_question_2_Payroll_system
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****************Welcome to the staff payroll system prototype*************");
            Console.WriteLine("********This application will calculate your anuual salary after tax*******");

            //Using constructor to create a new object of the class Employee
            Employee Emp1 = new Employee();
            
            //Obtain information from the user -name, gross salary, tax rate
            Console.WriteLine("\nPlease enter your name:");
            Emp1.Name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your annual gross salary:");
            Emp1.AnnualGrossSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter your tax rate:");
            Emp1.TaxRate = double.Parse(Console.ReadLine());

            //Display the obtained information back to the user and call the Calcnet method to display net salary
            Console.WriteLine($"\nThanks {Emp1.Name}. With an annual gross salary off {Emp1.AnnualGrossSalary:C} " +
                $"and a tax rate of {Emp1.TaxRate}%, your annual net salary is: {Emp1.CalcNet():C}");


            Console.ReadLine(); 


        }
    }

    class Employee
    {
        //Private instance variables
        private string name; 
        private double annualGrossSalary;
        private double taxRate; 

        //Public properties for each instance variables
        public string Name
        {
           get { return name; }
           set { name = value; }
        }

        public double AnnualGrossSalary
        {
            get { return annualGrossSalary; }
            set { annualGrossSalary = value; }
        }

        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }

        //Method to calculate net salary
        public double CalcNet()
        {
            return annualGrossSalary * (1 - taxRate / 100);
        }

        //Constructor to display message only
        public Employee()
        {
            Console.WriteLine("\nNew employee record created.");
        }
    }
}
