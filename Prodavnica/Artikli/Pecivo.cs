using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Pecivo : Artikal
    {
        public Pecivo(double cena, string naziv, string ambalaza, string jedinicaProdaje, DateTime rokTrajanja) : base(cena, naziv, ambalaza, jedinicaProdaje, rokTrajanja)
        {
            this.popustPredIstekRoka = 0.5;
        }
    }
}