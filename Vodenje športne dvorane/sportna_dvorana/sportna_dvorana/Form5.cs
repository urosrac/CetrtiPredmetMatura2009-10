using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Form5.
	/// </summary>
	public class Form5 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbConnection con_3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbConnection con_4;
		private sportna_dvorana.DataSet3 dataSet31;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button sprem_pod_o_vpisih;
		private System.Windows.Forms.Button sprem_pod_o_sektorjih;
		private System.Windows.Forms.Button shrani_pod_o_vpisih;
		private System.Windows.Forms.Button shrani_podatke_o_sektorjih;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form5()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataSet31 = new sportna_dvorana.DataSet3();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.con_3 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.con_4 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sprem_pod_o_vpisih = new System.Windows.Forms.Button();
			this.sprem_pod_o_sektorjih = new System.Windows.Forms.Button();
			this.shrani_pod_o_vpisih = new System.Windows.Forms.Button();
			this.shrani_podatke_o_sektorjih = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataSet31.sektorji;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(40, 320);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(272, 208);
			this.dataGrid1.TabIndex = 0;
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.Locale = new System.Globalization.CultureInfo("sl-SI");
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.DataSource = this.dataSet31.sektorji_2;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(32, 64);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(792, 208);
			this.dataGrid2.TabIndex = 1;
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "sektorji", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("st_sektorja", "st_sektorja"),
																																																					new System.Data.Common.DataColumnMapping("ime_sektorja", "ime_sektorja"),
																																																					new System.Data.Common.DataColumnMapping("st_gledalcev", "st_gledalcev")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM sektorji WHERE (st_sektorja = ?) AND (ime_sektorja = ? OR ? IS NULL A" +
				"ND ime_sektorja IS NULL) AND (st_gledalcev = ? OR ? IS NULL AND st_gledalcev IS " +
				"NULL)";
			this.oleDbDeleteCommand1.Connection = this.con_3;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_sektorja", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja1", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			// 
			// con_3
			// 
			this.con_3.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""C:\Vodenje športne dvorane\sektorji.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO sektorji(ime_sektorja, st_gledalcev) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.con_3;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, "ime_sektorja"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, "st_gledalcev"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT st_sektorja, ime_sektorja, st_gledalcev FROM sektorji";
			this.oleDbSelectCommand1.Connection = this.con_3;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE sektorji SET ime_sektorja = ?, st_gledalcev = ? WHERE (st_sektorja = ?) AN" +
				"D (ime_sektorja = ? OR ? IS NULL AND ime_sektorja IS NULL) AND (st_gledalcev = ?" +
				" OR ? IS NULL AND st_gledalcev IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.con_3;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, "ime_sektorja"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, "st_gledalcev"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_sektorja", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja1", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM sektorji_2 WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.con_4;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			// 
			// con_4
			// 
			this.con_4.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""C:\Vodenje športne dvorane\sportna_dvorana.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO sektorji_2(St_sektorjev, St_mest_za_sektor, St_vseh_mest, St_zasedeni" +
				"h_mest, Doloceni_sektorji, Sektorji_v_areni, Datum, Cena, Vsota) VALUES (?, ?, ?" +
				", ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.con_4;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, "St_sektorjev"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, "St_mest_za_sektor"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_vseh_mest"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_zasedenih_mest"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, "Doloceni_sektorji"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, "Sektorji_v_areni"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Datum", System.Data.OleDb.OleDbType.VarWChar, 30, "Datum"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cena", System.Data.OleDb.OleDbType.Double, 0, "Cena"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vsota", System.Data.OleDb.OleDbType.Double, 0, "Vsota"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT ID, St_sektorjev, St_mest_za_sektor, St_vseh_mest, St_zasedenih_mest, Dolo" +
				"ceni_sektorji, Sektorji_v_areni, Datum, Cena, Vsota FROM sektorji_2";
			this.oleDbSelectCommand2.Connection = this.con_4;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE sektorji_2 SET St_sektorjev = ?, St_mest_za_sektor = ?, St_vseh_mest = ?, St_zasedenih_mest = ?, Doloceni_sektorji = ?, Sektorji_v_areni = ?, Datum = ?, Cena = ?, Vsota = ? WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.con_4;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, "St_sektorjev"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, "St_mest_za_sektor"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_vseh_mest"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, "St_zasedenih_mest"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, "Doloceni_sektorji"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, "Sektorji_v_areni"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Datum", System.Data.OleDb.OleDbType.VarWChar, 30, "Datum"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cena", System.Data.OleDb.OleDbType.Double, 0, "Cena"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vsota", System.Data.OleDb.OleDbType.Double, 0, "Vsota"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cena1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cena", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Datum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Datum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Doloceni_sektorji1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Doloceni_sektorji", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Sektorji_v_areni1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektorji_v_areni", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_mest_za_sektor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_mest_za_sektor", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_sektorjev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_sektorjev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_vseh_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_vseh_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_St_zasedenih_mest1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "St_zasedenih_mest", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vsota1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vsota", System.Data.DataRowVersion.Original, null));
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label7.Location = new System.Drawing.Point(32, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 24);
			this.label7.TabIndex = 77;
			this.label7.Text = "Vpisani podatki:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label1.Location = new System.Drawing.Point(40, 288);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 24);
			this.label1.TabIndex = 78;
			this.label1.Text = "Razvrstitev gledalcev po sektorjih:";
			// 
			// sprem_pod_o_vpisih
			// 
			this.sprem_pod_o_vpisih.Location = new System.Drawing.Point(344, 320);
			this.sprem_pod_o_vpisih.Name = "sprem_pod_o_vpisih";
			this.sprem_pod_o_vpisih.Size = new System.Drawing.Size(144, 23);
			this.sprem_pod_o_vpisih.TabIndex = 93;
			this.sprem_pod_o_vpisih.Text = "spremeni podatke o vpisih";
			this.sprem_pod_o_vpisih.Click += new System.EventHandler(this.sprem_pod_o_vpisih_Click);
			// 
			// sprem_pod_o_sektorjih
			// 
			this.sprem_pod_o_sektorjih.Location = new System.Drawing.Point(536, 320);
			this.sprem_pod_o_sektorjih.Name = "sprem_pod_o_sektorjih";
			this.sprem_pod_o_sektorjih.Size = new System.Drawing.Size(160, 23);
			this.sprem_pod_o_sektorjih.TabIndex = 94;
			this.sprem_pod_o_sektorjih.Text = "spremeni podatke o sektorjih";
			this.sprem_pod_o_sektorjih.Click += new System.EventHandler(this.sprem_pod_o_sektorjih_Click);
			// 
			// shrani_pod_o_vpisih
			// 
			this.shrani_pod_o_vpisih.Enabled = false;
			this.shrani_pod_o_vpisih.Location = new System.Drawing.Point(344, 360);
			this.shrani_pod_o_vpisih.Name = "shrani_pod_o_vpisih";
			this.shrani_pod_o_vpisih.Size = new System.Drawing.Size(96, 23);
			this.shrani_pod_o_vpisih.TabIndex = 95;
			this.shrani_pod_o_vpisih.Text = "Shrani podatke";
			this.shrani_pod_o_vpisih.Click += new System.EventHandler(this.shrani_pod_o_vpisih_Click);
			// 
			// shrani_podatke_o_sektorjih
			// 
			this.shrani_podatke_o_sektorjih.Enabled = false;
			this.shrani_podatke_o_sektorjih.Location = new System.Drawing.Point(536, 360);
			this.shrani_podatke_o_sektorjih.Name = "shrani_podatke_o_sektorjih";
			this.shrani_podatke_o_sektorjih.Size = new System.Drawing.Size(96, 23);
			this.shrani_podatke_o_sektorjih.TabIndex = 96;
			this.shrani_podatke_o_sektorjih.Text = "Shrani podatke";
			this.shrani_podatke_o_sektorjih.Click += new System.EventHandler(this.shrani_podatke_o_sektorjih_Click);
			// 
			// Form5
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(848, 582);
			this.Controls.Add(this.shrani_podatke_o_sektorjih);
			this.Controls.Add(this.shrani_pod_o_vpisih);
			this.Controls.Add(this.sprem_pod_o_sektorjih);
			this.Controls.Add(this.sprem_pod_o_vpisih);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Form5";
			this.Text = "Tabele podatkov";
			this.Load += new System.EventHandler(this.Form5_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form5_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter3.Fill(dataSet31,"sektorji");
			oleDbDataAdapter4.Fill(dataSet31,"sektorji_2");
		}

		private void sprem_pod_o_vpisih_Click(object sender, System.EventArgs e)
		{
			dataGrid2.ReadOnly=false;
			shrani_pod_o_vpisih.Enabled=true;
		}

		private void sprem_pod_o_sektorjih_Click(object sender, System.EventArgs e)
		{
			dataGrid1.ReadOnly=false;
			shrani_podatke_o_sektorjih.Enabled=true;
		}

		private void shrani_pod_o_vpisih_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter4.Update(dataSet31,"sektorji_2");
			dataGrid2.ReadOnly=true;
			shrani_pod_o_vpisih.Enabled=false;
		}

		private void shrani_podatke_o_sektorjih_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter3.Fill(dataSet31,"sektorji");
			dataGrid1.ReadOnly=true;
			shrani_podatke_o_sektorjih.Enabled=false;
		}
	}
}
