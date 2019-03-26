using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_pleeeeeasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B={0}", B);

            Console.WriteLine("A={0}", A);
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());


            Console.WriteLine("A+B={0}", A + B);
            Console.WriteLine("A-B={0}", A - B);

            Console.WriteLine("A/B={0}", A / (double)B);

            //TUT BUDET GOROD SAD
            Console.ReadKey();
            Console.WriteLine("A*B={0}", A * B);
        }
    }
}
