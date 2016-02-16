using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Описана книга

private class BookTitle
{
    private int id;
    private static List<int> idRegist= new List<int>();
    private string name;
    private string author;

    public string Author
    {
        get
        {
            return author;
        }
    }
    public int ID
    {
        get
        {
            return id;
        }
    }
    public static override bool operator ==(BookTitle a, BookTitle b)
    {
        return a.ID == b.ID;
    }
    public string Name
    {
        get
        {
            return name;
        }
    }
    public BookTitle(string name, string author, int id)
    {
        if (!idRegist.Contains(id))
        {
            this.name = name;
            this.author = author;
            this.id = id;
            idRegist.Add(id);
        }
        else
        {
            throw new Exception();
        }
        
    }
}

interface IClassBook
{
    void Pop(Client client);
    void Push(Client client);
}

class ClassBook : BookTitle
{
    private int amount;

    public ClassBook(string name, string author,int id, int amount):
        base (name, author,id)
    {
        this.amount=amount;
    }
    public ClassBook(ClassBook book):
        base(book.Name, book.Author, book.ID)
    {
        this.amount = book.amount;
    }
    public int Amout
    {
        get
        {
            return amount;
        }
    }
    public bool LostBook()
    {
        if (amount > 0)
        {
            amount--;
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Book:ClassBook,IClassBook
{
    private int inlib;
    public int InLib
    {
        get
        {
            return inlib;
        }
    }
    public Book(string name, string author,int id, int amount, int inlib):
        base(name, author,id, amount)
    {
        this.inlib = inlib;
    }
    public bool Pop(int qt)
    {
        if (inlib >= qt)
        {
            inlib -= qt;
            return true;
        }
        return false;
    }
    public bool Push(int qt)
    {
        if (qt > Amout - inlib)
        {
            inlib += qt;
            return true;
        }
        return false;
    }
    public bool GiveBook(BaseBook bbook, Client client, int qt)
    {
        return client.AddBook(bbook, this, qt);
    }
    public bool TakeBook(BaseBook bbook, Client client, int qt)
    {
        ClientBook book = client.GetClientBook(this);
        if (book != null)
        {
            book.ReceivBook(bbook, qt);
            return true;
        }
        else
        {
            return false;
        }
    }


}







//Описан вид книги
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
    //public ProgBook(string langprog, string name, string author, int summ, int id)
    //    : base(name, author, summ, id)
    //{
    //    this.langprog = langprog;
    //}
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
    public HistoryBook(string histPered, string name, string author, int summ, int id)
        : base(name, author, summ, id)
    {
        this.histPered = histPered;
    }

}


//class Client
//{
//    public delegate void ClientEventsHandler(ClassBook book);
//    public event ClientEventsHandler GivenBook;
//    public event ClientEventsHandler ReceivedBook;

//}


 
