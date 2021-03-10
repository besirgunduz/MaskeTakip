using Business.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.NationalIdentity = 55879356390;
            person.FirstName = "Beşir2";
            person.LastName = "Gündüz";
            person.DateOfBirthYear = 1993;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }
    }
}
