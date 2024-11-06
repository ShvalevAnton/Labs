using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Book: IComparable <Book>
{
    String author;
    String title;
    int pages; 
    int year;

    public Book (String author, String title, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.pages = pages;
        this.year = year;
    }

    public void Show()
    {
        Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
    }
    //public override string ToString() => $"\nКнига:\n Автор: {author}\n Название: {title}\n Год издания: {year}\n {pages} стр.\n";

    int CompareTo(Book obj)
    {
        Book it = (Book)obj;
        if (this.year == it.year) return 0;
        else if (this.year > it.year) return 1;
        else return -1;
    }
}

namespace sortObjClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] arrBook = new Book [5]{ 
                new Book("Иванов", "У реки", 10, 2020), 
                new Book("Петров", "Городки", 20, 2021), 
                new Book("Степанов", "Космос", 30, 2022), 
                new Book("Сабитов", "Кино", 40, 2023),
                new Book("Лебедев", "Испытания", 50, 2024)
            }; 
            Array.Sort(arrBook);
            foreach (Book book in arrBook)
            {
                book.Show();
            }
        }
    }
}
