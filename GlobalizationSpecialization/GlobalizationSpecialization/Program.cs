using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationSpecialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                FirstName = "Tatevik",
                LastName = "Aghasaryan",
                Course = new TrainingCourse() { Name = "C#" },
                Email = "tatevikaghasaryan@gmail.com"
            };

            EmailContact emailContact = new EmailContact(student);
            EmailingList emailingList = new EmailingList();
            emailingList.Add(emailContact);

            TaxiDriver taxiDriver = new TaxiDriver()
            {
                FirstName = "Poghos",
                LastName = "Poghosyan",                
            };
            Console.WriteLine(student);
            Console.WriteLine(taxiDriver.FullName);

            Console.ReadKey();
            
        }
    }
}
