using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class MalaProdavnica : Prodavnica
    {
        public MalaProdavnica(double povrsina, string adresa, PoslovnaJedinica poslovnaJedinica) : base(povrsina, adresa, poslovnaJedinica)
        {
            proizvodiVanPonude = new List<Type>() { typeof(SvezeMeso), typeof(MesnePreradjevine), typeof(Pecivo) };

            radnaMesta = new List<RadnoMesto>();
            DodajRadnaMesta(new Dictionary<Type, int>(){
                    { typeof(MenadzerProdavnice), 1 },
                    { typeof(Kasir), 2 },
                    { typeof(Aranzer), 2 }
                }, ref radnaMesta);

            kase = new List<Kasa>();
            DodajKase(1, ref kase);
        }
    }
}