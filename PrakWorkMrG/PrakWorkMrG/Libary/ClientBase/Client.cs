using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakWorkMrG
{
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
        private BaseBook bBook;
        public Client (string name, string surname, int bornyear, int id)
            : base(name, surname, bornyear, id)
        {
            bBook = new BaseBook();
        }
        
    }
}
