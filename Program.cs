using System;
using I___O_PUT_inNet.models;

namespace I___O_PUT_inNet
{
    class Program
    {
        static void Main(string[] args)
        {

            myClass myc = new myClass();

            var SomeAnonymous = new
            {
                Number = 123,
                Name = "thm"
            };

            System.Console.WriteLine(SomeAnonymous);
            System.Console.WriteLine(myc);

        }
    }
}
