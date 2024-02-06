using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
//durum olarak, ülkede vatandaş olmayan ama yaşayan insanlara içinde maske verilmesi durumu eklendiğinde
//ne yapmamız gerekli
//Interfaceler Metotların imzalarını tutarlar ve blokları yazılmaz, başındaki public kısmları da
//yazılımda bağımlılığı çözmede kullanılır. öncekinde her şey türkiye vatandaşı olmasına bağlıydı. PersonManager ve ayrıca Yabancılar içinde ayrı bir metot yazmak gerkirdi
//

//Interface ler, belirli metot imzlarını barındırılar, birbirinin alternatifini olan sistemlerin farklı imlemantasyon yapmalrını sağlarlar
//yani, yabancı uyrukluyu aynı metotları kullanarak fakat farklı kurallar ile kontrol, başvuru ve istenen işlemleri yaptırabiliriz.
//Aynı şekilde türk vatandaşı içinde aynı metotları kullanıp fakat içinde farklı kurallar koyarak işlemleri yaptırırız.
//interfaceler referans tutucudurlar, parametre olarak constructor da verildiğinde hem PersonManagerı türk vatandaşı hemde ForeignerManagerın referansını tutar
//bu şeki