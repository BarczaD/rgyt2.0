using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace rgyt2._0.Models
{
    public class Child
    {
        public int Gyerekid { get; set; }
        public int Szuloazon { get; set; }
        public string Gyereknev { get; set; }
        public int Irsz { get; set; }
        public string Utca { get; set; }
        public string Hsz { get; set; }
        public int Tajszam { get; set; }
        public DateOnly? Szulido { get; set; }
        public string Anyjaneve { get; set; }
        public int Intezmeny { get; set; }
        public int Gyerektipus { get; set; }
        public int Osszeg { get; set; }
        public int Szamlaszam { get; set; }
        public int Hh { get; set; }
        public int Hhjog1 { get; set; }
        public int Hhjog2 { get; set; }
        public int Hhjog3 { get; set; }
        public DateOnly? Jogdatum { get; set; }
        public bool Deleted { get; set; }

        public Child(
                int gyerekid,
                int szuloazon,
                string gyereknev,
                int irsz,
                string utca,
                string hsz,
                int tajszam,
                string szulido,
                string anyjaneve,
                int intezmeny,
                int gyerektipus,
                int osszeg,
                int szamlaszam,
                int hh,
                int hhjog1,
                int hhjog2,
                int hhjog3,
                string jogdatum)
        {
            Gyerekid = gyerekid;
            Szuloazon = szuloazon;
            Gyereknev = gyereknev;
            Irsz = irsz;
            Utca = utca;
            Hsz = hsz;
            Tajszam = tajszam;

            Szulido = DataHelper.ParseDbfDate(szulido);
            Anyjaneve = anyjaneve;

            Intezmeny = intezmeny;
            Gyerektipus = gyerektipus;
            Osszeg = osszeg;
            Szamlaszam = szamlaszam;

            Hh = hh;
            Hhjog1 = hhjog1;
            Hhjog2 = hhjog2;
            Hhjog3 = hhjog3;

            Jogdatum = DataHelper.ParseDbfDate(jogdatum);
        }

    }
}
