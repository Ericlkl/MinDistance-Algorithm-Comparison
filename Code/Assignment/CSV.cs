using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CsvHelper;

namespace Assignment
{
    public class CSV
    {
        const int TimesOfTest = 60;

        public static void GenerateBasicOperationCSV()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "BasicOperation.csv");
            var records = new List<CSVRowForOP>();

            for(int i = 0; i <= 10000; i += 1000)
            {
                Console.WriteLine($"Testing on {i} Elements Size Array....");

                //  Create two Variable for recording the result that doing the Basic Operation test sixty times
                //  tempResultList is for MinDistance Method, tempResultList2 is for MinDistance2 Method
                var tempResultList = new List<long>();
                var tempResultList2 = new List<long>();

                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                for (int j = 0; j <= TimesOfTest; j++)
                {
                    tempResultList.Add(Test.MD1_BasicOperationsTest(i,rnd));
                    tempResultList2.Add(Test.MD2_BasicOperationsTest(i, rnd));
                }

                long MD1_AVG = tempResultList.Sum(item => item) / TimesOfTest;
                long MD2_AVG = tempResultList2.Sum(item => item) / TimesOfTest;

                records.Add(new CSVRowForOP
                {
                    Size = i,
                    MD1_AVG_BasicOP = MD1_AVG,
                    MD2_AVG_BasicOP = MD2_AVG
                });

            }

            Console.WriteLine("Generate AVG Basic Operations for Two Algorithm Completed !");
            Console.WriteLine("Generating CSV files....");
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
            Console.WriteLine("Success!");
        }

        public static void GenerateExecutionTimeCSV()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "AVG_Executiontime.csv");
            var records = new List<CSVRowForTime>();

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            // Testing 
            for (int i = 0; i <= 10000; i += 1000)
            {
                Console.WriteLine($"Testing on {i} Elements Size Array....");

                //  Create two Variable for recording the result that doing the Basic Operation test sixty times
                //  tempResultList is for MinDistance Method, tempResultList2 is for MinDistance2 Method
                var tempResultList = new List<long>();
                var tempResultList2 = new List<long>();

                for (int j = 0; j <= TimesOfTest; j++)
                {
                    tempResultList.Add(Test.MD1_ExecutionTimeTest(i, rand));
                    tempResultList2.Add(Test.MD2_ExecutionTimeTest(i, rand));
                };

                long MD1_AVG = tempResultList.Sum(item => item) / TimesOfTest;
                long MD2_AVG = tempResultList2.Sum(item => item) / TimesOfTest;

                records.Add(new CSVRowForTime
                {
                    Size = i,
                    MD1_AVG_Time = MD1_AVG,
                    MD2_AVG_Time = MD2_AVG
                });

            }

            // Writing CSV Files
            Console.WriteLine("Generate AVG Execution Time for Two Algorithm Completed !");
            Console.WriteLine("Generating CSV files....");
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
            Console.WriteLine("Success!");
        }

    }

    public class CSVRowForOP
    {
        public int Size { get; set; }
        public long MD1_AVG_BasicOP { get; set; }
        public long MD2_AVG_BasicOP { get; set; }
    }

    public class CSVRowForTime
    {
        public int Size { get; set; }
        public long MD1_AVG_Time { get; set; }
        public long MD2_AVG_Time { get; set; }
    }
}
