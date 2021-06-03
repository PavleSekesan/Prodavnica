using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public abstract class Radnik
    {
        private static int radnikBrojac = 0;
        protected int id;
        protected string ime;
        protected string prezime;

        public string Ime
        {
            get { return ime; }
        }
        public string Prezime
        {
            get { return prezime; }
        }

        public Radnik(string ime, string prezime)
        {
            this.id = radnikBrojac++;
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
