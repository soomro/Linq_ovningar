using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ovningar
{
    static class Program
    {
        public static void Main(string[] args)
        {
            string space = "\n\n\n\n";
            List<Employee> employees = null;

            // Consol.WriteL
            // hämtar en lista med data
            employees = GetData();

            // gör övningarna i tur och ordning och skriv ut varje övning så man ser resultatet
            


            if (!IsNullOrEmpty(employees))
            {
                //// E:01  
                //// 
                Console.WriteLine("{0} E:01", space);
                foreach (Employee e in employees)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }


                //// E:02  
                Console.WriteLine("{0} E:02", space);
                //// 
                var query2 = from Employee in employees
                            orderby (Employee.FirstName)
                            select Employee;
                foreach (Employee e in query2)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }

                //// E:03  
                Console.WriteLine("{0} E:03", space);
                //// 
                var query3 = from Employee in employees
                        orderby (Employee.FirstName)
                        select Employee;
                foreach (Employee e in query3)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }

                //// E:04  
                Console.WriteLine("{0} E:04", space);
                //// 
                var query4 = employees.OrderBy(e => e.FirstName).Skip(10);
                foreach (Employee e in query4)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }

                //// E:05  
                Console.WriteLine("{0} E:05", space);
                //// 
                var query5 = from e in employees
                             where e.FirstName == "Where"
                             select e;

                foreach (Employee e in query5)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }

                //// E:06  
                Console.WriteLine("{0} E:06", space);
                //// 
                var query6 = from e in employees
                             where e.LastName == "Where"
                             select e;

                foreach (Employee e in query6)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.FirstName, e.LastName, e.Number);
                }


                Console.ReadLine();

            }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Number { get; set; }
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

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }

    }
}
