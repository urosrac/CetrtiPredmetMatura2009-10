using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button shrani_podatke;
		private System.Windows.Forms.Button izpisi_podatke;
		private System.Windows.Forms.TextBox vsota;
		private System.Windows.Forms.TextBox iz_zas_mesta;
		private System.Windows.Forms.TextBox iz_mesta;
		private System.Windows.Forms.TextBox iz_sektorji;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox iz_sek_arene;
		private System.Windows.Forms.TextBox iz_datum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox iz_sektorjev_;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox st_mest_sek_;
		private System.Windows.Forms.TextBox iz_cena;
		private System.Windows.Forms.Label label5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbConnection con_2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
		public Class1 _2 = new Class1();
		
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.shrani_podatke = new System.Windows.Forms.Button();
			this.izpisi_podatke = new System.Windows.Forms.Button();
			this.vsota = new System.Windows.Forms.TextBox();
			this.iz_zas_mesta = new System.Windows.Forms.TextBox();
			this.iz_mesta = new System.Windows.Forms.TextBox();
			this.iz_sektorji = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.iz_sek_arene = new System.Windows.Forms.TextBox();
			this.iz_datum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.iz_sektorjev_ = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.st_mest_sek_ = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.iz_cena = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.con_2 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.SuspendLayout();
			// 
			// shrani_podatke
			// 
			this.shrani_podatke.Location = new System.Drawing.Point(128, 200);
			this.shrani_podatke.Name = "shrani_podatke";
			this.shrani_podatke.Size = new System.Drawing.Size(96, 23);
			this.shrani_podatke.TabIndex = 61;
			this.shrani_podatke.Text = "shrani podatke";
			this.shrani_podatke.Click += new System.EventHandler(this.shrani_podatke_Click);
			// 
			// izpisi_podatke
			// 
			this.izpisi_podatke.Location = new System.Drawing.Point(24, 200);
			this.izpisi_podatke.Name = "izpisi_podatke";
			this.izpisi_podatke.Size = new System.Drawing.Size(88, 23);
			this.izpisi_podatke.TabIndex = 60;
			this.izpisi_podatke.Text = "Izpiši podatke";
			this.izpisi_podatke.Click += new System.EventHandler(this.izpisi_podatke_Click);
			// 
			// vsota
			// 
			this.vsota.Location = new System.Drawing.Point(296, 192);
			this.vsota.Name = "vsota";
			this.vsota.ReadOnly = true;
			this.vsota.Size = new System.Drawing.Size(120, 20);
			this.vsota.TabIndex = 59;
			this.vsota.Text = "";
			// 
			// iz_zas_mesta
			// 
			this.iz_zas_mesta.Location = new System.Drawing.Point(160, 152);
			this.iz_zas_mesta.Name = "iz_zas_mesta";
			this.iz_zas_mesta.ReadOnly = true;
			this.iz_zas_mesta.Size = new System.Drawing.Size(56, 20);
			this.iz_zas_mesta.TabIndex = 58;
			this.iz_zas_mesta.Text = "";
			// 
			// iz_mesta
			// 
			this.iz_mesta.Location = new System.Drawing.Point(128, 112);
			this.iz_mesta.Name = "iz_mesta";
			this.iz_mesta.ReadOnly = true;
			this.iz_mesta.Size = new System.Drawing.Size(56, 20);
			this.iz_mesta.TabIndex = 57;
			this.iz_mesta.Text = "";
			// 
			// iz_sektorji
			// 
			this.iz_sektorji.Location = new System.Drawing.Point(128, 32);
			this.iz_sektorji.Name = "iz_sektorji";
			this.iz_sektorji.ReadOnly = true;
			this.iz_sektorji.Size = new System.Drawing.Size(56, 20);
			this.iz_sektorji.TabIndex = 56;
			this.iz_sektorji.Text = "";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label12.Location = new System.Drawing.Point(248, 192);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 24);
			this.label12.TabIndex = 55;
			this.label12.Text = "Vsota:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label10.Location = new System.Drawing.Point(16, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 24);
			this.label10.TabIndex = 54;
			this.label10.Text = "Število zasedenih mest:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label8.Location = new System.Drawing.Point(16, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 53;
			this.label8.Text = "Število mest:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label9.Location = new System.Drawing.Point(16, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 24);
			this.label9.TabIndex = 52;
			this.label9.Text = "Število sektorjev:";
			// 
			// iz_sek_arene
			// 
			this.iz_sek_arene.Location = new System.Drawing.Point(336, 112);
			this.iz_sek_arene.Name = "iz_sek_arene";
			this.iz_sek_arene.ReadOnly = true;
			this.iz_sek_arene.Size = new System.Drawing.Size(104, 20);
			this.iz_sek_arene.TabIndex = 65;
			this.iz_sek_arene.Text = "";
			// 
			// iz_datum
			// 
			this.iz_datum.Location = new System.Drawing.Point(288, 32);
			this.iz_datum.Name = "iz_datum";
			this.iz_datum.ReadOnly = true;
			this.iz_datum.Size = new System.Drawing.Size(128, 20);
			this.iz_datum.TabIndex = 64;
			this.iz_datum.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label1.Location = new System.Drawing.Point(240, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 63;
			this.label1.Text = "Sektorji v areni:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label2.Location = new System.Drawing.Point(232, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 24);
			this.label2.TabIndex = 62;
			this.label2.Text = "Datum:";
			// 
			// iz_sektorjev_
			// 
			this.iz_sektorjev_.Location = new System.Drawing.Point(344, 72);
			this.iz_sektorjev_.Name = "iz_sektorjev_";
			this.iz_sektorjev_.ReadOnly = true;
			this.iz_sektorjev_.Size = new System.Drawing.Size(96, 20);
			this.iz_sektorjev_.TabIndex = 67;
			this.iz_sektorjev_.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label3.Location = new System.Drawing.Point(232, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 24);
			this.label3.TabIndex = 66;
			this.label3.Text = "Doloèeni sektorji:";
			// 
			// st_mest_sek_
			// 
			this.st_mest_sek_.Location = new System.Drawing.Point(152, 72);
			this.st_mest_sek_.Name = "st_mest_sek_";
			this.st_mest_sek_.ReadOnly = true;
			this.st_mest_sek_.Size = new System.Drawing.Size(56, 20);
			this.st_mest_sek_.TabIndex = 69;
			this.st_mest_sek_.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 24);
			this.label4.TabIndex = 68;
			this.label4.Text = "Število mest za sektor:";
			// 
			// iz_cena
			// 
			this.iz_cena.Location = new System.Drawing.Point(296, 152);
			this.iz_cena.Name = "iz_cena";
			this.iz_cena.ReadOnly = true;
			this.iz_cena.Size = new System.Drawing.Size(120, 20);
			this.iz_cena.TabIndex = 71;
			this.iz_cena.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label5.Location = new System.Drawing.Point(248, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 70;
			this.label5.Text = "Cena:";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "sektorji_2", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																					  new System.Data.Common.DataColumnMapping("St_sektorjev", "St_sektorjev"),
																																																					  new System.Data.Common.DataColumnMapping("St_mest_za_sektor", "St_mest_za_sektor"),
																																																					  new System.Data.Common.DataColumnMapping("St_vseh_mest", "St_vseh_mest"),
																																																					  new System.Data.Common.DataColumnMapping("St_zasedenih_mest", "St_zasedenih_mest"),
																																																					  new System.Data.Common.DataColumnMapping("Doloceni_sektorji", "Doloceni_sektorji"),
																																																					  new System.Data.Common.DataColumnMapping("Sektorji_v_areni", "Sektorji_v_areni"),
																																																					  new System.Data.Common.DataColumnMapping("Datum", "Datum"),
																																																					  new System.Data.Common.DataColumnMapping("Cena", "Cena"),
																																																					  new System.Data.Common.DataColumnMapping("Vsota", "Vsota")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM sektorji_2 WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.con_2;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			// 
			// con_2
			// 
			this.con_2.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""C:\Vodenje športne dvorane\sportna_dvorana.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO sektorji_2(St_sektorjev, St_mest_za_sektor, St_vseh_mest, St_zasedeni" +
				"h_mest, Doloceni_sektorji, Sektorji_v_areni, Datum, Cena, Vsota) VALUES (?, ?, ?" +
				", ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.con_2;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, "St_sektorjev"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, "St_mest_za_sektor"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_vseh_mest"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_zasedenih_mest"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, "Doloceni_sektorji"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, "Sektorji_v_areni"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Datum", System.Data.OleDb.OleDbType.VarWChar, 30, "Datum"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cena", System.Data.OleDb.OleDbType.Double, 0, "Cena"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vsota", System.Data.OleDb.OleDbType.Double, 0, "Vsota"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT ID, St_sektorjev, St_mest_za_sektor, St_vseh_mest, St_zasedenih_mest, Dolo" +
				"ceni_sektorji, Sektorji_v_areni, Datum, Cena, Vsota FROM sektorji_2";
			this.oleDbSelectCommand1.Connection = this.con_2;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE sektorji_2 SET St_sektorjev = ?, St_mest_za_sektor = ?, St_vseh_mest = ?, St_zasedenih_mest = ?, Doloceni_sektorji = ?, Sektorji_v_areni = ?, Datum = ?, Cena = ?, Vsota = ? WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.con_2;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, "St_sektorjev"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, "St_mest_za_sektor"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_vseh_mest"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_zasedenih_mest"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, "Doloceni_sektorji"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, "Sektorji_v_areni"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Datum", System.Data.OleDb.OleDbType.VarWChar, 30, "Datum"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cena", System.Data.OleDb.OleDbType.Double, 0, "Cena"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vsota", System.Data.OleDb.OleDbType.Double, 0, "Vsota"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 254);
			this.Controls.Add(this.iz_cena);
			this.Controls.Add(this.st_mest_sek_);
			this.Controls.Add(this.iz_sektorjev_);
			this.Controls.Add(this.iz_sek_arene);
			this.Controls.Add(this.iz_datum);
			this.Controls.Add(this.vsota);
			this.Controls.Add(this.iz_zas_mesta);
			this.Controls.Add(this.iz_mesta);
			this.Controls.Add(this.iz_sektorji);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.shrani_podatke);
			this.Controls.Add(this.izpisi_podatke);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Name = "Form3";
			this.Text = "Izpis podatkov";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public int st_sektorjev
		{
			set{_2.st_sektorjev=value;}
		}
		public int st_vseh_mest
		{
			set{_2.st_vseh_mest=value;}
		}
		public int st_z_mest
		{
			set{_2.st_z_mest=value;}
		}
		public double vs
		{
			set{_2.vs=value;}
		}
		public string datum
		{
			set{_2.datum=value;}
		}
		public string []sek_arena
		{
			set{_2.sek_arena=value;}
		}
		public string []niz_sektorjev
		{
			set{_2.niz_sektorjev=value;}
		}
		public int st_mest_za_sektor
		{
			set{_2.st_vseh_mest_za_sektor=value;}
		}
		public double cena
		{
			set{_2.cena=value;}
		}

		private void izpisi_podatke_Click(object sender, System.EventArgs e)
		{
			shrani_podatke.Enabled=true;
			
			_2.cena=Convert.ToDouble(_2.vs)/Convert.ToDouble(_2.st_z_mest);
			iz_sektorji.Text=_2.st_sektorjev.ToString();
			iz_mesta.Text=_2.st_vseh_mest.ToString();
			iz_zas_mesta.Text=_2.st_z_mest.ToString();
			vsota.Text=_2.vs.ToString();
			iz_datum.Text=_2.datum;
			if(_2.sek_arena[0]!="I"&&_2.sek_arena[0]!="J")
			{
				iz_sek_arene.Text="Ni sektorjev v areni";
			}
			else
			{
				iz_sek_arene.Text=_2.sek_arena[0]+" "+_2.sek_arena[1];
			}
			iz_sektorjev_.Text=_2.niz_sektorjev[0]+" "+_2.niz_sektorjev[1]+" "+_2.niz_sektorjev[2]+" "+_2.niz_sektorjev[3]+" "+_2.niz_sektorjev[4]+" "+_2.niz_sektorjev[5]+" "+_2.niz_sektorjev[6]+" "+_2.niz_sektorjev[7]+" "+_2.niz_sektorjev[8]+" "+_2.niz_sektorjev[9];
			st_mest_sek_.Text=_2.st_vseh_mest_za_sektor.ToString();
			iz_cena.Text=_2.cena.ToString();
		}

		private void Form3_Load(object sender, System.EventArgs e)
		{
			shrani_podatke.Enabled=false;
			iz_sektorji.Text="";
			iz_mesta.Text="";
			iz_zas_mesta.Text="";
			vsota.Text="";
			iz_datum.Text="";
			iz_sek_arene.Text="";
			iz_sektorjev_.Text="";
			iz_cena.Text="";
			st_mest_sek_.Text="";
		}

		private void shrani_podatke_Click(object sender, System.EventArgs e)
		{
			con_2.Open();
			oleDbInsertCommand1.Parameters["St_sektorjev"].Value =_2.st_sektorjev;
			oleDbInsertCommand1.Parameters["St_mest_za_sektor"].Value =_2.st_vseh_mest_za_sektor;
			oleDbInsertCommand1.Parameters["St_vseh_mest"].Value =_2.st_vseh_mest;
			oleDbInsertCommand1.Parameters["St_zasedenih_mest"].Value =_2.st_z_mest;
			oleDbInsertCommand1.Parameters["Doloceni_sektorji"].Value =_2.niz_sektorjev[0]+" "+_2.niz_sektorjev[1]+" "+_2.niz_sektorjev[2]+" "+_2.niz_sektorjev[3]+" "+_2.niz_sektorjev[4]+" "+_2.niz_sektorjev[5]+" "+_2.niz_sektorjev[6]+" "+_2.niz_sektorjev[7]+" "+_2.niz_sektorjev[8]+" "+_2.niz_sektorjev[9];
			if(_2.sek_arena[0]!="")
			{
				oleDbInsertCommand1.Parameters["Sektorji_v_areni"].Value =_2.sek_arena[0]+" "+_2.sek_arena[1];
			}
			else
			{
				oleDbInsertCommand1.Parameters["Sektorji_v_areni"].Value ="Ni sektorjev v areni";
			}
			oleDbInsertCommand1.Parameters["Cena"].Value =_2.cena;
			oleDbInsertCommand1.Parameters["Vsota"].Value =_2.vs;
			oleDbInsertCommand1.Parameters["Datum"].Value =_2.datum;
			oleDbInsertCommand1.ExecuteNonQuery();
			con_2.Close();
			shrani_podatke.Enabled=false;
		}
	}
}
