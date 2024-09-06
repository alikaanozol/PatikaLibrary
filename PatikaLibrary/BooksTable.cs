using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    public class BooksTable // Kitap nesnelerinin tanımlanması ||Identifying book objects
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }       // Özellikler Bookstable sınıfına aittir. Bookstable nesnesinin verilerini saklar. || Properties belong to the Bookstable class. It stores the data of the Bookstable object.
        public int NumberofPages { get; set; }
        public string Publisher { get; set; }

        public DateTime EntryTime;

        public BooksTable()
        { 
            EntryTime  = DateTime.Now;

        }         // Yapıcı Metotlar, nesneleri oluşturduğumuzda kullanılır.Nesnenin başlangıç değerini belirler. || Constructor Methods are used while creating objects. It determines the initial value of the object.
        public BooksTable(string name,string authorname,string authorsurname, int numberofpages,string publisher)
        {
            Name = name;
            AuthorName = authorname;
            AuthorSurname = authorsurname;
            NumberofPages = numberofpages;
            Publisher = publisher;
            EntryTime = DateTime.Now;

        }

        public void CreateBook()
        {
            Console.WriteLine($"Oluşturulan kitabımız {Name}, Kitabımızın yazarı {AuthorName} {AuthorSurname} ,Kitabımızın sayfa sayısı {NumberofPages} ve Yayınevimiz {Publisher} ");
        }

    }
}
