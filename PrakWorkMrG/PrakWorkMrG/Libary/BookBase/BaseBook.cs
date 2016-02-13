using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakWorkMrG
{
    public class BaseBook
    {
        private ClassBook[] bbook;

        public ClassBook[] Book
        {
            get
            {
                return bbook;
            }
        }


        public bool AddBook(ProgBook bookArg)
        {
            try
            {
                if (!RegistBook(bookArg))
                {
                    List<ClassBook> listBook;
                    if (bookArg != null)
                        listBook = bbook.ToList();
                    else
                    {
                        listBook = new List<ClassBook>();
                    }
                    listBook.Add(bookArg);
                    this.bbook = listBook.ToArray();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool AddBook(HistoryBook bookArg)
        {
            try
            {
                if (!RegistBook(bookArg))
                {
                    List<ClassBook> listBook;
                    if (bbook != null)
                        listBook = bbook.ToList();
                    else
                    {
                        listBook = new List<ClassBook>();
                    }
                    listBook.Add(bookArg);
                    this.bbook = listBook.ToArray();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Конструкторы
        public BaseBook()
        {
            bbook = null;
        }
        public BaseBook(ClassBook[] book)
        {
            this.bbook = book;
        }
        public static BaseBook SBaseBook(ClassBook[] book)
        {
            BaseBook bbook = new BaseBook(book);
            return bbook;
        }
        //

        public bool DeleteBook(ClassBook bookArg)
        {
            List<ClassBook> lBook = bbook.ToList();
            foreach (ClassBook e in lBook)
            {
                if (bookArg == e)
                {
                    lBook.Remove(e);
                    return true;
                }
            }
            return false;
        }

        public bool RegistBook(ClassBook bookArg)
        {
            return this.GetByBook(bookArg) != null;
        }
        public ClassBook GetByID(int id)
        {
            foreach (ClassBook e in bbook)
            {
                if (e.Book.ID == id)
                {
                    return e;
                }
            }
            return null;
        }
        public ClassBook GetByBook(ClassBook book)
        {
            foreach (ClassBook e in bbook)
            {
                if (e == book)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
