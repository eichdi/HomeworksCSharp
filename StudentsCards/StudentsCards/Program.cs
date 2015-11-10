using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCards
{
    class Turnstile
    {
        private BaseCards cards;
        public Turnstile(BaseCards cards)
        {
            this.cards = cards;
        }
        public bool check(Card card)
        {
            return cards.check(card);
        }
    }
    class BuildingKFU
    {
        private string name;
        private string address;
        Turnstile[] tur;
        public BuildingKFU(Turnstile[] tur, string name, string address)
        {
            this.tur = tur;
            this.name = name;
            this.address = address;

        }
        public bool check(Card card)
        {
            for (int i = 0; i < tur.Length; i++)
            {
                if (tur[i].check(card))
                {
                    return true;
                }
            }
            return false;
        }

    }
    class BaseCards
    {
        private Card[] cards;
        public BaseCards(Card[] cards)
        {
            this.cards = cards;
        }
        public bool check(Card card)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].ID == card.ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Card
    {
        private int id;
        public int ID
        {
            get
            {
                return ID;
            }
        }
        public Card(int id)
        {
            this.id = id;
        }
    }
    class Studetns
    {
        public string name1;
        public string name2;
        public string name3;
        public Card card;
        public Studetns(int id, string name1, string name2, string name3)
        {
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            card = new Card(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
