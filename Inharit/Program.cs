using static System.Console;
namespace Inharit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            Human h = new Human("hhh", "h",DateTime.Now);
            Employee e = new Employee("eee", "e",100, DateTime.Now);
            h.Show();
            e.Print();

            Human[] h2 =
            {
                e,
                new Employee("Employee2", "E2", 100, DateTime.Now),
                new Employee("Employee3", "E3", 100, DateTime.Now),
            };

            foreach (Human hum in h2)
            {
                hum.Show();
            }
        }
    }
}
