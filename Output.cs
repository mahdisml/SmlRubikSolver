using System;
namespace Project {
    public static class Output {
        public static void print(int[] data){
            Console.WriteLine($"                  [{data[10]}] [{data[11]}] [{data[12]}]");
            Console.WriteLine($"                  [{data[13]}] [{data[14]}] [{data[15]}]");
            Console.WriteLine($"                  [{data[16]}] [{data[17]}] [{data[18]}]");
            Console.WriteLine("");
            Console.WriteLine($"     [{data[20]}] [{data[21]}] [{data[22]}]  [{data[0]}] [{data[1]}] [{data[2]}]  [{data[40]}] [{data[41]}] [{data[42]}]  [{data[50]}] [{data[51]}] [{data[52]}]");
            Console.WriteLine($"     [{data[23]}] [{data[24]}] [{data[25]}]  [{data[3]}] [{data[4]}] [{data[5]}]  [{data[43]}] [{data[44]}] [{data[45]}]  [{data[53]}] [{data[54]}] [{data[55]}]");
            Console.WriteLine($"     [{data[26]}] [{data[27]}] [{data[28]}]  [{data[6]}] [{data[7]}] [{data[8]}]  [{data[46]}] [{data[47]}] [{data[48]}]  [{data[56]}] [{data[57]}] [{data[58]}]");
            Console.WriteLine("");
            Console.WriteLine($"                  [{data[30]}] [{data[31]}] [{data[32]}]");
            Console.WriteLine($"                  [{data[33]}] [{data[34]}] [{data[35]}]");
            Console.WriteLine($"                  [{data[36]}] [{data[37]}] [{data[38]}]");
        }
        public static void printWithMap(int[] data){
            Console.WriteLine($"                  [{data[10]}] [{data[11]}] [{data[12]}]");
            Console.WriteLine($"                  [{data[13]}] [{data[14]}] [{data[15]}]");
            Console.WriteLine($"                  [{data[16]}] [{data[17]}] [{data[18]}]");
            Console.WriteLine("");
            Console.WriteLine($"     [{data[20]}] [{data[21]}] [{data[22]}]  [{data[0]}] [{data[1]}] [{data[2]}]  [{data[40]}] [{data[41]}] [{data[42]}]  [{data[50]}] [{data[51]}] [{data[52]}]");
            Console.WriteLine($"     [{data[23]}] [{data[24]}] [{data[25]}]  [{data[3]}] [{data[4]}] [{data[5]}]  [{data[43]}] [{data[44]}] [{data[45]}]  [{data[53]}] [{data[54]}] [{data[55]}]");
            Console.WriteLine($"     [{data[26]}] [{data[27]}] [{data[28]}]  [{data[6]}] [{data[7]}] [{data[8]}]  [{data[46]}] [{data[47]}] [{data[48]}]  [{data[56]}] [{data[57]}] [{data[58]}]");
            Console.WriteLine("");
            Console.WriteLine($"               s1 [{data[30]}] [{data[31]}] [{data[32]}]   s7  s8  s9");
            Console.WriteLine($"               s2 [{data[33]}] [{data[34]}] [{data[35]}]");
            Console.WriteLine($"               s3 [{data[36]}] [{data[37]}] [{data[38]}]");
            Console.WriteLine("                   s4  s5  s6");
        }
    }
}