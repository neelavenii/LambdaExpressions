using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class PersonDataManagement
    {
        public static void AddPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kavya", Address = "bnglr", Age = 45 });
            list.Add(new Person() { SSN = 2, Name = "Charitha", Address = "hyd", Age = 70 });
            list.Add(new Person() { SSN = 3, Name = "Neelu", Address = "Jmd", Age = 32 });
            list.Add(new Person() { SSN = 4, Name = "Sree", Address = "Kadapa", Age = 16 });
            list.Add(new Person() { SSN = 5, Name = "Aasritha", Address = "Goa", Age = 63 });
            list.Add(new Person() { SSN = 6, Name = "Suman", Address = "Chennai", Age = 36 });
            list.Add(new Person() { SSN = 1, Name = "Karthik", Address = "Ap", Age = 14 });

        }
        public static void DisplayPersonDetails(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);

            }
            Console.ReadLine();
        }
    }
}
