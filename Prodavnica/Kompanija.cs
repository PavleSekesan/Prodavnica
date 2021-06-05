using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Kompanija
    {
        private List<PoslovnaJedinica> poslovneJedinice;
        private List<RadnoMesto> radnaMesta;
        public List<PoslovnaJedinica> PoslovneJedinice
        {
            get => poslovneJedinice;
        }
        public List<RadnoMesto> RadnaMesta
        {
            get => radnaMesta;
        }
        public Kompanija()
        {
            radnaMesta = new List<RadnoMesto>();
            radnaMesta.Add(new RadnoMesto(typeof(GeneralniDirektor), null));
            for (int i = 0; i < 30; i++)
            {
                radnaMesta.Add(new RadnoMesto(typeof(ZaposleniUDirekciji), null));
            }
            poslovneJedinice = new List<PoslovnaJedinica>();
        }

        public void OtvoriPoslovnuJedinicu(string grad)
        {
            var novaPoslovnaJedinica = new PoslovnaJedinica(grad);
            poslovneJedinice.Add(novaPoslovnaJedinica);
        }

        public void ZatvoriPoslovnuJedinicu()
        {
            throw new NotImplementedException();
        }

        public void PremestiPoslovnuJedinicu()
        {
            throw new NotImplementedException();
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
    }
}