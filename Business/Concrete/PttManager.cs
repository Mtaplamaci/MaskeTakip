using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService; // personmanager i new ile nesne oluşturmak yerine interface ini kullanıyoruz 
        public PttManager(IApplicantService applicantService) //consturactor
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            PttManager pttManager = new PttManager(new ForeignerManager());   
           
            if (_applicantService.CheckPerson(person)) 
            {
             Console.WriteLine(person.FirstName + "için maske verildi ");   
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske Verilemedi ");
            }
        }
    }
}
