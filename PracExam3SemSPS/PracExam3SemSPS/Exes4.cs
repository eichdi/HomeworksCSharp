using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    static class Check
    {
        public static bool IsRusLetter(char a)
        {
            return a >= 'а' && a <= 'я';
        }
        public static bool IsNumLetter(char a)
        {
            return a >= '0' && a <= '9';
        }
    }
    class Transport
    {
        private string gosNum;
        private static int maxid = -1;
        private bool inPark=true;
        private int idVod;
        public string GosNum
        {
            get
            {
                return gosNum;
            }
        }
        public bool InPark
        {
            get
            {
                return inPark;
            }
            set
            {
                inPark = value;
            }
        }
        private bool IsGosNum(string gosNum)
        {
            return (Check.IsRusLetter(gosNum[0]) && Check.IsNumLetter(gosNum[1]) && Check.IsNumLetter(gosNum[2]) && Check.IsNumLetter(gosNum[3]) && Check.IsRusLetter(gosNum[4]) && Check.IsRusLetter(gosNum[5]) && gosNum.Length == 6);
        }
        public Transport(string gosNum, int id = -1)
        {
            if (IsGosNum(gosNum)) 
            {
                this.gosNum = gosNum;
                if (id == -1)
                {
                    maxid++;
                    idVod = maxid;
                }
                else
                {
                    this.idVod = id;
                }
            }
            else
                throw new ArgumentException("Wrong gos Number");
        }
        public int ID
        {
            get
            {
                return idVod;
            }
        }
    }
    class FreightTransport : Transport
    {
        private double totalDisp; // В чем измеряется?
        public double TotalDisp
        {
            set
            {
                totalDisp = value;
            }
            get
            {
                return totalDisp;
            }
        }
        public FreightTransport(double totalDisp, string gosNum) : base(gosNum)
        {
            TotalDisp = totalDisp;
        }
    }
    class PassengerTransport : Transport
    {
        private double loadCap;
        public double LoadCap
        {
            set
            {
                loadCap = value;
            }
            get
            {
                return loadCap;
            }
        }
        public PassengerTransport(double loadCap, string gosNum)
            : base(gosNum)
        {
            LoadCap = loadCap;
        }

    }
    class CarPark
    {
        private Transport[] transport;
        public bool AddTransport(FreightTransport trensport)
        {
            try
            {
                List<Transport> listTrans;
                if (transport != null)
                    listTrans = transport.ToList();
                else
                {
                    listTrans = new List<Transport>();
                }
                listTrans.Add(trensport);
                this.transport = listTrans.ToArray();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddTransport(PassengerTransport trensport)
        {
            try
            {
                List<Transport> listTrans;
                if(transport!=null)
                     listTrans = transport.ToList();
                else{
                    listTrans = new List<Transport>();
                }
                listTrans.Add(trensport);
                this.transport = listTrans.ToArray();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Transport SearchCar(string gosNum)
        {
            foreach (Transport e in transport)
            {
                if (e.GosNum == gosNum)
                {
                    return e;
                }
            }
            return null;
        }
        public bool Pass(FreightTransport trensport)
        {
            if (transport != null)

            foreach (Transport e in transport)
            {
                if (e == trensport || trensport.GosNum==e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=false)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = true;
                    return true;
                }
            }
            return false;
        }
        public bool Pass(PassengerTransport trensport)
        {
            if (transport != null)

            foreach (Transport e in transport)
            {
                if (e == trensport || trensport.GosNum == e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=false)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = true;
                    return true;
                }
            }
            return false;
        }
        public bool Pass(string gosNum)
        {
            if (transport != null)

            foreach (Transport e in transport)
            {
                if (gosNum == e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=false)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = true;
                    return true;
                }
            }
            return false;
        }
        public bool LetGo(string gosNum)
        {
            if (transport != null)

            foreach (Transport e in transport)
            {
                if (gosNum == e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=true)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = false;
                    return true;
                }
            }
            return false;
        }
        public bool LetGo(FreightTransport trensport)
        {
            if (transport != null)

            foreach (Transport e in transport)
            {
                if (e == trensport || trensport.GosNum==e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=true)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = false;
                    return true;
                }
            }
            return false;
        }
        public bool LetGo(PassengerTransport trensport)
        {
            if (transport!=null)
            foreach (Transport e in transport)
            {
                if (e == trensport || trensport.GosNum == e.GosNum) //не знаю как лучше
                {
                    //if(e.InPark!=true)
                    //{
                    //    throw new ArgumentException();
                    //    return false; 
                    //}
                    e.InPark = false;
                    return true;
                }
            }
            return false;
        }
    }
}
