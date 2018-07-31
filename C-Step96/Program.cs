using System;
using System.Text;

namespace C_Step96
{
    class Program
    {
        static void Main()
        {
            string Concat1 = "This is ";
            string Concat2 = "a ";
            string Concat3 = "simple sentence.";
            Console.WriteLine(Concat1 + Concat2 + Concat3);

            Console.WriteLine("Write any word:");
            string Upper = Console.ReadLine();
            Console.WriteLine(Upper.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("One fish, ");
            sb.Append("two fish. ");
            sb.Append("Red fish, ");
            sb.Append("blue fish. ");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
