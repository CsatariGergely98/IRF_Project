using System;
using System.Collections.Generic;
using System.IO;

namespace IRF_Beadando
{
    /// <summary>
    /// Absztrakt exporter osztály, a "Template Method" tervezési minta alapján.
    /// Mivel minden export ugyanazokból az elemi lépésekből épül fel, ezért illik ide ez a minta.
    /// Az egyes konkrét megvalósítások csak a szükséges metódusokat valósítják meg, írják felül.
    /// A header/footer nem absztrakt, tartalmaz egy default megvalósítást; így azt csak szükséges esetben kell felülírni.
    /// </summary>
    public abstract class MunkavegzesExpAbstractClass
    {
        public bool Export(string fileName, List<Munkavegzes> data)
        {
            if (data == null)
            {
                return false;
            }
            using (StreamWriter os = new StreamWriter(fileName))
            {
                // fejlec
                string s = GetHeader();
                if (s != null)
                {
                    os.WriteLine(s);
                }
                // adatok
                foreach (var item in data)
                {
                    os.WriteLine(FormatLine(item));
                }
                // lablec
                s = GetFooter();
                if (s != null)
                {
                    os.WriteLine(s);
                }
            }
            return true;

        }
        public abstract string FormatLine(Munkavegzes m);
        public virtual string GetHeader()
        {
            return null;
        }
        public virtual string GetFooter()
        {
            return null;
        }
    }

    /// <summary>
    /// Konkrét exporter osztály: CSV formátum
    /// </summary>
    public class CsvExporter : MunkavegzesExpAbstractClass
    {

        override public string FormatLine(Munkavegzes m)
        {
            return String.Format("\"{0}\",\"{1}\",\"{2:yyyy.MM.dd hh:mm:ss}\",\"{3::yyyy.MM.dd hh:mm:ss}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"",
                m.Dolgozo.LoginNev, m.Tevekenyseg.Megnevezes, m.Kezdodatum,
                m.Vegdatum, m.Ledolgozott, m.Megjegyzes, m.Ugyfelazonosito, m.Iktatoszam, m.Iktatottoldalszam);
        }

        public override string GetHeader()
        {
            return "Dolgozó,Tevékenység,Kezdet,Vég,Ledolgozott_idő,Megjegyzés,Ügyfélazonosító,Iktatószám,Oldalszám";
        }
    }

    /// <summary>
    /// Konkrét exporter osztály: XML formátum. Nincs implementálva!
    /// </summary>
    public class XmlExporter : MunkavegzesExpAbstractClass
    {

        override public string FormatLine(Munkavegzes m)
        {
            // TODO ha majd kell XML export, akkor meg kell irni
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Konkrét exporter osztály: JSON formátum. Nincs implementálva!
    /// </summary>
    public class JSonExporter : MunkavegzesExpAbstractClass
    {

        override public string FormatLine(Munkavegzes m)
        {
            // TODO ha majd kell JSON export, akkor meg kell irni
            throw new NotImplementedException();
        }
    }
}
