using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Azil_za_životinje
{
    public static class Datoteka
    {
        private static string putanja = "zivotinje.txt";
        public static void SpremiSve(List<Zivotinja> lista)
        {
            foreach (var z in lista)
            {
                string red = $"{z.ID}|{z.Ime}|{z.Vrsta}|{z.Pasmina}|{z.Spol}|{z.Dob}|{z.Status}|{z.PutanjaSlike}|{z.DatumDolaska}|{z.DatumUdomljavanja}|{z.Cijepljen}|{z.Kastriran}|{z.Napomena}|{z.Udomitelj}|{z.Kontakt}";
                File.AppendAllText(putanja, red + Environment.NewLine);
            }
        }

        public static void Spremi(Zivotinja z)
        {
            string red = $"{z.ID}|{z.Ime}|{z.Vrsta}|{z.Pasmina}|{z.Spol}|{z.Dob}|{z.Status}|{z.PutanjaSlike}|{z.DatumDolaska}|{z.DatumUdomljavanja}|{z.Cijepljen}|{z.Kastriran}|{z.Napomena}|{z.Udomitelj}|{z.Kontakt}";
            File.AppendAllText(putanja, red + Environment.NewLine);
        }
        public static List<Zivotinja> UcitajSve()
        {
            List<Zivotinja> lista = new List<Zivotinja>();
                if (!File.Exists(putanja))
                return lista;
            var linije = File.ReadAllLines(putanja);
            foreach (var linija in linije)
            {
                var p = linija.Split('|');
                Zivotinja z = new Zivotinja
                {
                    ID = p[0],
                    Ime = p[1],
                    Vrsta = p[2],
                    Pasmina = p[3],
                    Spol = p[4],
                    Dob = int.Parse(p[5]),
                    Status = p[6],
                    PutanjaSlike = p[7],
                    DatumDolaska = DateTime.Parse(p[8]),
                    DatumUdomljavanja = string.IsNullOrEmpty(p[9]) ? DateTime.MinValue : DateTime.Parse(p[9]),
                    Cijepljen = bool.Parse(p[10]),
                    Kastriran = bool.Parse(p[11]),
                    Napomena = p[12],
                    Udomitelj = p[13],
                    Kontakt = p[14]

                };
                lista.Add(z);
            }
            return lista;

        }
    }
}
