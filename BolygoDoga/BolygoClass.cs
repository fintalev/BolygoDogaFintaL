using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolygoDoga
{
    internal class BolygoClass
    {
        

        public string BolygoNev { get; set; }
        public int HoldSzam { get; set; }
        public double Arany { get; set; }


        public BolygoClass(string r)
        {
            var s = r.Split(';');
            BolygoNev = s[0];
            HoldSzam = int.Parse(s[1]);
            Arany = double.Parse(s[2].Replace('.',','));
        }
    }

    


}
