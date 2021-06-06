using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class PoslovnaJedinica
    {
        private string grad;
        private List<Prodavnica> prodavnice;
        private CentralniLager centralniLager;
        private List<RadnoMesto> radnaMesta;
        public List<RadnoMesto> RadnaMesta
        {
            get => radnaMesta;
        }
        public List<Prodavnica> Prodavnice
        {
            get => prodavnice;
        }
        public CentralniLager CentralniLager
        {
            get => centralniLager;
        }
        
        public PoslovnaJedinica(string grad)
        {
            this.grad = grad;
            this.prodavnice = new List<Prodavnica>();
            this.centralniLager = new CentralniLager();
            this.radnaMesta = new List<RadnoMesto>();
            Dictionary<Type, int> zaDodavanje = new Dictionary<Type, int>()
            {
                { typeof(DirektorPoslovneJedinice), 2 },
                { typeof(MenadzerPoslovneJedinice), 6 },
                { typeof(PomocnoOsoblje), 30 }
            };
            DodajRadnaMesta(zaDodavanje,ref radnaMesta);
        }
        private void DodajRadnaMesta(Dictionary<Type, int> zaDodavanje, ref List<RadnoMesto> radnaMesta)
        {
            foreach (var kvp in zaDodavanje)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    radnaMesta.Add(new RadnoMesto(kvp.Key, null));
                }
            }
        }
        public bool ImaMesto(Radnik radnik)
        {
            foreach (var radnoMesto in radnaMesta)
            {
                if (radnik.GetType() == radnoMesto.UlogaRadnika)
                {
                    return true;
                }
            }
            return false;
        }
        public void ZaposliRadnika(Radnik radnik)
        {
            foreach (var radnoMesto in radnaMesta)
            {
                if (radnik.GetType() == radnoMesto.UlogaRadnika && radnoMesto.JePrazno)
                {
                    radnoMesto.RadnikNaMestu = radnik;
                    break;
                }
            }
        }
        public void OtvoriProdavnicu(double povrsina, string adresa)
        {
            var novaProdavnica = new Prodavnica(povrsina, adresa, this);
            prodavnice.Add(novaProdavnica);
        }

        public override string ToString()
        {
            return grad;
        }
        public void Zatvori()
        {
            throw new NotImplementedException();
        }
    }
}