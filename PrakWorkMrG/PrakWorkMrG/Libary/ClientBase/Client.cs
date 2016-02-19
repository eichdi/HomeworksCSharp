using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IPerson
    {
        
    }

    class Person
    {
        private string name;
        private string surname;
        private int bornyear;
        private static List<int> registId = new List<int>();
        private int id;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public int BornYear
        {
            get
            {
                return bornyear;
            }
        }
        
        public Person(string name, string surname, int bornyear, int id)
        {
            if (!registId.Contains(id))
            {
                this.name = name;
                this.surname = surname;
                this.bornyear = bornyear;
                this.id = id;
                registId.Add(id);
            }
            else
            {
                throw new Exception();
            }
            
        }
    }
    class Client:Person
    {
        private List<ClientBook> cbook;
        public ClientBook[] Book
        {
            get
            {
                return cbook.ToArray();
            }
        }
        public ClientBook GetClientBook(ClassBook book)
        {
            foreach (ClientBook e in cbook)
            {
                if (e == book)
                {
                    return e;
                }
            }
            return null;
        }
        public Client (string name, string surname, int bornyear, int id)
            : base(name, surname, bornyear, id)
        {
            cbook = new List<ClientBook>();
        }
        public bool AddBook(BaseBook bbook, ClassBook book,int qt)
        {
            if (book != null && qt>0)
            {
                Book inBaseBook = bbook.GetByBook(book);
                if (inBaseBook != null && inBaseBook.Pop(qt))
                {
                    cbook.Add(new ClientBook(book, qt));
                    return true;

                }
                return false;
            }
            else
            {
                return false;
            }
        }
        
    }

