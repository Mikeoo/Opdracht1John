using Opdracht1John.Classes;

namespace Opdracht1John
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //System.Console.WriteLine("\nTest override");
            //System.Console.WriteLine("----------");

            //Person Mike = new Person();
            //Mike.DescribePerson();
            //System.Console.WriteLine("----------");

            //Customer Maaike = new Customer();
            //Maaike.DescribePerson();
            //System.Console.WriteLine("----------");

            //Employee Verkoper1 = new Employee();
            //Verkoper1.DescribePerson();
            //System.Console.WriteLine("----------");

            

            Customer Klant = new Customer();
            Person Kees = Klant;
            Kees.DescribePerson();
            System.Console.WriteLine("----------");
 

            Customer c = new Customer();
            Person p = c;
            var Jan = (Customer)p;
            //Customer Jan = (Customer)p;
            Jan.DescribePerson();
            System.Console.WriteLine("----------");


            Employee w = new Employee();
            Person ww = w;
            ww.DescribePerson();
            System.Console.WriteLine("----------");

            Person a = new Person();
            //Customer pp = (Customer)a;
            //pp.DescribePerson();
        }
    }
}