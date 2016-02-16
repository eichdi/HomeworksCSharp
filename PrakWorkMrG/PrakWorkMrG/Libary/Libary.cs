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
        private ClientBase client;
        private BaseBook book;
        public ClientBase ClientBase
        {
            get
            {
                return client;
            }
        }
        public BaseBook BaseBook
        {
            get
            {
                return book;
            }
        }

    }
}
