using PatikaLibrary;
using System.Xml.Linq;

BooksTable book = new BooksTable(); // BooksTable sınıfından yeni bir nesne oluşturuyoruz. || We create a new object from the BooksTable class.
book.Name = "Aylin";
book.AuthorName = "Ayşe";
book.AuthorSurname = "Kulin";
book.NumberofPages = 398;
book.Publisher = "Remzi Kitabevi";
book.CreateBook();

Console.WriteLine("--------------------------");

BooksTable book2 = new BooksTable("Sefiller","Victor","Hugo",1724,"Can Kitabevi");
book2.CreateBook();




