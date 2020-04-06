using System;

namespace BoxingVsUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing -  o valor está vindo da heap

            int inteiro1 = 2;
            object objeto1 = inteiro1;

            Console.WriteLine("Object = {0}", objeto1);

            //Unboxing
            
            object objeto2 = 3;
            int inteiro2 = (int)objeto2;

            Console.WriteLine("Object = {0}", inteiro2);

        }
    }
}
