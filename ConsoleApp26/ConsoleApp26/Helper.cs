using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Helper
    {
        public static void Print(object obj)
        {
            string text = obj as string;
            foreach (var item in text)
            {
                Console.Write(item);
                Thread.Sleep(100);
            }
        }
    }
}
