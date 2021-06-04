using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class SvezeMeso : Artikal
    {
        public SvezeMeso(double cena, string naziv, string ambalaza, DateTime rokTrajanja) : base(cena, naziv, ambalaza, rokTrajanja)
        {
            this.popust = 0.3;
        }
    }
}