using System;

namespace ConsoleApp13
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your Birthdate? YYYY, MM, DD");
            var person = new Person();
            person.Birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("You are {0} ", person.Age);

            
            
              
            
            
        }
    }
}