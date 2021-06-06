using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public abstract class Artikal
    {
        protected double cena;
        protected double popustPredIstekRoka;
        protected double popust;
        protected string naziv;
        protected string ambalaza;
        protected string jedinicaProdaje;
        protected DateTime rokTrajanja;

        public Artikal(double cena, string naziv, string ambalaza, string jedinicaProdaje, DateTime rokTrajanja)
        {
            this.cena = cena;
            popust = 0;
            this.naziv = naziv;
            this.ambalaza = ambalaza;
            this.jedinicaProdaje = jedinicaProdaje;
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

        public double Popust
        {
            get => popust;
            set
            {
                popust = value;
            }
        }
        public double Cena
        {
            get
            {
                double ret = cena * (1 - popust);
                if (PredIstekRoka())
                    ret *= (1 - popustPredIstekRoka);
                return ret;
            }
            set
            {
                cena = value;
            }
        }

        public string Naziv
        {
            get => naziv;
            set
            {
                naziv = value;
            }
        }

        public string Ambalaza
        {
            get => ambalaza;
            set
            {
                ambalaza = value;
            }
        }

        public DateTime RokTrajanja
        {
            get => rokTrajanja;
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}