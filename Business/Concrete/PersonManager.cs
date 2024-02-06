using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{ 
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson(Person person)//mernise bağlanıp kişi doğru mu diye kontrol edecek, tc no yoksa yabancı uyrukludur
        {
            //mernis kontrolü yapacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
 
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        } //bu veri doğruysa true dönecek
           
    }
}
//Manager ve Service benzer işler yapar
//Kullanıcıya maske verme işlemini burada yazarız  
//maske başvuru, kişi kaydı, kaç kişi maske aldı, kaç kişi almadı, daha önce maske almış mı
//encapsulation, Parametre ile classtan verileri tek bir parametre ile alma