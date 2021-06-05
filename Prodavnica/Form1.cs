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
        }
        private void OsveziProdavnice()
        {
            prodavniceLB.Items.Clear();
            foreach (var prodavnica in odabranaPoslovnaJedinica.Prodavnice)
            {
                prodavniceLB.Items.Add(prodavnica);
            }
        }
        private void OsveziLager(Lager lager, ListBox lb)
        {
            lb.Items.Clear();
            foreach (var artikal in lager.ToStringList())
            {
                lb.Items.Add(artikal);
            }
        }

        private void poslvneJediniceLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaPoslovnaJedinica = kompanija.PoslovneJedinice[poslvneJediniceLB.SelectedIndex];
            PrikaziRadnaMesta(odabranaPoslovnaJedinica.RadnaMesta, zaposleniPoslovnaJedinicaLV);
            OsveziLager(odabranaPoslovnaJedinica.CentralniLager, centralniLagerLB);
            OsveziProdavnice();
            zaposleniProdavnicaLV.Items.Clear();
            lagerProdavnicaLB.Items.Clear();
        }

        private void dodajPoslovnuJedinicu_Click(object sender, EventArgs e)
        {
            kompanija.OtvoriPoslovnuJedinicu("kyrcojaj");
            // temp code ------------------------------------- 
            var poslovnaJedinica  = kompanija.PoslovneJedinice.Last();
            var artikal = new ZaledjeniProgram(2345, "jaje", "TVRDO", DateTime.Now.AddDays(10));
            var artikal2 = new MlecniProizvod(123, "mleko", "TVRDO", DateTime.Now.AddDays(10));
            poslovnaJedinica.CentralniLager.DodajArtikal(artikal);
            poslovnaJedinica.CentralniLager.DodajArtikal(artikal2);
            // ----------------------------------------------
            OsveziPoslovneJedinice();
            poslvneJediniceLB.SelectedIndex = 0;
        }

        private void dodajProdavnicu_Click(object sender, EventArgs e)
        {
            odabranaPoslovnaJedinica.OtvoriProdavnicu(420, "kyrcojaja");
            // temp code ------------------------------------- 
            var prodavnica = odabranaPoslovnaJedinica.Prodavnice.Last();
            var artikal = new Pecivo(13, "puding", "MEKO", DateTime.Now.AddDays(10));
            var artikal2 = new VocePovrce(43, "banan", "MEKO", DateTime.Now.AddDays(10));
            prodavnica.LagerUProdavnici.DodajArtikal(artikal);
            prodavnica.LagerUProdavnici.DodajArtikal(artikal2);
            // ----------------------------------------------
            OsveziProdavnice();
            prodavniceLB.SelectedIndex = 0;
        }

        private void prodavniceLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaProdavnica = odabranaPoslovnaJedinica.Prodavnice[prodavniceLB.SelectedIndex];
            PrikaziRadnaMesta(odabranaProdavnica.RadnaMesta, zaposleniProdavnicaLV);
            OsveziLager(odabranaProdavnica.LagerUProdavnici, lagerProdavnicaLB);
        }
    }
}
