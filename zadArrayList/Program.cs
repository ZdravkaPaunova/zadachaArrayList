
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAList = new ArrayList();
            myAList.Add(10);
            myAList.Add("Hello");
            myAList.Add(3.14);
            myAList.Add(true);
            myAList.Add("World");
            myAList.Insert(1,100);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============================================");
            Console.WriteLine("        РЕЗУЛТАТИ ОТ ЗАДАЧАТА (ArrayList)     ");
            Console.WriteLine("=============================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"          Елемент на индекс 2: {myAList[2]}");
            Console.ResetColor();
            myAList.Remove(true);
            myAList.RemoveAt(3);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"          Индексът на 'Hello' е: {myAList.IndexOf("Hello")}");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(myAList.Contains(3.14) ? "           Да, 3.14 съществува!" : "          Не, 3.14 го няма.");
            Console.ResetColor();
            myAList.Clear();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine($"          Брой елементи след Clear():{myAList.Count}");
            Console.ResetColor();
        }
    }
}
