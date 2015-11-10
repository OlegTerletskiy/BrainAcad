using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeForFirstModule
    {
    class Program
        {
        static void Main(string[] args)
            {
            WorkWithDataTypes();
            }


        static void WorkWithDataTypes()
            {
            int int1;
            System.Int32 int2;
            var int3 = 3;
            int int4 = new int();
            var int5 = new int();
            int? int6 = null;
            byte byte1;
            string str1;
            var boolVar = false;
            char chVar;

            const string literal1 = "123h";
            
            
            int1 = 1;
            int2 = 2;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", int1, int2, int3, int4, int5, int6);
            

            
            boolVar = int.TryParse(literal1, out int4);
            if (boolVar)
                Console.WriteLine("Parse of literal {0} to int was succesfull, int4 = {1}", literal1, int4);
            else Console.WriteLine("Parse of literal {0} to int was unsuccesfull, int4 = {1}", literal1, int4);

            int5 = int.MaxValue;
            byte1 = (byte)int5;
            Console.WriteLine(byte1);

            Console.WriteLine(double.Epsilon);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);

            //str1 = (string)boolVar; impossible conversion

            chVar = literal1[int1];
            Console.WriteLine("{0} position in {1} = {2}", int1+1, literal1, chVar);

            int[][] myArray = new int[3][]
            {
                new[]{1},
                new[]{2},
                new[] { 3, 4, 5 }
            };

            var items = new[]
            {
                new[] {1,2,3},
                new[] {2,3,4}
                
            };

            //int [3] arr = new int {1, 2, 3};
            
            //string str2;
            //str2=String.Format("{1}, {2}, {3}", "Veni", "vidi", "vici");
            //    Console.WriteLine(str2);

                var total = 1234.56m;
                Console.WriteLine(total.ToString("c"));

                int myInt = new int();

                bool v1 = true;
                bool v2 = false;
                bool v3;
                v3 = (v1 & v2);

                Console.WriteLine(v3);

            Console.ReadLine();
            }
        }
    }
