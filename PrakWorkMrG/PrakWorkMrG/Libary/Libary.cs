using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakWorkMrG
{


    //Описана вся библиотека
    class Libary
    {
        private ClientBase[] client;
        private BaseBook[] book;
        //TODO
        public bool TakeBook(ClientBase ClientBase)
        {
            Client a =new Client("name1","name2",1996,1);
            Book book = new Book ("nameb","nameauthor", 1, 3 ,3);
            BaseBook bb = new BaseBook();
            bb.AddBook(book);
            a.AddBook(bb,book,1);
            return false;
        }
        public bool GiveBook(ClassBook bookArg, )
        {
            
            return false;
        }

    }
}
