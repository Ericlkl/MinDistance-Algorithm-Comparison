using System;
using System.Linq;

namespace Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Generate CSV File Related to Basic Operations ...");
            CSV.GenerateBasicOperationCSV();
            //Console.WriteLine("Generate CSV File Related to Execution Time ....");
            //CSV.GenerateExecutionTimeCSV();

        }
    }
}
