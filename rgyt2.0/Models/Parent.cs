using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Models
{
    public class Parent
    {
        public int Szuloazon { get; set; }
        public int Mankoazon { get; set; }
        public string Szulonev { get; set; }
        public int Irsz { get; set; }
        public string Utca { get; set; }
        public string Hsz { get; set; }
        public int Tajszam { get; set; }
        public string Anyjaneve { get; set; }
        public string Leanykorin { get; set; }
        public DateOnly Szulido { get; set; }
        public int Szulotipus { get; set; }
        public int Osszeg { get; set; }
        public int Iktatoszam { get; set; }
        public int Szamlaszam { get; set; }
        public short Egyedulnev { get; set; }
        public int Intezmeny { get; set; }
        public DateOnly? Felulvizsg { get; set; }
        public int Egyforejut { get; set; }
        public short Hh { get; set; }
        public short Hhjog1 { get; set; }
        public short Hhjog2 { get; set; }
        public short Hhjog3 { get; set; }
        public bool Deleted { get; set; }


        public Parent(
                int szuloazon,
                int mankoazon,
                string szulonev,
                int irsz,
                string utca,
                string hsz,
                int tajszam,
                string anyjaneve,
                string leanykorin,
                string szulido,
                int szulotipus,
                int osszeg,
                int iktatoszam,
                int szamlaszam,
                short egyedulnev,
                int intezmeny,
                string felulvizsg,
                int egyforejut,
                short hh,
                short hhjog1,
                short hhjog2,
                short hhjog3)
        {
            Szuloazon = szuloazon;
            Mankoazon = mankoazon;
            Szulonev = szulonev;
            Irsz = irsz;
            Utca = utca;
            Hsz = hsz;
            Tajszam = tajszam;
            Anyjaneve = anyjaneve;
            Leanykorin = leanykorin;

            Szulido = DateOnly.TryParse(szulido, out var szu)
                ? szu
                : default;

            Szulotipus = szulotipus;
            Osszeg = osszeg;
            Iktatoszam = iktatoszam;
            Szamlaszam = szamlaszam;
            Egyedulnev = egyedulnev;
            Intezmeny = intezmeny;

            Felulvizsg = DataHelper.ParseDbfDate(felulvizsg);

            Egyforejut = egyforejut;
            Hh = hh;
            Hhjog1 = hhjog1;
            Hhjog2 = hhjog2;
            Hhjog3 = hhjog3;
        }

    }
}
