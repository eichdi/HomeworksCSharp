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
            if (qtbook < this.qtBook && received==false)
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
        public bool FoundLostBook(BaseBook bbook, int qtbook)
        {
            if(lost == true)
            {
                if (qtLostBook == qtbook)
                {
                    
                    Book temp = bbook.GetByBook(this);
                    if (temp.Pop(qtbook))
                    {
                        lost = false;
                        received = true;
                        this.endTime = DateTime.Today;
                        return true;
                    }
                    else
                        return false;

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

        public bool ReceivBook(BaseBook bbook, int qtBook)
        {
            if (lost == false && qtBook==this.qtBook)
            {
                Book inLibBook = bbook.GetByBook(this);
                
                if (inLibBook != null && inLibBook.Push(qtBook))
                {
                    
                }
                received = true;
                endTime = DateTime.Today;
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

