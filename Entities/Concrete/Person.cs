using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }

    }
}
//Proje amacı
//Bir kişi maske için başvurda bulunacak
//Mernisin Servisi kullanılarak bu durum kontrol edilecek
//Kişinin bilgileri doğru mu diye kontrol edilecek , doğruysa bir kod verecek o kod ile o kişi gidip maske alabilecek
//daha önce maske almışsa o kişi tekrar maske alamayacak

//şartlar
//1. daha önce maske almamış olmalı
//2. O kişi kimlik bilgilerini doğrulayabilmeli