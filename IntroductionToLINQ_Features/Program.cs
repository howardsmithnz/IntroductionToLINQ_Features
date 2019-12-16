using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToLINQ_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(square(add(3,5)));

            var developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott"},
                new Employee { Id = 2, Name = "Chris"}
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            Console.WriteLine(developers.Count());
            foreach (var person in developers.Where(
                e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(person.Name);
            }
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
        }
    }
}
