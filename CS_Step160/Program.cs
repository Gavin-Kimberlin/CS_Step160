using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step160
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Class1 classObj = new Class1();
            classObj.voidMethod(input1);
            classObj.outMethod(out input1);

            classObj.overloadMethod(20);
            classObj.overloadMethod(20, 41);

            Console.WriteLine(Class2.staticClassMethod("This is the static class"));

            Console.ReadLine();
        }
    }
}
