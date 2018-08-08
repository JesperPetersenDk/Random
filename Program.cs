using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValue
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] modsName = { "laugovits", "denlabrelarve", "z69w", "logviewer", "zhow", "lenze", "neahao", "zimze1337", "leifislife", "kappty", "palmblad_87", "mrkush420", "glemtnavn", "fukdop", "oakjim" };//Modsname her
            var txt = modsName[RandomValue(modsName.Length)];//tager et random navn ud fra arraylisten som er fra modsname
            Console.WriteLine(txt);//udskriver navnet her
            Console.ReadKey();
        }

        public static int RandomValue(int e)
        {
            Random rnd = new Random();
            return rnd.Next(e);
        }
    }
}
