using Core.Aspects;
using System;

namespace Entities
{
    public interface IEmployee
    {
        void Add(int id, string firstname, string lastname);
        void Update(int id, string firstname, string lastname);

    }
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        [DefensiveProgrammingAspect(Priority =1)]
        [InterceptionAspect(Priority =2)]
        public virtual void Add(int id, string firstname,
            string lastname)
        {
            Console.WriteLine("Added.");
        }

        [DefensiveProgrammingAspect(Priority = 1)]
        [InterceptionAspect(Priority = 2)]
        public virtual void Update(int id, string firstname,
            string lastname)
        {
            Console.WriteLine("Updated.");
        }
    }
}
