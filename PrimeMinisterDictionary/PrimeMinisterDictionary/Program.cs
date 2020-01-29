using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisterDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var PrimeMinister = new Dictionary<int, String>()
            {
                 { 1998,"Atal Bihari Vajpayee" },
                 { 2014,"Narendra Modi" },
                 { 2004,"Manmohan Singh"},
             };
            Console.WriteLine("Prime Minister of 2004 is :" + PrimeMinister[2004]);
            PrimeMinister.Add(2020,"Narendra Modi");
            var list = PrimeMinister.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, PrimeMinister[key]);
            }
            Console.ReadKey();
        }
    }
}
