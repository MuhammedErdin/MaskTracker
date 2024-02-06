using System;
using WorkAround.Bussines.Concrete;
using WorkAround.Entities.Concrete;

namespace WorkAround.MaskeTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Muhammed";
            person1.LastName = "Erdin";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 12345678910;

            Person person2 = new Person();
            person2.FirstName = "Engin";
            person2.LastName = "Demiroğ";
            person2.DateOfBirthYear = 1985;
            person2.NationalIdentity = 12345678910;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager());
            pharmacyManager.GiveMask(person2);
        }
    }
}