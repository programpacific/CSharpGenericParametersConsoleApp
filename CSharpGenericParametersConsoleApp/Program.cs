using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.

namespace CSharpGenericParametersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>() { things = new List<string>() { "Test String #1", "Test String #2" } };

            Employee<int> employeeTwo = new Employee<int>() { things = new List<int>() { 1, 2, 3 } };

            if (employeeTwo.things.Count > 0)
            {
                Console.WriteLine("This is a short example of the use of generic parameters, here are two examples.");
                Console.WriteLine("The first example is the \"generic\" handling of a string and secondly the handling of an integer!");
                Console.WriteLine();
                Console.WriteLine("Test Strings: " + employee.things[0] + " / " + employee.things[1]);
                Console.WriteLine("Test Integers: " + Convert.ToString(employeeTwo.things[0]) + "," + Convert.ToString(employeeTwo.things[1]) + ", and " + Convert.ToString(employeeTwo.things[2]));
                Console.WriteLine();
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();

            }
        }
    }
}
