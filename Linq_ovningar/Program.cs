using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ovningar
{
    class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Number { get; set; }

        }
        static void Main(string[] args)
        {
            // Consol.WriteL
            // hämtar en lista med data
            var employees = GetData();

            // gör övningarna i tur och ordning och skriv ut varje övning så man ser resultatet





            Console.ReadLine();

        }

        static List<Employee> GetData()
        {
            List<Employee> e = new List<Employee>();
            e.Add(new Employee() { Id = 1, FirstName = "Patrik", LastName = "Larsson", Number = 10 });
            e.Add(new Employee() { Id = 2, FirstName = "Matti", LastName = "Berg", Number = 13 });
            e.Add(new Employee() { Id = 3, FirstName = "Isabella", LastName = "Ryrå Landgren", Number = 16 });
            e.Add(new Employee() { Id = 4, FirstName = "Gheyath", LastName = "Al Hijazy", Number = 3 });
            e.Add(new Employee() { Id = 5, FirstName = "Dennis", LastName = "Börjesson", Number = 2 });
            e.Add(new Employee() { Id = 6, FirstName = "Robert", LastName = "Lindeberg", Number = 33 });
            e.Add(new Employee() { Id = 7, FirstName = "Andy Joacim", LastName = "Friberg", Number = 42 });
            e.Add(new Employee() { Id = 8, FirstName = "Khaldoun", LastName = "Alnezami", Number = 8 });
            e.Add(new Employee() { Id = 9, FirstName = "Jörgen", LastName = "Grönberg", Number = 31 });
            e.Add(new Employee() { Id = 10, FirstName = "Ali", LastName = "Saifo", Number = 15 });
            e.Add(new Employee() { Id = 11, FirstName = "Waseem", LastName = "Akhtar Soomro", Number = 17 });
            e.Add(new Employee() { Id = 12, FirstName = "Mouhammad", LastName = "Kharlboutli", Number = 12 });
            e.Add(new Employee() { Id = 12, FirstName = "", LastName = "Berg", Number = 3 });
            e.Add(new Employee() { Id = 12, FirstName = "Jonas", LastName = "", Number = 6 });
            e.Add(new Employee() { Id = 12, FirstName = "", LastName = "", Number = 36 });
            return e;
        }
    }
}
