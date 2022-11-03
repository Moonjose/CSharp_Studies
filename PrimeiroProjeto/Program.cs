using System;
using System.Globalization;


namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
 
            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employee id that will have salary increase:");
            int empId = int.Parse(Console.ReadLine());
           
            Employee empFound = list.Find(x => x.Id == empId);
            if(empFound != null) {
                Console.WriteLine("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empFound.increaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }
            
            Console.WriteLine("Updated list of employees:");

            foreach(Employee emp in list) {
                Console.WriteLine(emp);
            }
        }
    }
}