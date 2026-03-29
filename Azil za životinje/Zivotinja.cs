using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azil_za_životinje
{
    public class Zivotinja
    {
        public string ID { get; set; }
        public string Ime { get; set; }
        public string Vrsta { get; set; }
        public string Pasmina { get; set; }
        public string Spol {  get; set; }
        public int Dob {  get; set; }
        public string Status { get; set; }
        public string PutanjaSlike { get; set; }
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumUdomljavanja {  get; set; }
        public bool Cijepljen {  get; set; }
        public bool Kastriran {  get; set; }
        public string Napomena { get; set; }
        public string Udomitelj {  get; set; }
        public string Kontakt {  get; set; }

        public override string ToString()
        {
            return $"{ID}-{Ime} ({Vrsta})";
        }

    }
}
