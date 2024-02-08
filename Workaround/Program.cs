using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "AHMET";
            person1.LastName = "EREN";
            person1.DateOfBirthYear = 1997;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Osman";


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
