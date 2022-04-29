using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Lambda Expressions");
            List<Person> list = new List<Person>();
            PersonDataManagement.AddPersonDetails(list);
            PersonDataManagement.DisplayPersonDetails(list);


        }

       
    }
    
}
