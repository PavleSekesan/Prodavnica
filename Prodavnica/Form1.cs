using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class Form1 : Form
    {
        private Kompanija kompanija;
        private PoslovnaJedinica odabranaPoslovnaJedinica;
        private Prodavnica odabranaProdavnica;
        public Form1()
        {
            InitializeComponent();
        }

        private void PrikaziRadnaMesta(List<RadnoMesto> radnaMesta, ListView lv)
        {
            lv.Columns.Clear();
            lv.Columns.Add("Uloga");
            lv.Columns.Add("Ime");
            lv.Columns.Add("Prezime");

            foreach (var radnoMesto in radnaMesta)
            {
                var row = new ListViewItem(radnoMesto.ToStringList().ToArray());
                row.ForeColor = radnoMesto.JePrazno ? Color.Green : Color.DarkGray;
                lv.Items.Add(row);
            }

            // Autosize columns
            for (int i = 0; i < lv.Columns.Count; i++)
                lv.Columns[i].Width = -2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kompanija = new Kompanija();
            foreach (var poslovnaJedinica in kompanija.PoslovneJedinice)
            {
                poslvneJediniceLB.Items.Add(poslovnaJedinica);
            }

            PrikaziRadnaMesta(kompanija.RadnaMesta, zaposleniKompanijaLV);
            OsveziPoslovneJedinice();
        }
        private void OsveziPoslovneJedinice()
        {
            poslvneJediniceLB.Items.Clear();
            foreach (var poslovnaJedinica in kompanija.PoslovneJedinice)
            {
                poslvneJediniceLB.Items.Add(poslovnaJedinica);
            }
            odabranaPoslovnaJedinica = null;
        }
        private void OsveziProdavnice()
        {
            prodavniceLB.Items.Clear();
            foreach (var prodavnica in odabranaPoslovnaJedinica.Prodavnice)
            {
                prodavniceLB.Items.Add(prodavnica);
            }
            odabranaProdavnica = null;
        }
        private void OsveziLager(Lager lager, ListView lv)
        {
            lv.Columns.Clear();
            lv.Items.Clear();

            lv.Columns.Add("Naziv");
            lv.Columns.Add("Kolicina");

            foreach (var kvp in lager.ArtkliKolicine)
            {
                var row = new ListViewItem(new string[] { kvp.Key.ToString(), kvp.Value.ToString() });
                lv.Items.Add(row);
            }
            for (int i = 0; i < lv.Columns.Count; i++)
            {
                lv.Columns[i].Width = -2;
            }
        }

        private void poslvneJediniceLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaPoslovnaJedinica = kompanija.PoslovneJedinice[poslvneJediniceLB.SelectedIndex];
            PrikaziRadnaMesta(odabranaPoslovnaJedinica.RadnaMesta, zaposleniPoslovnaJedinicaLV);
            OsveziLager(odabranaPoslovnaJedinica.CentralniLager, centralniLagerLV);
            OsveziProdavnice();
            zaposleniProdavnicaLV.Items.Clear();
            lagerProdavnicaLV.Items.Clear();
        }

        private void dodajPoslovnuJedinicu_Click(object sender, EventArgs e)
        {
            kompanija.OtvoriPoslovnuJedinicu("Beograd");

            var poslovnaJedinica  = kompanija.PoslovneJedinice.Last();
            var artikal = new ZaledjeniProgram(179.99, "Kokosija jaja 10/1", "karton", "kom", DateTime.Now.AddDays(10));
            var artikal2 = new MlecniProizvod(89.99, "Jogurt 2.8%mm Moja kravica 1kg TT", "tetrapak", "kom", DateTime.Now.AddDays(10));
            poslovnaJedinica.CentralniLager.DodajArtikal(artikal);
            for (int i = 0; i < 20; i++)
            {
                poslovnaJedinica.CentralniLager.DodajNaStanje(artikal);
            }

            poslovnaJedinica.CentralniLager.DodajArtikal(artikal2);
            for (int i = 0; i < 30; i++)
            {
                poslovnaJedinica.CentralniLager.DodajNaStanje(artikal2);
            }

            OsveziPoslovneJedinice();
            poslvneJediniceLB.SelectedIndex = 0;
        }

        private void dodajProdavnicu_Click(object sender, EventArgs e)
        {
            odabranaPoslovnaJedinica.OtvoriProdavnicu(320, "Palmira Toljatija 5");

            var prodavnica = odabranaPoslovnaJedinica.Prodavnice.Last();
            var artikal = new Pecivo(299.99, "Sampon H&S Menthol 225ml", "PET", "kom", DateTime.Now.AddYears(10));
            var artikal2 = new VocePovrce(84.99, "Biskvit Jaffa 150g", "karton", "kom", DateTime.Now.AddDays(30));
            prodavnica.LagerUProdavnici.DodajArtikal(artikal);
            for (int i = 0; i < 20; i++)
            {
                prodavnica.LagerUProdavnici.DodajNaStanje(artikal);
            }

            prodavnica.LagerUProdavnici.DodajArtikal(artikal2);
            for (int i = 0; i < 30; i++)
            {
                prodavnica.LagerUProdavnici.DodajNaStanje(artikal2);
            }

            OsveziProdavnice();
            prodavniceLB.SelectedIndex = 0;
        }

        private void prodavniceLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaProdavnica = odabranaPoslovnaJedinica.Prodavnice[prodavniceLB.SelectedIndex];
            PrikaziRadnaMesta(odabranaProdavnica.RadnaMesta, zaposleniProdavnicaLV);
            OsveziLager(odabranaProdavnica.LagerUProdavnici, lagerProdavnicaLV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (odabranaProdavnica != null)
            {
                string naziv = centralniLagerLV.SelectedItems[0].SubItems[0].Text;
                int kolicina = (int)kolicinaZaPorucivanje.Value;

                var p = odabranaPoslovnaJedinica.CentralniLager.PronadjiArtikle(naziv, kolicina);
                odabranaPoslovnaJedinica.CentralniLager.SkiniSaStanja(p);
                odabranaProdavnica.LagerUProdavnici.DodajNaStanje(p);
                OsveziLager(odabranaProdavnica.LagerUProdavnici, lagerProdavnicaLV);
                OsveziLager(odabranaPoslovnaJedinica.CentralniLager, centralniLagerLV);
            }
        }

        private void centralniLagerLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (centralniLagerLV.SelectedItems.Count > 0)
            {
                string naziv = centralniLagerLV.SelectedItems[0].SubItems[0].Text;
                kolicinaZaPorucivanje.Maximum = odabranaPoslovnaJedinica.CentralniLager.ArtkliKolicine[naziv];
            }
            else
            {
                kolicinaZaPorucivanje.Maximum = 0;
                kolicinaZaPorucivanje.Value = 0;
            }
        }

        private void zatovriProdavnicu_Click(object sender, EventArgs e)
        {
            if (odabranaPoslovnaJedinica != null && odabranaPoslovnaJedinica.Prodavnice.Count > 0)
            {
                int index = prodavniceLB.SelectedIndex;
                odabranaPoslovnaJedinica.ZatvoriProdavnicu(index);
                OsveziProdavnice();
                lagerProdavnicaLV.Items.Clear();
                zaposleniProdavnicaLV.Items.Clear();
            }
        }
    }
}
