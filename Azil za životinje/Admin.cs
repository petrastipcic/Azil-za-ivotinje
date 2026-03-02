using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Azil_za_životinje
{
    public static class Admin
    {
        public static void SpremiPodatke(string linija)
        {
            StreamWriter sw = new StreamWriter("Podaci.txt", true);
            sw.WriteLine(linija);
            sw.Close();

        }
        public static List<string> UcitajPodatke()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("Podaci.txt");
            string linija=sr.ReadLine();
            while ((linija!=null))
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }

            sr.Close();
            return lista;
        }
    }
}
