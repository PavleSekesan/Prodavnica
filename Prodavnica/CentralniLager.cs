using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class CentralniLager : Lager
    {
        List<Artikal> artikliIstekaoRok;
        public new void DodajNaStanje(Artikal artikal)
        {
            if (artikal.IstekaoRok())
            {
                artikliIstekaoRok.Add(artikal);
            }
            else
            {
                base.DodajNaStanje(artikal);
            }
        }
        public CentralniLager() : base()
        {
            artikliIstekaoRok = new List<Artikal>();
        }
    }
}