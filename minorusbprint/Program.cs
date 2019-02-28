using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace minorusbprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string printerName = args[0];
            string filename = args[1];
            Console.WriteLine(printerName);
            Console.WriteLine(filename);
            //FileStream fs = new FileStream(filename, FileMode.Open);
            Console.WriteLine(RawPrinterHelper.SendFileToPrinter(printerName, filename));
            
        }
    }
}
