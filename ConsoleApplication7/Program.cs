using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages msg = new Messages();
            msg.DisplayType(5);
            msg.DisplayType(true);
            msg.DisplayType("tsa");
            msg.DisplayType('b');
            Console.ReadLine();
        }
    }

    public class Messages
    {
        public void DisplayType(int a)
        {
            Console.WriteLine("An int value has been passed");
        }

        public void DisplayType(string a)
        {
            Console.WriteLine("A string value has been passed");
        }

        public void DisplayType(char a)
        {
            Console.WriteLine("A char value has been passed");
        }

        public void DisplayType(bool a)
        {
            Console.WriteLine("A bool value has been passed");
        }
    }
}
