using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1John.Classes
{
    class Person
    {
        public void DescribePerson()
        {
            Console.WriteLine("This is the person decription:");
            ShowDetailedPerson();
        }

        public virtual void ShowDetailedPerson()
        {
            Console.WriteLine("A person is a Customer or Employee");
        }
    }
}
