using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string state;
            int postal;
            string country;

            firstName = "Khalid";
            lastName = "Hasan";
            birthDate = new DateTime(1995, 06, 21);
            addressLine1 = "944, Silicon Malancha,";
            addressLine2 = "Adabor, Rd 14,";
            city = "Dhaka";
            state = "Dhaka Central";
            postal = 1212;
            country = "Bangladesh";

            Console.WriteLine("Name: " + firstName + lastName);
            Console.WriteLine("Birth Date: " + birthDate);
            Console.WriteLine("Address: " + addressLine1 + " " + addressLine2 + " " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Postal: " + postal);
            Console.WriteLine("Country: " + country);






        }
    }
}
