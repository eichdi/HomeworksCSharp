using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace PracticalWork4Main
{
    class Program
    {
        public static string pathexefile;
        //wtf
        [DllImport("User32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowsName);

        [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        internal static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        const UInt32 WM_CLOSE = 0x0010;

        //Class for correct input int and double 
        class ConsoleInput
        {
            public static int Int (string res=null){
                if(res==null)
                    res = Console.ReadLine();
                int result;
                try
                {
                    result = Convert.ToInt32(res);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректные данные");
                    return ConsoleInput.Int();
                }
                return result;
            }
            public static double Double(string res=null){
                if (res == null)
                    res = Console.ReadLine();
                double result;
                try
                {
                    result = Convert.ToDouble(res);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректные данные");
                    return ConsoleInput.Double();
                }
                return result;
            }
        }

        //metod for say to user about exit
        public static bool end()
        {
            Console.WriteLine("Завершить работу?  \n 1-Да \n 2-Нет");
            switch (ConsoleInput.Int())
            {
                case 1: return true ;
                case 2: return false;
                default:
                    Console.WriteLine("Некорректные данные");
                    return end();
            }
        }
        //start new process with arguments
        public static void newproc(string parameters)
        {
            Thread.Sleep(3000);
            Process a = new Process();
            a.StartInfo = new ProcessStartInfo(pathexefile, parameters);
            if (a.Start())
                //Process.Start(pathexefile, parameters);
            a.WaitForExit(120000);

        }
        //metod for start repead func
        public static void startrepeads()
        {
            
            Console.WriteLine("Введите количество повторений вычисления функции \n y = cos(x)/(sqrt(a) + e^x)");
            int NumOfRepeads = ConsoleInput.Int();
            string parameters = NumOfRepeads.ToString();
            if (NumOfRepeads > 0)
            {
                newproc(parameters);
                for (int i = 1; i <= NumOfRepeads; i++)
                {
                    IntPtr windowPtr = FindWindowByCaption(IntPtr.Zero, i.ToString());
                    if (windowPtr != IntPtr.Zero)
                    {
                        SendMessage(windowPtr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    }
                }
            }
        }
        //metod for calculate function 
        public static void calcs()
        {
            Console.WriteLine("y = cos(x)/(sqrt(a) + e^x)");
            Console.Write("Введите x=");
            double x = ConsoleInput.Double();
            Console.Write("Введите a=");
            double a = ConsoleInput.Double();
            Console.WriteLine("Результат: " + Math.Cos(x) / (Math.Sqrt(a) + Math.Pow(Math.E, x)));
        }

        static void Main(string[] args)
        {
            pathexefile = Console.Title;
            //Console.SetWindowPosition(0, 0);
                if (args.Length > 0)
                {
                    int NumOfRepeads = ConsoleInput.Int(args[0]);
                    Console.Title = NumOfRepeads.ToString();
                    calcs();
                    NumOfRepeads--;
                    if (NumOfRepeads > 0)
                        newproc(NumOfRepeads.ToString());
                    else
                    {
                        Console.ReadKey();
                        var hWnd = FindWindow(null, "Main");
                        SetForegroundWindow(hWnd);
                    }
                }
                else
                {
                    Console.Title = "Main";
                    Console.WriteLine("Практическая работа №4");
                    Console.WriteLine("Макетное представление диалогового взаимодействия на основе конструкции");
                    Console.WriteLine("\"DO WHILE\"");
                    Console.WriteLine("Разработчик Хайрутдинов Самат Зуфарович, 2 курс, группа - 09-411\n");
                    bool noend = true;
                    do
                    {
                        Console.WriteLine("Начать работу?  \n 1-Да \n 2-Нет");
                        switch (ConsoleInput.Int())
                        {
                            case 1:
                                startrepeads();
                                noend = !end();
                                Console.Clear(); break;
                            case 2:
                                noend = !end(); break;
                            default:
                                Console.WriteLine("Некорректные данные");
                                break;
                        }
                    } while (noend);
                }

        }
    }
}
