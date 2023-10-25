using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace BolygoDoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BolygoClass> list = new List<BolygoClass>();
            
            
            StreamReader sr = new StreamReader(@"..\..\src\solsys.txt");
            while (!sr.EndOfStream)
            {
                list.Add(new BolygoClass(sr.ReadLine()));
            }

            Console.WriteLine($"3.1 feladat {list.Count} bolygó van a naprendszerben");

            double hold = 0;
            
            
            
            foreach (var item in list)
            {
                hold += item.HoldSzam;
            }

            double holdavg=hold/list.Count;

           

            Console.WriteLine($"3.2 feladat a naprendszerben egy bolygónak átlagosan {holdavg} holdja van");

            double maxter = 0;
            string maxbolygo = "";
            foreach (var item in list)
            {
                if (item.Arany>maxter)
                {
                    maxter = item.Arany;
                    maxbolygo = item.BolygoNev;
                }
            }

            Console.WriteLine($"3.3 feladat a legnagyobb térfogatú bolygó a {maxbolygo}");


            Console.Write(" 3.4 feladat írd be a keresett bolygó nevét: ");
            string input= Console.ReadLine();
            string valasz = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].BolygoNev==input)
                {
                    valasz = "Van ilyen bolygó a listában";
                    break;
                }
                else
                {
                    valasz = "Nincs ilyen bolgyó a listában";
                }
            }

            Console.WriteLine(valasz);

            Console.Write("3.5 feladat Írj be egy egész számot: ");
            int input2=int.Parse(Console.ReadLine());
            string holdcucc = "";

            foreach (BolygoClass item in list)
            {
                if (item.HoldSzam > input2)
                {
                    holdcucc += ($"'{item.BolygoNev}',"); 
                }
            }

            Console.WriteLine($"A következő bolygóknak van több holja mint{input2}");
            Console.WriteLine($"[{holdcucc}]");
            



            Console.ReadKey();

        }
    }
}
