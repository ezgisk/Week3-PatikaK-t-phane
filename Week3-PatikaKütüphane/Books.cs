using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_PatikaKütüphane
{
    public class Books
    {
        //Properties
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageNumber{ get; set; }
        public string PublishingHouse { get; set; }
        public DateTime RegistrationDate { get; set; }

        //Defoult constructor
        public Books()
        {
            this.RegistrationDate = DateTime.Now;
         
        }
        //Paremeter constructor
        public Books(string bookName, string authorName,string authorSurname, int pageNumber,string publishingHouse)
        {
            BookName = bookName;   
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PageNumber = pageNumber;
            PublishingHouse = publishingHouse;
            RegistrationDate = DateTime.Now;
            

        }
        //Class: Benzer özelliklere ve davranışlara sahip nesneleri tanımlayan bir şablondur.

        //Property: Sınıf içinde tanımlanan, nesne verilerine erişim sağlayan değişkenlerdir.

        //New: Yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.

        //Constructor: Bir sınıfın nesnesi oluşturulduğunda otomatik olarak çağrılan ve başlangıç değerlerini atayan özel bir metottur.
    }
}
