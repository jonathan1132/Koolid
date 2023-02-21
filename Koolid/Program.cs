using System;
using System.Collections.Generic;

namespace Koolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> koolid = new Dictionary<int, string>();
            koolid.Add(1, "Tallinna Rahumäe Põhikool");
            koolid.Add(2, "Tallinna Nõmme Gümnaasium");
            koolid.Add(3, "Tallinna 32. keskkool");
            
            foreach (KeyValuePair<int, string> kool in koolid)
            {
                Console.WriteLine("Kooli nimi: {1}", kool.Key, kool.Value);
            }

            Console.ReadLine();
        }
    }
}
