using System;
using System.Windows.Forms;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Class1
	{
		public Class1()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		//prebrane zaèetne vrednosti 
		public int st_sektorjev,st_vrst_sekt,st_mest_sekt,st_z_mest;
		public string []niz_sektorjev = new string [10];
		public string []sek_arena =new string [2];
		public bool doloci_sektorje=true,izracunaj=true;
		public string datum;
		public int i;
		public double cena;

		//izraèunane vrednosti
		public int st_vseh_mest,st_vseh_mest_za_sektor;
		public double vs;

		//spremeljivke za razvršèanje gledalcev glede sektorjev
		public int st_nedol_gled,st_vs_zas_sek,vs_gled_1;
		public bool vsi_sektorji_zasedeni=false;
		public int max_st_gled;
		public string max_st_gled_sek;

		//spremeljivke za iskanje
		public int []st_sektorjev_isk = new int [2];
		public int []st_vseh_mest_za_sektor_isk = new int [2];
		public int []st_vseh_mest_isk = new int [2];
		public int []st_z_mest_isk = new int [2];
		public double []cena_isk = new double [2];
		public double []vsota_isk = new double [2];
		public string datum_isk_2;
		public string []niz_sektorjev_isk = new string [10];
		public int i_isk=0;

		public void iz_mest_sek__vrst_sekt__z_mest_sekt(string a,string b)
		{
			//izraèun vseh mest za sektor in vseh mest
			st_vrst_sekt=int.Parse(a);
			st_mest_sekt=int.Parse(b);
			st_vseh_mest_za_sektor=st_vrst_sekt*st_mest_sekt;
			st_vseh_mest=st_vseh_mest_za_sektor*st_sektorjev;
		}
		public void mes_box_parametri()
		{
			MessageBox.Show("Ni parametrov za število mest sektorja","Napaka!",
				MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		public void mes_box_sektorji()
		{
			MessageBox.Show("Ni doloèenih sektorjev","Napaka",
				MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		public void mes_box_st_gled()
		{
			MessageBox.Show("Ni doloèeno število gledalcev","Napaka!",
				MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
	}
}
