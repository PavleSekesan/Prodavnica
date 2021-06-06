using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class TrajniProizvod : Artikal
    {
        private string opis;
        public TrajniProizvod(double cena, string naziv, string ambalaza, string jedinicaProdaje, DateTime rokTrajanja, string opis) : base(cena, naziv, ambalaza, jedinicaProdaje, rokTrajanja)
        {
            this.popustPredIstekRoka = 0.3;
            this.opis = opis;
        }
    }
}