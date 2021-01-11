using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1John.Classes
{
    class Customer : Person
    {
        public override void ShowDetailedPerson()
        {
            Console.WriteLine("This person is a Customer");
        }
    }
}
