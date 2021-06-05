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
        
        public PoslovnaJedinica(string grad, List<Prodavnica> prodavnice, CentralniLager centralniLager, List<RadnoMesto> radnaMesta)
        {
            this.grad = grad;
            this.prodavnice = prodavnice;
            this.centralniLager = centralniLager;
            this.radnaMesta = radnaMesta;
        }

        public void Zatvori()
        {
            throw new NotImplementedException();
        }
    }
}