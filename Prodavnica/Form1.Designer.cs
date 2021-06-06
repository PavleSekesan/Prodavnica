
namespace Prodavnica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.poslvneJediniceLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodavniceLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dodajProdavnicu = new System.Windows.Forms.Button();
            this.dodajPoslovnuJedinicu = new System.Windows.Forms.Button();
            this.zaposleniKompanijaLV = new System.Windows.Forms.ListView();
            this.zaposleniPoslovnaJedinicaLV = new System.Windows.Forms.ListView();
            this.zaposleniProdavnicaLV = new System.Windows.Forms.ListView();
            this.kolicinaZaPorucivanje = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.centralniLagerLV = new System.Windows.Forms.ListView();
            this.lagerProdavnicaLV = new System.Windows.Forms.ListView();
            this.zatovriProdavnicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaZaPorucivanje)).BeginInit();
            this.SuspendLayout();
            // 
            // poslvneJediniceLB
            // 
            this.poslvneJediniceLB.FormattingEnabled = true;
            this.poslvneJediniceLB.Location = new System.Drawing.Point(12, 43);
            this.poslvneJediniceLB.Name = "poslvneJediniceLB";
            this.poslvneJediniceLB.Size = new System.Drawing.Size(228, 173);
            this.poslvneJediniceLB.TabIndex = 0;
            this.poslvneJediniceLB.SelectedIndexChanged += new System.EventHandler(this.poslvneJediniceLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poslovne jedinice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodavnice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Centralni lager";
            // 
            // prodavniceLB
            // 
            this.prodavniceLB.FormattingEnabled = true;
            this.prodavniceLB.Location = new System.Drawing.Point(12, 270);
            this.prodavniceLB.Name = "prodavniceLB";
            this.prodavniceLB.Size = new System.Drawing.Size(185, 173);
            this.prodavniceLB.TabIndex = 5;
            this.prodavniceLB.SelectedIndexChanged += new System.EventHandler(this.prodavniceLB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zaposleni u poslovnoj jedinici";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zaposleni u kompaniji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Odabrana prodavnica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Zaposleni u prodavnici";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(728, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lager u prodavnici";
            // 
            // dodajProdavnicu
            // 
            this.dodajProdavnicu.Location = new System.Drawing.Point(76, 239);
            this.dodajProdavnicu.Name = "dodajProdavnicu";
            this.dodajProdavnicu.Size = new System.Drawing.Size(23, 23);
            this.dodajProdavnicu.TabIndex = 16;
            this.dodajProdavnicu.Text = "+";
            this.dodajProdavnicu.UseVisualStyleBackColor = true;
            this.dodajProdavnicu.Click += new System.EventHandler(this.dodajProdavnicu_Click);
            // 
            // dodajPoslovnuJedinicu
            // 
            this.dodajPoslovnuJedinicu.Location = new System.Drawing.Point(108, 12);
            this.dodajPoslovnuJedinicu.Name = "dodajPoslovnuJedinicu";
            this.dodajPoslovnuJedinicu.Size = new System.Drawing.Size(23, 23);
            this.dodajPoslovnuJedinicu.TabIndex = 17;
            this.dodajPoslovnuJedinicu.Text = "+";
            this.dodajPoslovnuJedinicu.UseVisualStyleBackColor = true;
            this.dodajPoslovnuJedinicu.Click += new System.EventHandler(this.dodajPoslovnuJedinicu_Click);
            // 
            // zaposleniKompanijaLV
            // 
            this.zaposleniKompanijaLV.HideSelection = false;
            this.zaposleniKompanijaLV.Location = new System.Drawing.Point(279, 43);
            this.zaposleniKompanijaLV.Name = "zaposleniKompanijaLV";
            this.zaposleniKompanijaLV.Size = new System.Drawing.Size(408, 173);
            this.zaposleniKompanijaLV.TabIndex = 18;
            this.zaposleniKompanijaLV.UseCompatibleStateImageBehavior = false;
            this.zaposleniKompanijaLV.View = System.Windows.Forms.View.Details;
            // 
            // zaposleniPoslovnaJedinicaLV
            // 
            this.zaposleniPoslovnaJedinicaLV.HideSelection = false;
            this.zaposleniPoslovnaJedinicaLV.Location = new System.Drawing.Point(279, 270);
            this.zaposleniPoslovnaJedinicaLV.Name = "zaposleniPoslovnaJedinicaLV";
            this.zaposleniPoslovnaJedinicaLV.Size = new System.Drawing.Size(408, 173);
            this.zaposleniPoslovnaJedinicaLV.TabIndex = 19;
            this.zaposleniPoslovnaJedinicaLV.UseCompatibleStateImageBehavior = false;
            this.zaposleniPoslovnaJedinicaLV.View = System.Windows.Forms.View.Details;
            // 
            // zaposleniProdavnicaLV
            // 
            this.zaposleniProdavnicaLV.HideSelection = false;
            this.zaposleniProdavnicaLV.Location = new System.Drawing.Point(277, 483);
            this.zaposleniProdavnicaLV.Name = "zaposleniProdavnicaLV";
            this.zaposleniProdavnicaLV.Size = new System.Drawing.Size(408, 173);
            this.zaposleniProdavnicaLV.TabIndex = 20;
            this.zaposleniProdavnicaLV.UseCompatibleStateImageBehavior = false;
            this.zaposleniProdavnicaLV.View = System.Windows.Forms.View.Details;
            // 
            // kolicinaZaPorucivanje
            // 
            this.kolicinaZaPorucivanje.Location = new System.Drawing.Point(1188, 270);
            this.kolicinaZaPorucivanje.Name = "kolicinaZaPorucivanje";
            this.kolicinaZaPorucivanje.Size = new System.Drawing.Size(120, 20);
            this.kolicinaZaPorucivanje.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1185, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Porucivanje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1188, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Poruci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // centralniLagerLV
            // 
            this.centralniLagerLV.HideSelection = false;
            this.centralniLagerLV.Location = new System.Drawing.Point(731, 270);
            this.centralniLagerLV.Name = "centralniLagerLV";
            this.centralniLagerLV.Size = new System.Drawing.Size(391, 173);
            this.centralniLagerLV.TabIndex = 24;
            this.centralniLagerLV.UseCompatibleStateImageBehavior = false;
            this.centralniLagerLV.View = System.Windows.Forms.View.Details;
            this.centralniLagerLV.SelectedIndexChanged += new System.EventHandler(this.centralniLagerLV_SelectedIndexChanged);
            // 
            // lagerProdavnicaLV
            // 
            this.lagerProdavnicaLV.HideSelection = false;
            this.lagerProdavnicaLV.Location = new System.Drawing.Point(731, 483);
            this.lagerProdavnicaLV.Name = "lagerProdavnicaLV";
            this.lagerProdavnicaLV.Size = new System.Drawing.Size(391, 173);
            this.lagerProdavnicaLV.TabIndex = 25;
            this.lagerProdavnicaLV.UseCompatibleStateImageBehavior = false;
            this.lagerProdavnicaLV.View = System.Windows.Forms.View.Details;
            // 
            // zatovriProdavnicu
            // 
            this.zatovriProdavnicu.Location = new System.Drawing.Point(108, 239);
            this.zatovriProdavnicu.Name = "zatovriProdavnicu";
            this.zatovriProdavnicu.Size = new System.Drawing.Size(23, 23);
            this.zatovriProdavnicu.TabIndex = 26;
            this.zatovriProdavnicu.Text = "-";
            this.zatovriProdavnicu.UseVisualStyleBackColor = true;
            this.zatovriProdavnicu.Click += new System.EventHandler(this.zatovriProdavnicu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 696);
            this.Controls.Add(this.zatovriProdavnicu);
            this.Controls.Add(this.lagerProdavnicaLV);
            this.Controls.Add(this.centralniLagerLV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kolicinaZaPorucivanje);
            this.Controls.Add(this.zaposleniProdavnicaLV);
            this.Controls.Add(this.zaposleniPoslovnaJedinicaLV);
            this.Controls.Add(this.zaposleniKompanijaLV);
            this.Controls.Add(this.dodajPoslovnuJedinicu);
            this.Controls.Add(this.dodajProdavnicu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodavniceLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poslvneJediniceLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaZaPorucivanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox poslvneJediniceLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox prodavniceLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodajProdavnicu;
        private System.Windows.Forms.Button dodajPoslovnuJedinicu;
        private System.Windows.Forms.ListView zaposleniKompanijaLV;
        private System.Windows.Forms.ListView zaposleniPoslovnaJedinicaLV;
        private System.Windows.Forms.ListView zaposleniProdavnicaLV;
        private System.Windows.Forms.NumericUpDown kolicinaZaPorucivanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView centralniLagerLV;
        private System.Windows.Forms.ListView lagerProdavnicaLV;
        private System.Windows.Forms.Button zatovriProdavnicu;
    }
}

