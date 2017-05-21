using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Employee
    {
        public static int countOfEmployee;
        public Employee()
        {
            countOfEmployee++;
        }

        // Write a static method “DisplayCount” to display the count of Employee objects, in
        // class Employee.
        public static void DisplayCount()
        {
            Console.WriteLine("Count of Employee: " + countOfEmployee);
        }
    }

    class Program
    {
        /// <summary> 
        /// The main entry point for the application. 
        /// </summary>
  
        static void Main(string[] args)
        {
            Employee empObj1 = new Employee();
            Employee empObj2 = new Employee();
            Employee empObj3 = new Employee();

            // Printing the number of employees 
            Employee.DisplayCount();
             Console.WriteLine("Count of Employees: " + Employee.countOfEmployee);
            //  Console.WriteLine("Count of Employee: " + empObj1.countOfEmployee);
            Console.ReadLine();
        }
    }
}
