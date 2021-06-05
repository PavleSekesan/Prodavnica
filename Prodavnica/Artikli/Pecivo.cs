using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Pecivo : Artikal
    {
        public Pecivo(double cena, string naziv, string ambalaza, DateTime rokTrajanja) : base(cena, naziv, ambalaza, rokTrajanja)
        {
            this.popustPredIstekRoka = 0.5;
        }
    }
}