using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button razporeditev_za_sektorje;
		private System.Windows.Forms.Button izbrisi_podatke;
		private System.Windows.Forms.Button izpis_vseh_podatkov;
		private System.Windows.Forms.TextBox st_vseh_mest_2;
		private System.Windows.Forms.TextBox st_mest_sektorja_2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button iz_vsa_mesta_za_sektor_2;
		private System.Windows.Forms.Button Izracunaj_vas_mesta_2;
		private System.Windows.Forms.TextBox st_mest_sektor;
		private System.Windows.Forms.TextBox st_vrst_sektor;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox vsi_sektorji;
		private System.Windows.Forms.CheckBox sektor_J;
		private System.Windows.Forms.CheckBox sektor_I;
		private System.Windows.Forms.CheckBox Sektor_G;
		private System.Windows.Forms.CheckBox Sektor_H;
		private System.Windows.Forms.CheckBox Sektor_F;
		private System.Windows.Forms.CheckBox Sektor_E;
		private System.Windows.Forms.CheckBox Sektor_D;
		private System.Windows.Forms.CheckBox Sektor_C;
		private System.Windows.Forms.CheckBox Sektor_B;
		private System.Windows.Forms.CheckBox Sektor_A;
		private System.Windows.Forms.CheckBox doloceni_sektorji;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox stevilo_gledalcev;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox cena_vstopnice;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form4()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.razporeditev_za_sektorje = new System.Windows.Forms.Button();
			this.izbrisi_podatke = new System.Windows.Forms.Button();
			this.izpis_vseh_podatkov = new System.Windows.Forms.Button();
			this.st_vseh_mest_2 = new System.Windows.Forms.TextBox();
			this.st_mest_sektorja_2 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.iz_vsa_mesta_za_sektor_2 = new System.Windows.Forms.Button();
			this.Izracunaj_vas_mesta_2 = new System.Windows.Forms.Button();
			this.st_mest_sektor = new System.Windows.Forms.TextBox();
			this.st_vrst_sektor = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.vsi_sektorji = new System.Windows.Forms.CheckBox();
			this.sektor_J = new System.Windows.Forms.CheckBox();
			this.sektor_I = new System.Windows.Forms.CheckBox();
			this.Sektor_G = new System.Windows.Forms.CheckBox();
			this.Sektor_H = new System.Windows.Forms.CheckBox();
			this.Sektor_F = new System.Windows.Forms.CheckBox();
			this.Sektor_E = new System.Windows.Forms.CheckBox();
			this.Sektor_D = new System.Windows.Forms.CheckBox();
			this.Sektor_C = new System.Windows.Forms.CheckBox();
			this.Sektor_B = new System.Windows.Forms.CheckBox();
			this.Sektor_A = new System.Windows.Forms.CheckBox();
			this.doloceni_sektorji = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.stevilo_gledalcev = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cena_vstopnice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// razporeditev_za_sektorje
			// 
			this.razporeditev_za_sektorje.Location = new System.Drawing.Point(280, 248);
			this.razporeditev_za_sektorje.Name = "razporeditev_za_sektorje";
			this.razporeditev_za_sektorje.Size = new System.Drawing.Size(216, 23);
			this.razporeditev_za_sektorje.TabIndex = 105;
			this.razporeditev_za_sektorje.Text = "razporedi gledalce glede na sektorje";
			this.razporeditev_za_sektorje.Click += new System.EventHandler(this.razporeditev_za_sektorje_Click_1);
			// 
			// izbrisi_podatke
			// 
			this.izbrisi_podatke.Location = new System.Drawing.Point(400, 288);
			this.izbrisi_podatke.Name = "izbrisi_podatke";
			this.izbrisi_podatke.Size = new System.Drawing.Size(96, 23);
			this.izbrisi_podatke.TabIndex = 104;
			this.izbrisi_podatke.Text = "Izbriši podatke";
			this.izbrisi_podatke.Click += new System.EventHandler(this.izbrisi_podatke_Click_1);
			// 
			// izpis_vseh_podatkov
			// 
			this.izpis_vseh_podatkov.Location = new System.Drawing.Point(280, 288);
			this.izpis_vseh_podatkov.Name = "izpis_vseh_podatkov";
			this.izpis_vseh_podatkov.Size = new System.Drawing.Size(96, 23);
			this.izpis_vseh_podatkov.TabIndex = 102;
			this.izpis_vseh_podatkov.Text = "Izpiši podatke";
			this.izpis_vseh_podatkov.Click += new System.EventHandler(this.izpis_vseh_podatkov_Click);
			// 
			// st_vseh_mest_2
			// 
			this.st_vseh_mest_2.Location = new System.Drawing.Point(384, 160);
			this.st_vseh_mest_2.Name = "st_vseh_mest_2";
			this.st_vseh_mest_2.ReadOnly = true;
			this.st_vseh_mest_2.Size = new System.Drawing.Size(56, 20);
			this.st_vseh_mest_2.TabIndex = 101;
			this.st_vseh_mest_2.Text = "";
			// 
			// st_mest_sektorja_2
			// 
			this.st_mest_sektorja_2.Location = new System.Drawing.Point(384, 128);
			this.st_mest_sektorja_2.Name = "st_mest_sektorja_2";
			this.st_mest_sektorja_2.ReadOnly = true;
			this.st_mest_sektorja_2.Size = new System.Drawing.Size(56, 20);
			this.st_mest_sektorja_2.TabIndex = 100;
			this.st_mest_sektorja_2.Text = "";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label14.Location = new System.Drawing.Point(240, 160);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(136, 16);
			this.label14.TabIndex = 99;
			this.label14.Text = "Število vseh mest:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label15.Location = new System.Drawing.Point(240, 128);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(136, 24);
			this.label15.TabIndex = 98;
			this.label15.Text = "Število mest za sektor:";
			// 
			// iz_vsa_mesta_za_sektor_2
			// 
			this.iz_vsa_mesta_za_sektor_2.Location = new System.Drawing.Point(448, 128);
			this.iz_vsa_mesta_za_sektor_2.Name = "iz_vsa_mesta_za_sektor_2";
			this.iz_vsa_mesta_za_sektor_2.Size = new System.Drawing.Size(96, 23);
			this.iz_vsa_mesta_za_sektor_2.TabIndex = 97;
			this.iz_vsa_mesta_za_sektor_2.Text = "Izraèunaj";
			this.iz_vsa_mesta_za_sektor_2.Click += new System.EventHandler(this.iz_vsa_mesta_za_sektor_2_Click_1);
			// 
			// Izracunaj_vas_mesta_2
			// 
			this.Izracunaj_vas_mesta_2.Location = new System.Drawing.Point(448, 160);
			this.Izracunaj_vas_mesta_2.Name = "Izracunaj_vas_mesta_2";
			this.Izracunaj_vas_mesta_2.Size = new System.Drawing.Size(96, 23);
			this.Izracunaj_vas_mesta_2.TabIndex = 96;
			this.Izracunaj_vas_mesta_2.Text = "Izraèunaj";
			this.Izracunaj_vas_mesta_2.Click += new System.EventHandler(this.Izracunaj_vas_mesta_2_Click_1);
			// 
			// st_mest_sektor
			// 
			this.st_mest_sektor.Location = new System.Drawing.Point(472, 96);
			this.st_mest_sektor.Name = "st_mest_sektor";
			this.st_mest_sektor.Size = new System.Drawing.Size(56, 20);
			this.st_mest_sektor.TabIndex = 95;
			this.st_mest_sektor.Text = "";
			this.st_mest_sektor.TextChanged += new System.EventHandler(this.st_mest_sektor_TextChanged_1);
			// 
			// st_vrst_sektor
			// 
			this.st_vrst_sektor.Location = new System.Drawing.Point(472, 64);
			this.st_vrst_sektor.Name = "st_vrst_sektor";
			this.st_vrst_sektor.Size = new System.Drawing.Size(56, 20);
			this.st_vrst_sektor.TabIndex = 94;
			this.st_vrst_sektor.Text = "";
			this.st_vrst_sektor.TextChanged += new System.EventHandler(this.st_vrst_sektor_TextChanged_1);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label13.Location = new System.Drawing.Point(344, 96);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(128, 16);
			this.label13.TabIndex = 93;
			this.label13.Text = "Število mest za vrsto:";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label11.Location = new System.Drawing.Point(344, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(128, 24);
			this.label11.TabIndex = 92;
			this.label11.Text = "Število vrst za sektor:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label3.Location = new System.Drawing.Point(16, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(368, 24);
			this.label3.TabIndex = 91;
			this.label3.Text = "Doloèi datum ceno vstopnice in število gledalcev:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(24, 240);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.TabIndex = 90;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label2.Location = new System.Drawing.Point(344, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 24);
			this.label2.TabIndex = 89;
			this.label2.Text = "Doloèi mesta:";
			// 
			// vsi_sektorji
			// 
			this.vsi_sektorji.Location = new System.Drawing.Point(16, 56);
			this.vsi_sektorji.Name = "vsi_sektorji";
			this.vsi_sektorji.TabIndex = 88;
			this.vsi_sektorji.Text = "vsi sektorji";
			this.vsi_sektorji.CheckedChanged += new System.EventHandler(this.vsi_sektorji_CheckedChanged_1);
			// 
			// sektor_J
			// 
			this.sektor_J.Enabled = false;
			this.sektor_J.Location = new System.Drawing.Point(208, 96);
			this.sektor_J.Name = "sektor_J";
			this.sektor_J.Size = new System.Drawing.Size(32, 24);
			this.sektor_J.TabIndex = 87;
			this.sektor_J.Text = "J";
			this.sektor_J.CheckedChanged += new System.EventHandler(this.sektor_J_CheckedChanged);
			// 
			// sektor_I
			// 
			this.sektor_I.Enabled = false;
			this.sektor_I.Location = new System.Drawing.Point(160, 96);
			this.sektor_I.Name = "sektor_I";
			this.sektor_I.Size = new System.Drawing.Size(32, 24);
			this.sektor_I.TabIndex = 86;
			this.sektor_I.Text = "I";
			this.sektor_I.CheckedChanged += new System.EventHandler(this.sektor_I_CheckedChanged);
			// 
			// Sektor_G
			// 
			this.Sektor_G.Location = new System.Drawing.Point(16, 160);
			this.Sektor_G.Name = "Sektor_G";
			this.Sektor_G.Size = new System.Drawing.Size(32, 24);
			this.Sektor_G.TabIndex = 85;
			this.Sektor_G.Text = "G";
			this.Sektor_G.CheckedChanged += new System.EventHandler(this.Sektor_G_CheckedChanged);
			// 
			// Sektor_H
			// 
			this.Sektor_H.Location = new System.Drawing.Point(64, 160);
			this.Sektor_H.Name = "Sektor_H";
			this.Sektor_H.Size = new System.Drawing.Size(32, 24);
			this.Sektor_H.TabIndex = 84;
			this.Sektor_H.Text = "H";
			this.Sektor_H.CheckedChanged += new System.EventHandler(this.Sektor_H_CheckedChanged);
			// 
			// Sektor_F
			// 
			this.Sektor_F.Location = new System.Drawing.Point(112, 128);
			this.Sektor_F.Name = "Sektor_F";
			this.Sektor_F.Size = new System.Drawing.Size(32, 24);
			this.Sektor_F.TabIndex = 83;
			this.Sektor_F.Text = "F";
			this.Sektor_F.CheckedChanged += new System.EventHandler(this.Sektor_F_CheckedChanged);
			// 
			// Sektor_E
			// 
			this.Sektor_E.Location = new System.Drawing.Point(64, 128);
			this.Sektor_E.Name = "Sektor_E";
			this.Sektor_E.Size = new System.Drawing.Size(32, 24);
			this.Sektor_E.TabIndex = 82;
			this.Sektor_E.Text = "E";
			this.Sektor_E.CheckedChanged += new System.EventHandler(this.Sektor_E_CheckedChanged);
			// 
			// Sektor_D
			// 
			this.Sektor_D.Location = new System.Drawing.Point(16, 128);
			this.Sektor_D.Name = "Sektor_D";
			this.Sektor_D.Size = new System.Drawing.Size(32, 24);
			this.Sektor_D.TabIndex = 81;
			this.Sektor_D.Text = "D";
			this.Sektor_D.CheckedChanged += new System.EventHandler(this.Sektor_D_CheckedChanged);
			// 
			// Sektor_C
			// 
			this.Sektor_C.Location = new System.Drawing.Point(112, 96);
			this.Sektor_C.Name = "Sektor_C";
			this.Sektor_C.Size = new System.Drawing.Size(32, 24);
			this.Sektor_C.TabIndex = 80;
			this.Sektor_C.Text = "C";
			this.Sektor_C.CheckedChanged += new System.EventHandler(this.Sektor_C_CheckedChanged);
			// 
			// Sektor_B
			// 
			this.Sektor_B.Location = new System.Drawing.Point(64, 96);
			this.Sektor_B.Name = "Sektor_B";
			this.Sektor_B.Size = new System.Drawing.Size(32, 24);
			this.Sektor_B.TabIndex = 79;
			this.Sektor_B.Text = "B";
			this.Sektor_B.CheckedChanged += new System.EventHandler(this.Sektor_B_CheckedChanged);
			// 
			// Sektor_A
			// 
			this.Sektor_A.Location = new System.Drawing.Point(16, 96);
			this.Sektor_A.Name = "Sektor_A";
			this.Sektor_A.Size = new System.Drawing.Size(32, 24);
			this.Sektor_A.TabIndex = 78;
			this.Sektor_A.Text = "A";
			this.Sektor_A.CheckedChanged += new System.EventHandler(this.Sektor_A_CheckedChanged);
			// 
			// doloceni_sektorji
			// 
			this.doloceni_sektorji.Location = new System.Drawing.Point(160, 56);
			this.doloceni_sektorji.Name = "doloceni_sektorji";
			this.doloceni_sektorji.Size = new System.Drawing.Size(144, 24);
			this.doloceni_sektorji.TabIndex = 77;
			this.doloceni_sektorji.Text = "doloèi sektorje v areni";
			this.doloceni_sektorji.CheckedChanged += new System.EventHandler(this.doloceni_sektorji_CheckedChanged_1);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label7.Location = new System.Drawing.Point(16, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 24);
			this.label7.TabIndex = 76;
			this.label7.Text = "Izberi sektorje:";
			// 
			// stevilo_gledalcev
			// 
			this.stevilo_gledalcev.Location = new System.Drawing.Point(144, 312);
			this.stevilo_gledalcev.Name = "stevilo_gledalcev";
			this.stevilo_gledalcev.Size = new System.Drawing.Size(56, 20);
			this.stevilo_gledalcev.TabIndex = 75;
			this.stevilo_gledalcev.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label5.Location = new System.Drawing.Point(24, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 24);
			this.label5.TabIndex = 74;
			this.label5.Text = "Število gledalcev:";
			// 
			// cena_vstopnice
			// 
			this.cena_vstopnice.Location = new System.Drawing.Point(144, 280);
			this.cena_vstopnice.Name = "cena_vstopnice";
			this.cena_vstopnice.Size = new System.Drawing.Size(56, 20);
			this.cena_vstopnice.TabIndex = 73;
			this.cena_vstopnice.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label4.Location = new System.Drawing.Point(24, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 24);
			this.label4.TabIndex = 72;
			this.label4.Text = "Cena vstopnice:";
			// 
			// Form4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 390);
			this.Controls.Add(this.razporeditev_za_sektorje);
			this.Controls.Add(this.izbrisi_podatke);
			this.Controls.Add(this.izpis_vseh_podatkov);
			this.Controls.Add(this.st_vseh_mest_2);
			this.Controls.Add(this.st_mest_sektorja_2);
			this.Controls.Add(this.st_mest_sektor);
			this.Controls.Add(this.st_vrst_sektor);
			this.Controls.Add(this.stevilo_gledalcev);
			this.Controls.Add(this.cena_vstopnice);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.iz_vsa_mesta_za_sektor_2);
			this.Controls.Add(this.Izracunaj_vas_mesta_2);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.vsi_sektorji);
			this.Controls.Add(this.sektor_J);
			this.Controls.Add(this.sektor_I);
			this.Controls.Add(this.Sektor_G);
			this.Controls.Add(this.Sektor_H);
			this.Controls.Add(this.Sektor_F);
			this.Controls.Add(this.Sektor_E);
			this.Controls.Add(this.Sektor_D);
			this.Controls.Add(this.Sektor_C);
			this.Controls.Add(this.Sektor_B);
			this.Controls.Add(this.Sektor_A);
			this.Controls.Add(this.doloceni_sektorji);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Name = "Form4";
			this.Text = "Vpis podatkov";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public Class1 _1 = new Class1();

		Form2 form2 = new Form2();
		Form3 form3 = new Form3();
		public void iz_stevila_sektorjev()
		{
			_1.i=0;
			_1.st_sektorjev=0;
			for(int s=0;s<10;s++)
			{
				_1.niz_sektorjev[s]="";
			}
			if(Sektor_A.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="A";
				_1.i++;
			}
			if(Sektor_B.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="B";
				_1.i++;
			}
			if(Sektor_C.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="C";
				_1.i++;
			}
			if(Sektor_D.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="D";
				_1.i++;
			}
			if(Sektor_E.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="E";
				_1.i++;
			}
			if(Sektor_F.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="F";
				_1.i++;
			}
			if(Sektor_G.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="G";
				_1.i++;
			}
			if(Sektor_H.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="H";
				_1.i++;
			}
			if(sektor_I.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="I";
				_1.i++;
			}
			if(sektor_J.Checked==true)
			{
				_1.st_sektorjev+=1;
				_1.niz_sektorjev[_1.i]="J";
				_1.i++;
			}
		}
		public void dol_sek_arena()
		{
			for(int k=0;k<2;k++)
			{
				_1.sek_arena[k]="";
			}
			int j=0;
			if(sektor_I.Checked==true)
			{
				_1.sek_arena[j]="I";
				j++;
			}
			if(sektor_J.Checked==true)
			{
				_1.sek_arena[j]="J";
				j++;
			}
		}		

		private void vsi_sektorji_CheckedChanged_1(object sender, System.EventArgs e)
		{
			if(vsi_sektorji.Checked==true)
			{
				Sektor_A.Checked=true;
				Sektor_B.Checked=true;
				Sektor_C.Checked=true;
				Sektor_D.Checked=true;
				Sektor_E.Checked=true;
				Sektor_F.Checked=true;
				Sektor_G.Checked=true;
				Sektor_H.Checked=true;
				if(doloceni_sektorji.Checked==true)
				{
					sektor_I.Checked=true;
					sektor_J.Checked=true;
				}
			}
		}

		private void doloceni_sektorji_CheckedChanged_1(object sender, System.EventArgs e)
		{
		
			if(_1.doloci_sektorje)
			{
				sektor_I.Enabled=true;
				sektor_J.Enabled=true;
				_1.doloci_sektorje=false;
			}
			else
			{
				sektor_I.Enabled=false;
				sektor_J.Enabled=false;
				if(sektor_I.Checked==true||sektor_J.Checked==true)
				{
					sektor_I.Checked=false;
					sektor_J.Checked=false;
				}
				_1.doloci_sektorje=true;
			}
		}

		private void iz_vsa_mesta_za_sektor_2_Click_1(object sender, System.EventArgs e)
		{
			//izraèun in izpis vseh mest za sektor
			if(st_vrst_sektor.Text!=""&&st_mest_sektor.Text!="")
			{
				_1.iz_mest_sek__vrst_sekt__z_mest_sekt(st_vrst_sektor.Text,st_mest_sektor.Text);
				st_mest_sektorja_2.Text=Convert.ToString(_1.st_vseh_mest_za_sektor);
				iz_vsa_mesta_za_sektor_2.Enabled=false;
			}
			else
			{
				_1.mes_box_parametri();
			}
		}

		private void Izracunaj_vas_mesta_2_Click_1(object sender, System.EventArgs e)
		{
			iz_stevila_sektorjev();
			//izraèun in izpis vseh mest
			if(st_vrst_sektor.Text!=""&&st_mest_sektor.Text!=""&&_1.st_sektorjev!=0)
			{
				iz_stevila_sektorjev();
				_1.iz_mest_sek__vrst_sekt__z_mest_sekt(st_vrst_sektor.Text,st_mest_sektor.Text);
				st_vseh_mest_2.Text=Convert.ToString(_1.st_vseh_mest);
				Izracunaj_vas_mesta_2.Enabled=false;
			}
			else if(_1.st_sektorjev==0)
			{
				_1.mes_box_sektorji();
			}
			else
			{
				_1.mes_box_parametri();
			}
		}

		private void razporeditev_za_sektorje_Click_1(object sender, System.EventArgs e)
		{
			//preverjanje doloèenosti sektorjev
			if(Sektor_A.Checked==false&&Sektor_B.Checked==false&&Sektor_C.Checked==false&&Sektor_D.Checked==false&&Sektor_E.Checked==false&&Sektor_F.Checked==false&&Sektor_G.Checked==false&&Sektor_H.Checked==false&&sektor_I.Checked==false&&sektor_J.Checked==false)
			{
				_1.mes_box_sektorji();
				_1.izracunaj=false;
			}
			//preverjanje izbire vrst in mest za sektor
			else if(st_vrst_sektor.Text==""||st_mest_sektor.Text=="")
			{
				_1.mes_box_parametri();
				_1.izracunaj=false;
			}
			//preverjenje doloèenosti gledalcev
			else if(stevilo_gledalcev.Text=="")
			{
				_1.mes_box_st_gled();
				_1.izracunaj=false;
			}
			else
			{
				iz_stevila_sektorjev();
				_1.iz_mest_sek__vrst_sekt__z_mest_sekt(st_vrst_sektor.Text,st_mest_sektor.Text);
				_1.st_z_mest=int.Parse(stevilo_gledalcev.Text);				
			}
			//v primeru èe so vsa mesta zasedena
			if(_1.st_z_mest>=_1.st_vseh_mest&&_1.st_vseh_mest!=0)
			{
				MessageBox.Show("Vsi sektorji so zasedeni","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				stevilo_gledalcev.Text=Convert.ToString(_1.st_vseh_mest);
				_1.vsi_sektorji_zasedeni=true;	
			}
			if(_1.izracunaj)
			{
				form2.i=_1.i;
				form2.niz_sektorjev=_1.niz_sektorjev;
				form2.st_z_mest=_1.st_z_mest;
				form2.st_vseh_mest_za_sektor=_1.st_vseh_mest_za_sektor;
				form2.vsi_sektorji_zasedeni=_1.vsi_sektorji_zasedeni;
				form2.ShowDialog();
			}
			_1.izracunaj=true;
		}

		private void izpis_vseh_podatkov_Click(object sender, System.EventArgs e)
		{
			_1.st_sektorjev=0;_1.st_vseh_mest=0;_1.st_vseh_mest_za_sektor=0;_1.st_z_mest=0;_1.st_vrst_sekt=0;_1.st_mest_sekt=0;
			_1.datum="";
			_1.cena=0; _1.vs=0;
			//preverjanje doloèenosti sektorjev
			if(Sektor_A.Checked==false&&Sektor_B.Checked==false&&Sektor_C.Checked==false&&Sektor_D.Checked==false&&Sektor_E.Checked==false&&Sektor_F.Checked==false&&Sektor_G.Checked==false&&Sektor_H.Checked==false&&sektor_I.Checked==false&&sektor_J.Checked==false)
			{
				_1.mes_box_sektorji();
				_1.izracunaj=false;
			}
				//preverjanje izbire vrst in mest za sektor
			else if(st_vrst_sektor.Text==""||st_mest_sektor.Text=="")
			{
				_1.mes_box_parametri();
				_1.izracunaj=false;
			}
				//preverjenje doloèenosti gledalcev
			else if(stevilo_gledalcev.Text=="")
			{
				_1.mes_box_st_gled();
				_1.izracunaj=false;	
			}
				//preverjanje doloèenosti cene
			else if(cena_vstopnice.Text=="")
			{
				MessageBox.Show("Ni doloèena cena vstopnice","Napaka!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				_1.izracunaj=false;
			}
			//Èe ni napak se podatki izraèunajo
			if(_1.izracunaj)
			{
				iz_stevila_sektorjev();
				dol_sek_arena();
				_1.iz_mest_sek__vrst_sekt__z_mest_sekt(st_vrst_sektor.Text,st_mest_sektor.Text);

				//zasedena mesta
				_1.st_z_mest=int.Parse(stevilo_gledalcev.Text);
				
				//izraèun zasedenih mest v primeru èe so vsa mesta zasedena
				if(_1.st_z_mest>=_1.st_vseh_mest)
				{
					_1.st_z_mest=_1.st_vseh_mest;
					stevilo_gledalcev.Text=Convert.ToString(_1.st_vseh_mest);
				}
				//izraèun cene v primeru èe so vsa mesta zasedena
				_1.cena=double.Parse(cena_vstopnice.Text);
				if(_1.st_z_mest>=_1.st_vseh_mest)
				{
					_1.vs=_1.st_vseh_mest*_1.cena;
				}
					//izraèun cene v primeru èe vsa mesta niso zasedena
				else
				{
					_1.vs=_1.st_z_mest*_1.cena;
				}
				//shrani datum
				_1.datum=dateTimePicker1.Text;
				//prenos spremeljivk
				form3.st_sektorjev=_1.st_sektorjev;
				form3.st_vseh_mest=_1.st_vseh_mest;
				form3.st_z_mest=_1.st_z_mest;
				form3.vs=_1.vs;
				form3.datum=_1.datum;
				form3.sek_arena=_1.sek_arena;
				form3.niz_sektorjev=_1.niz_sektorjev;
				form3.st_mest_za_sektor=_1.st_vseh_mest_za_sektor;
				form3.cena=_1.cena;
				form3.ShowDialog();
			}
			_1.izracunaj=true;
		}

		private void st_vrst_sektor_TextChanged_1(object sender, System.EventArgs e)
		{
			iz_vsa_mesta_za_sektor_2.Enabled=true;
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void st_mest_sektor_TextChanged_1(object sender, System.EventArgs e)
		{
			iz_vsa_mesta_za_sektor_2.Enabled=true;
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void izbrisi_podatke_Click_1(object sender, System.EventArgs e)
		{
			vsi_sektorji.Checked=false;
			Sektor_A.Checked=false;
			Sektor_B.Checked=false;
			Sektor_C.Checked=false;
			Sektor_D.Checked=false;
			Sektor_E.Checked=false;
			Sektor_F.Checked=false;
			Sektor_G.Checked=false;
			Sektor_H.Checked=false;
			doloceni_sektorji.Checked=false;

			st_vrst_sektor.Text="";
			st_mest_sektor.Text="";

			st_mest_sektorja_2.Text="";
			st_vseh_mest_2.Text="";

			cena_vstopnice.Text="";
			stevilo_gledalcev.Text="";

			_1.st_sektorjev=0; _1.st_vrst_sekt=0; _1.st_mest_sekt=0; _1.st_z_mest=0;
			for(int k=0;k<10;k++)
			{
				_1.niz_sektorjev[k]="";
			}
			for(int k=0;k<2;k++)
			{
				_1.sek_arena[k]="";
			}
			_1.doloci_sektorje=true; _1.izracunaj=true; _1.datum=""; _1.cena=0;

			_1.st_vseh_mest=0; _1.st_vseh_mest_za_sektor=0; _1.vs=0;

			dateTimePicker1.Text=DateTime.Now.ToString();
		}

		
		private void Sektor_A_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_B_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_C_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_D_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_E_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_F_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_G_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Sektor_H_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void sektor_I_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void sektor_J_CheckedChanged(object sender, System.EventArgs e)
		{
			Izracunaj_vas_mesta_2.Enabled=true;
		}

		private void Form4_Load(object sender, System.EventArgs e)
		{
			dateTimePicker1.Text=DateTime.Now.ToString();
		}
	}
}
