using System.ComponentModel;

/*
 * Fredrik Nellbeck
 * Systemutveckling.NET med AI-kompetens
 * NET.23 OOP
*/
namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "Arne", "Male", 10);
            Employee employee2 = new Employee(102, "Amanda", "Female", 40000);
            Employee employee3 = new Employee(103, "Bettan", "Undefined", 0);
            Employee employee4 = new Employee(104, "Ernst", "Male", 45999);
            Employee employee5 = new Employee(105, "Åsa", "Female", 50000);

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);
            //stack list that adds diffrent items.

            foreach (var employees in employeeStack) 
            {
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employees.Id} - {employees.Name} - {employees.Gender} - {employees.Salary}");
            } // foreach that writes out everything in the stack list.
            
            Console.WriteLine("-------------------------");

            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            } // pops the whole stack list, writes out what's on top of the stack and then removes it.

            Console.WriteLine("-------------------------");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);
            // pushes items into the list again.

            int whileCounter = 0;

            while (whileCounter < 2)
            {
                var employee = employeeStack.Peek();
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                whileCounter++;
            } // while loop that peeks on what's on the top of the stack 2 times.

            Console.WriteLine("-------------------------");
            
            var employeeArray = employeeStack.ToArray();
            if (employeeStack.Contains(employeeArray[2]))
            {
                Console.WriteLine($"Employee ID {employeeArray[2].Id} found in stack.");
                
            }
            // makes the stack list to an array and checks if array number 2 exist and writes out the id of it aswell.
            Console.WriteLine("-------------------------");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exist in the list.");
            }
            else 
            {
                Console.WriteLine("Employee2 object not found in the list.");
            } // if statment that checks if item number 2 exist in the list

            Console.WriteLine("-------------------------");

            var employeeGender = employeeList.Find(x => x.Gender == "Male");
            Console.WriteLine($"{employeeGender.Id} - {employeeGender.Name} - {employeeGender.Gender} - {employeeGender.Salary}");
            // writes out the first items in the list with 'male' in it.

            Console.WriteLine("-------------------------");

            var employeeGenderAll = employeeList.FindAll(x => x.Gender == "Male");
            foreach (var item in employeeGenderAll)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Gender} - {item.Salary}");
            } // writes out all the items in the list with 'male' in it.
        }
    }
}