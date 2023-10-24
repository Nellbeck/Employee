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

            foreach (var employees in employeeStack) 
            {
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employees.Id} - {employees.Name} - {employees.Gender} - {employees.Salary}");
            }
            
            Console.WriteLine("-------------------------");

            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            }
            Console.WriteLine("-------------------------");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            int whileCounter = 0;

            while (whileCounter < 2)
            {
                var employee = employeeStack.Peek();
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                whileCounter++;
            }

            Console.WriteLine("-------------------------");

            var employeeArray = employeeStack.ToArray();
            if (employeeStack.Contains(employeeArray[2]))
            {
                Console.WriteLine($"Employee ID {employeeArray[2].Id} found in stack.");
            }

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
            }

            Console.WriteLine("-------------------------");

            var employeeGender = employeeList.Find(x => x.Gender == "Male");
            Console.WriteLine($"{employeeGender.Id} - {employeeGender.Name} - {employeeGender.Gender} - {employeeGender.Salary}");

            Console.WriteLine("-------------------------");

            var employeeGenderAll = employeeList.FindAll(x => x.Gender == "Male");
            foreach (var item in employeeGenderAll)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Gender} - {item.Salary}");
            }
        }
    }
}