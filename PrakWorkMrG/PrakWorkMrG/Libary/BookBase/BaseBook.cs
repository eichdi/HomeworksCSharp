using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BaseBook
    {
        private List<Book> bbook;

        public Book[] Book
        {
            get
            {
                return bbook.ToArray();
            }
        }

        public bool AddBook(Book book)
        {
            if (book != null && !RegistBook(book))
            {

                bbook.Add(book);
                return true;
            }
            else
                return false;
        }
        //Конструкторы
        public BaseBook()
        {
            bbook = null;
        }
        public BaseBook(Book[] book)
        {
            this.bbook = book.ToList();
        }
        public static BaseBook SBaseBook(Book[] book)
        {
            BaseBook bbook = new BaseBook(book);
            return bbook;
        }
        //

        public bool DeleteBook(Book bookArg)
        {
            
            foreach (Book e in bbook)
            {
                if (bookArg == e)
                {
                    bbook.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public bool LostBook(Book book, int qt = 1)
        {
            for (int i = 0; i < qt; i++)
            {
                if (!book.LostBook())
                {
                    return false;
                }

            }
            return true;
        }
        public bool RegistBook(Book bookArg)
        {
            return this.GetByBook(bookArg) != null;
        }
        public Book GetByID(int id)
        {
            foreach (Book e in bbook)
            {
                if (e.ID == id)
                {
                    return e;
                }
            }
            return null;
        }
        public Book GetByBook(Book book)
        {
            foreach (Book e in bbook)
            {
                if (e == book)
                {
                    return e;
                }
            }
            return null;
        }
    }

