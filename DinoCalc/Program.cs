using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc2();

        }

        public static void Calc()
        {
            Console.WriteLine("How many iterations You want to calculate?:");
            int iterations = Convert.ToInt32(Console.ReadLine());

            List<Dino> list = new List<Dino>();
            list.Add(new Dino());
            var dinoDeath = 0;
            for (int i = 0; i < iterations; i++)
            {
                var tmp = list.Count;
                foreach (var dino in list)
                {
                    dino.hp--;
                }
                for (int j = tmp - 1; j >= 0; j--)
                {
                    if (list[j].hp == 0)
                    {
                        list.RemoveAt(j);
                        dinoDeath++;
                    }
                }
                for (int j = 0; j < tmp; j++)
                {
                    list.Add(new Dino());
                }
                Console.WriteLine("Iteration:{0}, number of raptors:{1}, number of dead raptors:{2}", i + 1, list.Count,
                    dinoDeath);
            }
            Console.ReadKey();
        }

        public static void Calc2()
        {
            Console.WriteLine("How many iterations You want to calculate?:");
            int iterations = Convert.ToInt32(Console.ReadLine());
            ulong dino5 = 1;
            ulong dino4 = 0;
            ulong dino3 = 0;
            ulong dino2 = 0;
            ulong dino1 = 0;
            ulong dinoDead = 0;
            for (int i = 0; i < iterations; i++)
            {
                ulong tmpAlive = dino5 + dino4 + dino3 + dino2 + dino1;
                dinoDead = dino1;
                dino1 = dino2;
                dino2 = dino3;
                dino3 = dino4;
                dino4 = dino5;
                dino5 = tmpAlive;
                Console.WriteLine("Iteration:{0}, number of raptors:{1}, number of dead raptors:{2}", i + 1, dino1 + dino2 + dino3 + dino4 + dino5, dinoDead);
                Console.WriteLine(dino1+dino2+dino3+dino4+dino5);
            }
            Console.ReadLine();
        }
    }
}
