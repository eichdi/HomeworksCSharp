using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    class Program
    {
        //первая практическа Георгиева В.О.
        static void Main(string[] args)
        {
            Libary libary = new Libary();
            ProgBook pbook=null;
            HistoryBook hbook=null;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите язык прог, имя книги, и автора через новую строку");
                pbook = new ProgBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), 10);
                libary.AddBook(pbook);
                Console.WriteLine("Введите исторический приод, имя книги, и автора через новую строку");
                hbook = new HistoryBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), 10);
                libary.AddBook(pbook);
            }
            libary.GiveBook(pbook);
            libary.TakeBook(pbook);
            ClassBook[] books = libary.Book;
            
            
        }
    }
}
