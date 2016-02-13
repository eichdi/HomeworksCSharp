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
        private BaseBook book;

        //TODO
        public bool TakeBook(ClassBook bookArg)
        {
            if (book.RegistBook(bookArg))
            {
                book.GetByBook(bookArg).TakeBook();
                return true;
            }
            return false;
        }
        public bool GiveBook(ClassBook bookArg, )
        {
            if (book.RegistBook(bookArg))
            {
                book.GetByBook(bookArg).GiveBook();
                return true;
            }
            return false;
        }

    }
}
