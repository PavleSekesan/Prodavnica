using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    class RadnoMesto
    {
        private Type ulogaRadnika;
        private Radnik radnik;
        public bool JePrazno
        {
            get => radnik == null;
        }
        public Type UlogaRadnika
        {
            get => ulogaRadnika;
        }
        public Radnik RadnikNaMestu
        {
            get => radnik;
            set
            {
                radnik = value;
            }
        }
        public RadnoMesto(Type ulogaRadnika, Radnik radnik)
        {
            this.ulogaRadnika = ulogaRadnika;
            this.radnik = radnik;
        }
    }
}
