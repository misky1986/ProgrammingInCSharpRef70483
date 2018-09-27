using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Example3CreateDelegates
{
    public class CreateCustomDelegates
    {
        delegate int IntOperation(int a, int b);

        static int Add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract called");
            return a - b;
        }

        public void Run()
        {
            // Explicitly create the delegate
            IntOperation op = new IntOperation(Add);
            Console.WriteLine(op(2,2));

            // Delegate is created automatically from method
            op = Subtract;
            Console.WriteLine(op(2, 2));

            Console.ReadKey();
        }
    }
}
