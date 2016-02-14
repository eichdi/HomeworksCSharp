using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ClientBook : ClassBook
    {
        private DateTime startTime;
        private DateTime endTime;
        private int qtBook;
        private int qtLostBook;
        private bool lost;
        private bool received;

        public bool LostBook(int qtbook)
        {
            if (qtbook < this.qtBook)
            {
                this.qtLostBook =  qtbook;
                lost = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FoundLostBook(int qtbook)
        {
            if(lost == true)
            {
                if (qtLostBook == qtbook)
                {
                    lost = false;
                    received = true;
                    this.endTime = DateTime.Today;
                    //TODO



                    return true;
                }
                else
                {
                    if (qtLostBook > qtbook)
                    {
                        qtLostBook -= qtbook;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool ReceivBook()
        {
            if (lost == false)
            {
                received = true;
                endTime = DateTime.Today;
                ///TODO
                return true;
            }
            else
            {
                return false;
            }
        }
        public ClientBook(ClassBook book, int qtbook)
            : base (book)
        {
            this.qtBook = qtbook;
            startTime = DateTime.Today;
            lost = false;
            received = false;
        }

    }

