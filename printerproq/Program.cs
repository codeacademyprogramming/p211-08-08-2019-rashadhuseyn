using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printerproq
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer newprinter = new Printer();
            newprinter.PrintOn += printOn;
            newprinter.PageLoaded += loaderPaper;
            newprinter.Filled += loaderink;
            newprinter.PrintOff += printOff;
            Console.WriteLine("Please enter printer name");
            newprinter.PrinterName = Console.ReadLine();
            Console.WriteLine("Please enter paper amount");
            newprinter.PageAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter ink amount");
            newprinter.CartricAmount = int.Parse(Console.ReadLine());
            Console.ReadKey();

        }
        public static void printOn()
        {
            Console.WriteLine("Printer has turn on");
        }
        public static void printOff()
        {
            Console.WriteLine("Printer has turn off");
        }
        public void pageCount(Printer item)
        {
            Console.WriteLine($"You have {item.PageAmount} paper");
        }
        public static void loaderPaper()
        {
            Console.WriteLine("Paper has been loaded");
        }
        public static void loaderink()
        {
            Console.WriteLine("Ink has been loaded");
        }
        public static void Inkamount(Printer item)
        {
            Console.WriteLine($"You have {item.CartricAmount}qr ink");
        }

        public class Printer
        {
            public string PrinterName {
                get { return PrinterName; }
                 set {
                    PrintOn();
                }
            }
            public decimal CartricAmount
            {
                get { return CartricAmount; }
                set
                {
                     Filled();                   
                }
            }
            public int PageAmount
            {
                get { return PageAmount; }
                set
                {
                    PageLoaded();
                }
            }

            public event Action PrintOn;
            public event Action PrintOff;
            public event Action PageFinished;
            public event Action Filled;
            public event Action InkFinished;
            public event Action Printing;
            public event Action PageLoaded;
           
        }
    }
}
