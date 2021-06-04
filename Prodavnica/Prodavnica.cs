using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Prodavnica
    {
        private double povrsina;
        private List<Type> proizvodiVanPonude;
        private List<RadnoMesto> radnaMesta;
        private List<Kasa> kase;
        /*
         
         6. Prodavnica se mogu podeliti na sledeće: 
        a. Mala prodavnica – objekat do 70m2, nema u ponudi sveže meso, mesne prerađevine, pecivo i kuvanu hranu. Od zaposlenih ima menadžera, 
        dva kasira i dva aranžera. Prodavnica ima jednu kasu.  

        b. Srednja prodavnica – objekati do 200m2, u ponudi nema pecivo i kuvanu hranu. Osnovni skup zaposlenih  čine: 
        dva menadžera, četiri kasira, četiri aranžera, četiri mesara, dva pekara i dva člana pomoćnog osoblja. Prodavnica ima dve kase. 
        
        c. Velika prodavnica – objekti do 400m2. Sadrži celokupnu ponudu sa lagera. Na svakih 50m2 preko 200m2  dodaje se po jedna kasa 
        i zapošljava se po još dva radnika svakog profila preko osnovnog skupa zaposlenih  u srednjoj prodavnici.  

        d. Super/hiper marketi – objekti preko 400m2. Sadrži celokupnu ponudu sa lagera. Na svakih 50m2 preko  200m2 dodaje se 
        po jedna kasa i zapošljava se po još dva radnika svakog profila preko osnovnog skupa  zaposlenih u srednjoj prodavnici. 
        Celokupna ponuda prodavnice je na trajnom sniženju od 5%.
        Svakoj prodavnici pridružen je lager, odgovarajući broj kasa i spisak svih zaposlenih kao i spisak upražnjenih radnih  mesta. 
        Po potrebi, zaposleni mogu da prelaze iz jedne u drugu prodavnicu. Prodavnica robu može da poručuje  samo iz centralnog lagera. 
        Roba kojoj je istekao rok trajanja vraća se nazad u centralni lager.  

         */
        public Prodavnica(double povrsina)
        {
            this.povrsina = povrsina;
            proizvodiVanPonude = new List<Type>();

            var radnaMestaSrednjeProdavnice = new List<RadnoMesto>() { new RadnoMesto(typeof(Radnik), null) };
            if (povrsina <= 70)
            {
                proizvodiVanPonude = new List<Type>() { typeof(SvezeMeso), typeof(MesnePreradjevine), typeof(Pecivo)};
                radnaMesta = new List<RadnoMesto>() { new RadnoMesto(typeof(Radnik),null) };
                kase = new List<Kasa>() { new Kasa() };
            }
            else if (povrsina > 70 && povrsina <= 200)
            {
                proizvodiVanPonude = new List<Type>() { typeof(Pecivo) };
                radnaMesta = radnaMestaSrednjeProdavnice;
            }
            else if (povrsina <= 400)
            {
                radnaMesta = radnaMestaSrednjeProdavnice;
                for (int i = 250; i <= povrsina; i+=50)
                {
                    kase.Add(new Kasa());
                    throw new NotImplementedException("");
                }
            }
            else
            {
                radnaMesta = radnaMestaSrednjeProdavnice;
                for (int i = 250; i <= povrsina; i += 50)
                {
                    kase.Add(new Kasa());
                    throw new NotImplementedException("");
                }
            }
        }
        public bool ImaMesto(Radnik radnik)
        {
            foreach (var radnoMesto in radnaMesta)
            {
                if (radnik.GetType() == radnoMesto.UlogaRadnika)
                {
                    return true;
                }
            }
            return false;
        }
        public void ZaposliRadnika(Radnik radnik)
        {
            foreach (var radnoMesto in radnaMesta)
            {
                if (radnik.GetType() == radnoMesto.UlogaRadnika && radnoMesto.JePrazno)
                {
                    radnoMesto.RadnikNaMestu = radnik;
                    break;
                }
            }
        }
    }
}