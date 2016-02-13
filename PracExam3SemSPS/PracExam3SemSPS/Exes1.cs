using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    abstract class AbstClassBook
    {
        void GiveBook();
        void TakeBook();
    }
    class ClassBook : AbstClassBook
    {
        private string name;
        private string author;
        private int inBib;
        private int onHead;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
        }

        public ClassBook(string name,string author, int inBib)
        {
            if (inBib!=0)
            {
                this.name = name;
                this.author = author;
                this.inBib = inBib;
                this.onHead = 0;
            }
            else
                throw new ArgumentException();
        }
        public void GiveBook()
        {
            if (inBib > 0)
            {
                onHead++;
                inBib--;
            }
            else throw new InvalidOperationException();
        }
        public void TakeBook()
        {
            if (onHead > 0)
            {
                onHead--;
                inBib++;
            }
            else throw new InvalidOperationException();
        }
    }
    class ProgBook : ClassBook
    {
        private string langprog; // В чем измеряется?
        public string Langprog
        {
            get
            {
                return langprog;
            }
        }
        public ProgBook(string langprog, string name,string author, int inBib)
            : base(name, author, inBib)
        {
            this.langprog = langprog;
        }
    }
    class HistoryBook : ClassBook
    {
        private string histPered;
        public string HistPered
        {
            
            get
            {
                return histPered;
            }
        }
        public HistoryBook(string histPered, string name, string author, int inBib)
            : base(name, author, inBib)
        {
            this.histPered = histPered;
        }

    }

    class Client
    {
        public delegate void ClientEventsHandler(ClassBook book);
        public event ClientEventsHandler GivenBook;
        public event ClientEventsHandler ReceivedBook;

    }
    class Libary
    {
        private ClassBook[] book;
        public ClassBook[] Book
        {
            get
            {
                return book;
            }
        }
        public bool AddBook(ProgBook bookArg)
        {
            try
            {
                List<ClassBook> listBook;
                if (bookArg != null)
                    listBook = book.ToList();
                else
                {
                    listBook = new List<ClassBook>();
                }
                listBook.Add(bookArg);
                this.book = listBook.ToArray();
                return true;
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
                List<ClassBook> listBook;
                if (book != null)
                    listBook = book.ToList();
                else
                {
                    listBook = new List<ClassBook>();
                }
                listBook.Add(bookArg);
                this.book = listBook.ToArray();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RegistBook(ClassBook bookArg)
        {
            foreach (ClassBook e in book)
            {
                if (e.Equals(bookArg))
                {
                    return true;
                }
            }
            return false;
        }
        public void TakeBook(ClassBook bookArg)
        {
            if (RegistBook(bookArg))
            {
                bookArg.TakeBook();
            }
        }
        public void GiveBook(ClassBook bookArg)
        {
            if (RegistBook(bookArg))
            {
                bookArg.GiveBook();
            }
        }

    }
}
