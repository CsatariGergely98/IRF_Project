using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Beadando
{
    class MunkavegzesEpito
    {
        private int dolgozoId;
        private int tevekenysegId;
        private DateTime kezdoDatum;
        private DateTime vegDatum;
        private string megjegyzes;
        private string ugyfelazonosito;
        private string ikatoszam;
        private int iktatottOldalszam;

        public MunkavegzesEpito Create(int dolgozoId, int tevekenysegId, DateTime kezdoDatum, DateTime vegDatum)
        {
            this.dolgozoId = dolgozoId;
            this.tevekenysegId = tevekenysegId;
            this.kezdoDatum = kezdoDatum;
            this.vegDatum = vegDatum;
            return this;
        }

        public MunkavegzesEpito Megjegyzes(string megjegyzes)
        {
            this.megjegyzes = megjegyzes;
            return this;
        }
        public MunkavegzesEpito Ugyfelazonosito(string ugyfelazonosito)
        {
            this.ugyfelazonosito = ugyfelazonosito;
            return this;
        }
        public MunkavegzesEpito Ikatoszam(string ikatoszam)
        {
            this.ikatoszam = ikatoszam;
            return this;
        }
        public MunkavegzesEpito IktatottOldalszam(int iktatottOldalszam)
        {
            this.iktatottOldalszam = iktatottOldalszam;
            return this;
        }

        public Munkavegzes build()
        {
            Munkavegzes m = new Munkavegzes();
            m.DolgozoId = dolgozoId;
            m.TevekenysegId = tevekenysegId;
            m.Kezdodatum = kezdoDatum;
            m.Vegdatum = vegDatum;
            if (megjegyzes != null)
            {
                m.Megjegyzes = megjegyzes;
            }
            if (ugyfelazonosito != null)
            {
                m.Ugyfelazonosito = ugyfelazonosito;
            }
            if (ikatoszam != null)
            {
                m.Iktatoszam = ikatoszam;
            }
            m.Iktatottoldalszam = iktatottOldalszam;
            return m;
        }
    }
}
