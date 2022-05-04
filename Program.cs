using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    internal class Program
    {
        int x, y;
        public Program(int a, int b)
        {
            x = a;
            y = b;
        }

        public Program(Program obj1, Program obj2)
        {
            x=obj1.x;
            y=obj2.y;
        }

        public void Display()
        {
            Console.WriteLine("Value of X = {0}  and Y = {1}\n", x, y);
        }
        static void Main(string[] args)
        {
            Program obj=new Program(10, 20);
            obj.Display();
            Program obj1=new Program(obj.y, obj.x);
            obj1.Display();
            Console.ReadLine();
        }
    }
}
