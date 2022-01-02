using System;

namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstname,
            string lastname)
        {
            //Console.WriteLine("Method body start!");
            //Console.WriteLine($"\t {"Id",-15} : {id}");
            //Console.WriteLine($"\t {"FirstName",-15} : {firstname}");
            //Console.WriteLine($"\t {"LastName",-15} : {lastname}");
            //Console.WriteLine("Method body end!");
            Console.WriteLine("Added.");


        }
    }
}
