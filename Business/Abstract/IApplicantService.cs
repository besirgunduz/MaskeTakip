using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IApplicantService
    {
        void ApplyForMask(Person person); //Maske için başvur

        List<Person> GetList();

        bool CheckPerson(Person person); //Kişiyi kontrol et.
    }
}
