using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //global alanda bir değişken tanımlıyoruz daha sonra constructor içinde parametreyi o değişkene atıyoruz.
        private IApplicantService _applicantService; 
        
        //Tasarım deseni dependency Injection , Ptt Managerın bağımlı olduğu sınıf yerine onların Interface yazarız, fieldler _ ile yazılır
        //ben ppt manager olarak başka bir sınıfa ihtiyaç duyuyorum onun sınıfını newlemek yerine onun interface ini yazıyoruz.
        //ve diyoruz ki bu class ilk başladığında ihtiyaç duyuyoruz. Bu yapıya constructor yeni oluşturucu diyoruz

        public PttManager(IApplicantService applicantService)//Constructor
        {
            _applicantService = applicantService;
        }

        //Constructor MAnager ile aynı ismi alır, class oluştuğunda, yani Biz PttManager'ı Newlediğimiz 
        //zaman Constructor olan kısım çalışacak, bana IApplicantService bağımlıyım diyor ve ben oluşturulduğumda
        //bana parametre olarak bir adayService yani applicantService ver.
        //_applicantService = applicantService; ile de alt çizgili field ları contructor içinde onu set ederiz.


        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); //bir iş sınıfı başka bir iş sınıfını kullanırken
            //newliyorsa ileriye yönelik bir değişiklik talebi geldiğinde uygulama bir direnç gösterir
            //bu şekilde yazmak yerine bu sınıfa bağımlı olmamak için dependency Injection yaparız

            //PersonManager personManager = new PersonManager(new ForeignManager()); yabancılar için kullanıcam


            if (_applicantService.CheckPerson(person) == true)
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi!");
            }
        }
    }
}
//Maskeyi Ptt dağıtıyor
//eczane maskeyi tedarik edecek