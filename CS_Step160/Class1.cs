using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step160
{
    class Class1
    {
        public void voidMethod(int input1)
        {
            int output = input1 / 2;
            Console.WriteLine(input1 + " \u00F7 2 = " + output);
        }

        public void outMethod(out int input1)
        {
            Console.WriteLine("Enter another number:");
            input1 = Convert.ToInt32(Console.ReadLine());
            int output = input1 * 10;
            Console.WriteLine(input1 + " x 10 = " + output);
        }

        public void overloadMethod(int input1)
        {
            int output = input1 * input1;
            Console.WriteLine(input1 + "^2 = " + output);
        }

        public void overloadMethod(int input1, int input2)
        {
            int output = input1 * input2;
            Console.WriteLine(input1 + " x " + input2 + " = " + output);
        }
    }
}
