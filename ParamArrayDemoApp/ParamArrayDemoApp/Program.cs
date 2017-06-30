using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraywithParamDemoApp
{
    class Program
    {
        public void Run()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            Console.WriteLine("Calling with three integers.");
            DisplayVals(a, b, c);

            Console.WriteLine("Calling with four integers");
            DisplayVals(1, 2, 3, 4);

            Console.WriteLine("\nCalling with an array of four integers");
            int[] explicitArr = new int[4] { 8, 9, 10, 11 };
            DisplayVals(explicitArr);
        }

        //takes a variable number of integers

        public void DisplayVals(params int[] intVals)
        {
            foreach (var item in intVals)
            {
                Console.WriteLine("DisplayVals {0}", item);
            }
        }
        //sta means single thread application
        [STAThread]
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadLine();
        }
    }
}
