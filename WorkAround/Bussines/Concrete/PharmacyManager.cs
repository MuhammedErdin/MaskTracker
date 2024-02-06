﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkAround.Bussines.Abstract;
using WorkAround.Entities.Concrete;

namespace WorkAround.Bussines.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)//Constructor
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verilemedi");
            }
        }

    }
}
