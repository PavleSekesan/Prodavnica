using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Prodavnice
{
    public static class ProdavnicaFactory
    {
        public static Prodavnica NovaProdavnica(double povrsina, string adresa)
        {
            if (povrsina <= 70)
            {
                return new MalaProdavnica(povrsina, adresa);
            }
            else if (povrsina > 70 && povrsina <= 200)
            {
                return new SrednjaProdavnica(povrsina, adresa);
            }
            else if (povrsina > 200 && povrsina <= 400)
            {
                return new VelikaProdavnica(povrsina, adresa);
            }
            else
            {
                return new Supermarket(povrsina, adresa);
            }
        }
    }
}
