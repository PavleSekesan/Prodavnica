using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public abstract class Artikal
    {

        protected double cena;
        protected double popust;
        protected string naziv;
        protected string ambalaza;
        protected DateTime rokTrajanja;

        public Artikal(int cena, string naziv, string ambalaza, DateTime rokTrajanja)
        {
            this.cena = cena;
            this.naziv = naziv;
            this.ambalaza = ambalaza;
            this.rokTrajanja = rokTrajanja;
        }

        // Ako artiklu fali jos $granica dana do isteka roka, vraca true
        protected bool PredIstekRoka()
        {
            const int granica = 10;
            int uslov = DateTime.Now.AddDays(granica).CompareTo(rokTrajanja);
            if (uslov >= 0)
                return true;
            else
                return false;
        }
        public double Cena
        {
            get
            {
                if (PredIstekRoka())
                    return cena * popust;
                else
                    return cena;
            }
            set
            {
            }
        }

        public string Naziv
        {
            get => naziv;
            set
            {
            }
        }

        public string Ambalaza
        {
            get => ambalaza;
            set
            {
            }
        }

        public DateTime RokTrajanja
        {
            get => rokTrajanja;
            set
            {
            }
        }
    }
}