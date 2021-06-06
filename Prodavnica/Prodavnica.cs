using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Prodavnica
    {
        protected PoslovnaJedinica poslovnaJedinica;
        protected string adresa;
        protected double povrsina;
        protected List<Type> proizvodiVanPonude;
        protected List<RadnoMesto> radnaMesta;
        protected List<Kasa> kase;
        protected Lager lager;

        public Lager LagerUProdavnici
        {
            get => lager;
        }
        public List<RadnoMesto> RadnaMesta
        {
            get => radnaMesta;
        }
        public List<Radnik> Zaposleni
        {
            get => radnaMesta.Where(x => !x.JePrazno).Select(x => x.RadnikNaMestu).ToList();
        }
        /*
         
         6. Prodavnica se mogu podeliti na sledeće: 
        a. Mala prodavnica – objekat do 70m2, nema u ponudi sveže meso, mesne prerađevine, pecivo i kuvanu hranu. Od zaposlenih ima menadžera, 
        dva kasira i dva aranžera. Prodavnica ima jednu kasu.  

        b. Srednja prodavnica – objekati do 200m2, u ponudi nema pecivo i kuvanu hranu. Osnovni skup zaposlenih  čine: 
        dva menadžera, četiri kasira, četiri aranžera, četiri mesara, dva pekara i dva člana pomoćnog osoblja. 
        Prodavnica ima dve kase. 
        
        c. Velika prodavnica – objekti do 400m2. Sadrži celokupnu ponudu sa lagera. Na svakih 50m2 preko 200m2  
        dodaje se po jedna kasa i zapošljava se po još dva radnika svakog profila preko osnovnog skupa zaposlenih  
        u srednjoj prodavnici.  

        d. Super/hiper marketi – objekti preko 400m2. Sadrži celokupnu ponudu sa lagera. Na svakih 50m2 preko  200m2 dodaje se 
        po jedna kasa i zapošljava se po još dva radnika svakog profila preko osnovnog skupa  zaposlenih u srednjoj prodavnici. 
        Celokupna ponuda prodavnice je na trajnom sniženju od 5%.
        Svakoj prodavnici pridružen je lager, odgovarajući broj kasa i spisak svih zaposlenih kao i spisak upražnjenih radnih  mesta. 
        Po potrebi, zaposleni mogu da prelaze iz jedne u drugu prodavnicu. Prodavnica robu može da poručuje  samo iz centralnog lagera. 
        Roba kojoj je istekao rok trajanja vraća se nazad u centralni lager.  

         */
        protected void DodajRadnaMesta(Dictionary<Type, int> zaDodavanje, ref List<RadnoMesto> radnaMesta)
        {
            foreach (var kvp in zaDodavanje)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    radnaMesta.Add(new RadnoMesto(kvp.Key, null));
                }
            }
        }
        protected void DodajKase(int brojKasa, ref List<Kasa> kase)
        {
            for (int i = 0; i < brojKasa; i++)
                kase.Add(new Kasa(this));
        }
        public Prodavnica(double povrsina, string adresa, PoslovnaJedinica poslovnaJedinica)
        {
            this.poslovnaJedinica = poslovnaJedinica;
            this.adresa = adresa;
            this.povrsina = povrsina;
            lager = new Lager();
            proizvodiVanPonude = new List<Type>();
            radnaMesta = new List<RadnoMesto>();
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
        public void ZatvoriProdavnicu()
        {
            foreach (var artikal in lager.SviArtikli)
            {
                poslovnaJedinica.CentralniLager.DodajNaStanje(artikal);
            }
        }
        public void ProveriArtikle()
        {
            var zaUklanjanje = lager.SviArtikli.Where(x => x.IstekaoRok());
            foreach (var pokvareniArtikal in zaUklanjanje)
            {
                lager.SkiniSaStanja(pokvareniArtikal);
                poslovnaJedinica.CentralniLager.DodajNaStanje(pokvareniArtikal);
            }
        }

        public override string ToString()
        {
            return adresa;
        }
    }
}