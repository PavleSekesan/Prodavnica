using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    public static class ProdavnicaFactory
    {
        public static Prodavnica NovaProdavnica(double povrsina, string adresa, PoslovnaJedinica poslovnaJedinica)
        {
            if (povrsina <= 70)
            {
                return new MalaProdavnica(povrsina, adresa, poslovnaJedinica);
            }
            else if (povrsina > 70 && povrsina <= 200)
            {
                return new SrednjaProdavnica(povrsina, adresa, poslovnaJedinica);
            }
            else if (povrsina > 200 && povrsina <= 400)
            {
                return new VelikaProdavnica(povrsina, adresa, poslovnaJedinica);
            }
            else
            {
                return new Supermarket(povrsina, adresa, poslovnaJedinica);
            }
        }
    }
}
