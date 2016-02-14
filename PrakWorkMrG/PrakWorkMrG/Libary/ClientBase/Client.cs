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
            this.name = name;
            this.surname = surname;
            this.bornyear = bornyear;
            this.id = id;
        }
    }
    class Client:Person
    {
        List<ClientBook> cbook;
        public ClientBook[] Book
        {
            get
            {
                return cbook.ToArray();
            }
        }
        public Client (string name, string surname, int bornyear, int id)
            : base(name, surname, bornyear, id)
        {
            cbook = new List<ClientBook>();
        }
        public bool AddBook(ClassBook book,int qt)
        {
            if (book != null && qt>0 && book.Amout>=qt)
            {
                cbook.Add(new ClientBook(book,qt));
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

