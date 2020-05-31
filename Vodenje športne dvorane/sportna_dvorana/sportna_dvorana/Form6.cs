using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Form6.
	/// </summary>
	public class Form6 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton dol_datum_ne_isk;
		private System.Windows.Forms.RadioButton dol_datum_da_isk;
		private System.Windows.Forms.TextBox od_isk;
		private System.Windows.Forms.TextBox do_isk;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button izpis_vseh_podatkov_isk;
		private System.Windows.Forms.DateTimePicker datum_isk;
		private System.Windows.Forms.TextBox isk_cena;
		private System.Windows.Forms.TextBox isk_mest_sektor;
		private System.Windows.Forms.TextBox isk_vsota;
		private System.Windows.Forms.TextBox isk_zas_mest;
		private System.Windows.Forms.TextBox isk_vseh_mest;
		private System.Windows.Forms.TextBox isk_sektorji;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox _isk;
		private System.Windows.Forms.Button vpis_podatkov_isk;
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
		private System.Windows.Forms.Label label3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Data.OleDb.OleDbConnection con_7;
		private sportna_dvorana.DataSet5 dataSet51;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.DataView dataView1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button shrani_pod_2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button sprem_pod_2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form6()
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
			this.label2 = new System.Windows.Forms.Label();
			this.datum_isk = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this._isk = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dol_datum_ne_isk = new System.Windows.Forms.RadioButton();
			this.dol_datum_da_isk = new System.Windows.Forms.RadioButton();
			this.od_isk = new System.Windows.Forms.TextBox();
			this.do_isk = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.izpis_vseh_podatkov_isk = new System.Windows.Forms.Button();
			this.isk_cena = new System.Windows.Forms.TextBox();
			this.isk_mest_sektor = new System.Windows.Forms.TextBox();
			this.isk_vsota = new System.Windows.Forms.TextBox();
			this.isk_zas_mest = new System.Windows.Forms.TextBox();
			this.isk_vseh_mest = new System.Windows.Forms.TextBox();
			this.isk_sektorji = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.vpis_podatkov_isk = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataView1 = new System.Data.DataView();
			this.dataSet51 = new sportna_dvorana.DataSet5();
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
			this.label3 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter7 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.con_7 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.sprem_pod_2 = new System.Windows.Forms.Button();
			this.shrani_pod_2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet51)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 24);
			this.label2.TabIndex = 80;
			this.label2.Text = "Datum:";
			// 
			// datum_isk
			// 
			this.datum_isk.Enabled = false;
			this.datum_isk.Location = new System.Drawing.Point(72, 56);
			this.datum_isk.Name = "datum_isk";
			this.datum_isk.TabIndex = 102;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label7.Location = new System.Drawing.Point(16, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 24);
			this.label7.TabIndex = 107;
			this.label7.Text = "Doloèi datum:";
			// 
			// _isk
			// 
			this._isk.Items.AddRange(new object[] {
													  "Številu sektorjev",
													  "Število mest za sektor",
													  "Številu vseh mest",
													  "Številu zasedenih mest",
													  "Ceni",
													  "Vsoti"});
			this._isk.Location = new System.Drawing.Point(360, 16);
			this._isk.Name = "_isk";
			this._isk.Size = new System.Drawing.Size(144, 21);
			this._isk.TabIndex = 110;
			this._isk.SelectedIndexChanged += new System.EventHandler(this._isk_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label6.Location = new System.Drawing.Point(304, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 24);
			this.label6.TabIndex = 111;
			this.label6.Text = "Išèi po:";
			// 
			// dol_datum_ne_isk
			// 
			this.dol_datum_ne_isk.Checked = true;
			this.dol_datum_ne_isk.Location = new System.Drawing.Point(152, 16);
			this.dol_datum_ne_isk.Name = "dol_datum_ne_isk";
			this.dol_datum_ne_isk.Size = new System.Drawing.Size(40, 24);
			this.dol_datum_ne_isk.TabIndex = 109;
			this.dol_datum_ne_isk.TabStop = true;
			this.dol_datum_ne_isk.Text = "Ne";
			this.dol_datum_ne_isk.CheckedChanged += new System.EventHandler(this.dol_datum_ne_isk_CheckedChanged);
			// 
			// dol_datum_da_isk
			// 
			this.dol_datum_da_isk.Location = new System.Drawing.Point(104, 16);
			this.dol_datum_da_isk.Name = "dol_datum_da_isk";
			this.dol_datum_da_isk.Size = new System.Drawing.Size(40, 24);
			this.dol_datum_da_isk.TabIndex = 108;
			this.dol_datum_da_isk.Text = "Da";
			this.dol_datum_da_isk.CheckedChanged += new System.EventHandler(this.dol_datum_da_isk_CheckedChanged);
			// 
			// od_isk
			// 
			this.od_isk.Location = new System.Drawing.Point(352, 56);
			this.od_isk.Name = "od_isk";
			this.od_isk.Size = new System.Drawing.Size(72, 20);
			this.od_isk.TabIndex = 112;
			this.od_isk.Text = "";
			this.od_isk.TextChanged += new System.EventHandler(this.od_isk_TextChanged);
			// 
			// do_isk
			// 
			this.do_isk.Location = new System.Drawing.Point(488, 56);
			this.do_isk.Name = "do_isk";
			this.do_isk.Size = new System.Drawing.Size(72, 20);
			this.do_isk.TabIndex = 113;
			this.do_isk.Text = "";
			this.do_isk.TextChanged += new System.EventHandler(this.do_isk_TextChanged);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label11.Location = new System.Drawing.Point(304, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 24);
			this.label11.TabIndex = 114;
			this.label11.Text = "Od:";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label13.Location = new System.Drawing.Point(440, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 24);
			this.label13.TabIndex = 115;
			this.label13.Text = "do:";
			// 
			// izpis_vseh_podatkov_isk
			// 
			this.izpis_vseh_podatkov_isk.Location = new System.Drawing.Point(16, 240);
			this.izpis_vseh_podatkov_isk.Name = "izpis_vseh_podatkov_isk";
			this.izpis_vseh_podatkov_isk.Size = new System.Drawing.Size(96, 23);
			this.izpis_vseh_podatkov_isk.TabIndex = 118;
			this.izpis_vseh_podatkov_isk.Text = "Izpiši podatke";
			this.izpis_vseh_podatkov_isk.Click += new System.EventHandler(this.izpis_vseh_podatkov_isk_Click);
			// 
			// isk_cena
			// 
			this.isk_cena.Location = new System.Drawing.Point(760, 136);
			this.isk_cena.Name = "isk_cena";
			this.isk_cena.ReadOnly = true;
			this.isk_cena.Size = new System.Drawing.Size(96, 20);
			this.isk_cena.TabIndex = 137;
			this.isk_cena.Text = "Ni definirano";
			// 
			// isk_mest_sektor
			// 
			this.isk_mest_sektor.Location = new System.Drawing.Point(352, 176);
			this.isk_mest_sektor.Name = "isk_mest_sektor";
			this.isk_mest_sektor.ReadOnly = true;
			this.isk_mest_sektor.Size = new System.Drawing.Size(96, 20);
			this.isk_mest_sektor.TabIndex = 135;
			this.isk_mest_sektor.Text = "Ni definirano";
			// 
			// isk_vsota
			// 
			this.isk_vsota.Location = new System.Drawing.Point(760, 176);
			this.isk_vsota.Name = "isk_vsota";
			this.isk_vsota.ReadOnly = true;
			this.isk_vsota.Size = new System.Drawing.Size(96, 20);
			this.isk_vsota.TabIndex = 127;
			this.isk_vsota.Text = "Ni definirano";
			// 
			// isk_zas_mest
			// 
			this.isk_zas_mest.Location = new System.Drawing.Point(600, 176);
			this.isk_zas_mest.Name = "isk_zas_mest";
			this.isk_zas_mest.ReadOnly = true;
			this.isk_zas_mest.Size = new System.Drawing.Size(96, 20);
			this.isk_zas_mest.TabIndex = 126;
			this.isk_zas_mest.Text = "Ni definirano";
			// 
			// isk_vseh_mest
			// 
			this.isk_vseh_mest.Location = new System.Drawing.Point(568, 136);
			this.isk_vseh_mest.Name = "isk_vseh_mest";
			this.isk_vseh_mest.ReadOnly = true;
			this.isk_vseh_mest.Size = new System.Drawing.Size(96, 20);
			this.isk_vseh_mest.TabIndex = 125;
			this.isk_vseh_mest.Text = "Ni definirano";
			// 
			// isk_sektorji
			// 
			this.isk_sektorji.Location = new System.Drawing.Point(328, 136);
			this.isk_sektorji.Name = "isk_sektorji";
			this.isk_sektorji.ReadOnly = true;
			this.isk_sektorji.Size = new System.Drawing.Size(96, 20);
			this.isk_sektorji.TabIndex = 124;
			this.isk_sektorji.Text = "Ni definirano";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label5.Location = new System.Drawing.Point(712, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 24);
			this.label5.TabIndex = 136;
			this.label5.Text = "Cena:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label4.Location = new System.Drawing.Point(216, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 24);
			this.label4.TabIndex = 134;
			this.label4.Text = "Število mest za sektor:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label12.Location = new System.Drawing.Point(712, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 24);
			this.label12.TabIndex = 123;
			this.label12.Text = "Vsota:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label10.Location = new System.Drawing.Point(456, 176);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 24);
			this.label10.TabIndex = 122;
			this.label10.Text = "Število zasedenih mest:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label9.Location = new System.Drawing.Point(456, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 24);
			this.label9.TabIndex = 121;
			this.label9.Text = "Število vseh mest:";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label14.Location = new System.Drawing.Point(216, 136);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 24);
			this.label14.TabIndex = 120;
			this.label14.Text = "Število sektorjev:";
			// 
			// vpis_podatkov_isk
			// 
			this.vpis_podatkov_isk.Enabled = false;
			this.vpis_podatkov_isk.Location = new System.Drawing.Point(304, 96);
			this.vpis_podatkov_isk.Name = "vpis_podatkov_isk";
			this.vpis_podatkov_isk.Size = new System.Drawing.Size(96, 23);
			this.vpis_podatkov_isk.TabIndex = 138;
			this.vpis_podatkov_isk.Text = "Vpiši podatke";
			this.vpis_podatkov_isk.Click += new System.EventHandler(this.vpis_podatkov_isk_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataView1;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 280);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(800, 192);
			this.dataGrid1.TabIndex = 154;
			// 
			// dataView1
			// 
			this.dataView1.Table = this.dataSet51.sektorji_2;
			// 
			// dataSet51
			// 
			this.dataSet51.DataSetName = "DataSet5";
			this.dataSet51.Locale = new System.Globalization.CultureInfo("sl-SI");
			// 
			// sektor_J
			// 
			this.sektor_J.Location = new System.Drawing.Point(176, 128);
			this.sektor_J.Name = "sektor_J";
			this.sektor_J.Size = new System.Drawing.Size(32, 24);
			this.sektor_J.TabIndex = 164;
			this.sektor_J.Text = "J";
			// 
			// sektor_I
			// 
			this.sektor_I.Location = new System.Drawing.Point(144, 128);
			this.sektor_I.Name = "sektor_I";
			this.sektor_I.Size = new System.Drawing.Size(32, 24);
			this.sektor_I.TabIndex = 163;
			this.sektor_I.Text = "I";
			// 
			// Sektor_G
			// 
			this.Sektor_G.Location = new System.Drawing.Point(16, 176);
			this.Sektor_G.Name = "Sektor_G";
			this.Sektor_G.Size = new System.Drawing.Size(32, 24);
			this.Sektor_G.TabIndex = 162;
			this.Sektor_G.Text = "G";
			// 
			// Sektor_H
			// 
			this.Sektor_H.Location = new System.Drawing.Point(56, 176);
			this.Sektor_H.Name = "Sektor_H";
			this.Sektor_H.Size = new System.Drawing.Size(32, 24);
			this.Sektor_H.TabIndex = 161;
			this.Sektor_H.Text = "H";
			// 
			// Sektor_F
			// 
			this.Sektor_F.Location = new System.Drawing.Point(96, 152);
			this.Sektor_F.Name = "Sektor_F";
			this.Sektor_F.Size = new System.Drawing.Size(32, 24);
			this.Sektor_F.TabIndex = 160;
			this.Sektor_F.Text = "F";
			// 
			// Sektor_E
			// 
			this.Sektor_E.Location = new System.Drawing.Point(56, 152);
			this.Sektor_E.Name = "Sektor_E";
			this.Sektor_E.Size = new System.Drawing.Size(32, 24);
			this.Sektor_E.TabIndex = 159;
			this.Sektor_E.Text = "E";
			// 
			// Sektor_D
			// 
			this.Sektor_D.Location = new System.Drawing.Point(16, 152);
			this.Sektor_D.Name = "Sektor_D";
			this.Sektor_D.Size = new System.Drawing.Size(32, 24);
			this.Sektor_D.TabIndex = 158;
			this.Sektor_D.Text = "D";
			// 
			// Sektor_C
			// 
			this.Sektor_C.Location = new System.Drawing.Point(96, 128);
			this.Sektor_C.Name = "Sektor_C";
			this.Sektor_C.Size = new System.Drawing.Size(32, 24);
			this.Sektor_C.TabIndex = 157;
			this.Sektor_C.Text = "C";
			// 
			// Sektor_B
			// 
			this.Sektor_B.Location = new System.Drawing.Point(56, 128);
			this.Sektor_B.Name = "Sektor_B";
			this.Sektor_B.Size = new System.Drawing.Size(32, 24);
			this.Sektor_B.TabIndex = 156;
			this.Sektor_B.Text = "B";
			// 
			// Sektor_A
			// 
			this.Sektor_A.Location = new System.Drawing.Point(16, 128);
			this.Sektor_A.Name = "Sektor_A";
			this.Sektor_A.Size = new System.Drawing.Size(32, 24);
			this.Sektor_A.TabIndex = 155;
			this.Sektor_A.Text = "A";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 24);
			this.label3.TabIndex = 165;
			this.label3.Text = "Sektorji:";
			// 
			// oleDbDataAdapter7
			// 
			this.oleDbDataAdapter7.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter7.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter7.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter7.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM sektorji_2 WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.con_7;
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
			// con_7
			// 
			this.con_7.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""C:\Vodenje športne dvorane\sportna_dvorana.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO sektorji_2(St_sektorjev, St_mest_za_sektor, St_vseh_mest, St_zasedeni" +
				"h_mest, Doloceni_sektorji, Sektorji_v_areni, Datum, Cena, Vsota) VALUES (?, ?, ?" +
				", ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.con_7;
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
			this.oleDbSelectCommand1.Connection = this.con_7;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE sektorji_2 SET St_sektorjev = ?, St_mest_za_sektor = ?, St_vseh_mest = ?, St_zasedenih_mest = ?, Doloceni_sektorji = ?, Sektorji_v_areni = ?, Datum = ?, Cena = ?, Vsota = ? WHERE (ID = ?) AND (Cena = ? OR ? IS NULL AND Cena IS NULL) AND (Datum = ? OR ? IS NULL AND Datum IS NULL) AND (Doloceni_sektorji = ? OR ? IS NULL AND Doloceni_sektorji IS NULL) AND (Sektorji_v_areni = ? OR ? IS NULL AND Sektorji_v_areni IS NULL) AND (St_mest_za_sektor = ? OR ? IS NULL AND St_mest_za_sektor IS NULL) AND (St_sektorjev = ? OR ? IS NULL AND St_sektorjev IS NULL) AND (St_vseh_mest = ? OR ? IS NULL AND St_vseh_mest IS NULL) AND (St_zasedenih_mest = ? OR ? IS NULL AND St_zasedenih_mest IS NULL) AND (Vsota = ? OR ? IS NULL AND Vsota IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.con_7;
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label1.Location = new System.Drawing.Point(16, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 167;
			this.label1.Text = "Izpiši podatke za:";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Število sektorjev",
														   "Število mest za sektor",
														   "Število vseh mest",
														   "Število zasedenih mest",
														   "Ceno",
														   "Vsoto",
														   "Datum",
														   "Doloèene sektorje",
														   "Sektorje v areni"});
			this.comboBox1.Location = new System.Drawing.Point(136, 208);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 21);
			this.comboBox1.TabIndex = 166;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label8.Location = new System.Drawing.Point(136, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 24);
			this.label8.TabIndex = 168;
			this.label8.Text = "Sektorji v areni:";
			// 
			// sprem_pod_2
			// 
			this.sprem_pod_2.Enabled = false;
			this.sprem_pod_2.Location = new System.Drawing.Point(304, 240);
			this.sprem_pod_2.Name = "sprem_pod_2";
			this.sprem_pod_2.Size = new System.Drawing.Size(104, 23);
			this.sprem_pod_2.TabIndex = 169;
			this.sprem_pod_2.Text = "Spremeni podatke";
			this.sprem_pod_2.Click += new System.EventHandler(this.button1_Click);
			// 
			// shrani_pod_2
			// 
			this.shrani_pod_2.Enabled = false;
			this.shrani_pod_2.Location = new System.Drawing.Point(424, 240);
			this.shrani_pod_2.Name = "shrani_pod_2";
			this.shrani_pod_2.Size = new System.Drawing.Size(96, 23);
			this.shrani_pod_2.TabIndex = 170;
			this.shrani_pod_2.Text = "Shrani podatke";
			this.shrani_pod_2.Click += new System.EventHandler(this.shrani_pod_2_Click);
			// 
			// Form6
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(872, 486);
			this.Controls.Add(this.shrani_pod_2);
			this.Controls.Add(this.sprem_pod_2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
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
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.vpis_podatkov_isk);
			this.Controls.Add(this.isk_cena);
			this.Controls.Add(this.isk_mest_sektor);
			this.Controls.Add(this.isk_vsota);
			this.Controls.Add(this.isk_zas_mest);
			this.Controls.Add(this.isk_vseh_mest);
			this.Controls.Add(this.isk_sektorji);
			this.Controls.Add(this.do_isk);
			this.Controls.Add(this.od_isk);
			this.Controls.Add(this.dol_datum_ne_isk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.izpis_vseh_podatkov_isk);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._isk);
			this.Controls.Add(this.dol_datum_da_isk);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.datum_isk);
			this.Controls.Add(this.label2);
			this.Name = "Form6";
			this.Text = "Iskanje";
			this.Load += new System.EventHandler(this.Form6_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet51)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		Class1 _6 = new Class1();
		private void dol_datum_da_isk_CheckedChanged(object sender, System.EventArgs e)
		{
			datum_isk.Enabled=true;
		}

		private void dol_datum_ne_isk_CheckedChanged(object sender, System.EventArgs e)
		{
			datum_isk.Enabled=false;
		}

		private void vpis_podatkov_isk_Click(object sender, System.EventArgs e)
		{
			if(_isk.Text=="")
			{
				MessageBox.Show("Ni doloèene vrste","Napaka!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if(od_isk.Text==""&&do_isk.Text=="")
			{
				MessageBox.Show("Ni parametrov","Napaka!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if(Convert.ToDouble(od_isk.Text)>Convert.ToDouble(do_isk.Text))
			{
				MessageBox.Show("Napaèen vpis parametrov","Napaka!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if(_isk.Text=="Številu sektorjev")
			{
				_6.st_sektorjev_isk[0]=Convert.ToInt32(od_isk.Text);
				_6.st_sektorjev_isk[1]=Convert.ToInt32(do_isk.Text);
				isk_sektorji.Text=Convert.ToString(_6.st_sektorjev_isk[0])+" - "+Convert.ToString(_6.st_sektorjev_isk[1]);
			}
			else if(_isk.Text=="Število mest za sektor")
			{
				_6.st_vseh_mest_za_sektor_isk[0]=Convert.ToInt32(od_isk.Text);
				_6.st_vseh_mest_za_sektor_isk[1]=Convert.ToInt32(do_isk.Text);
				isk_mest_sektor.Text=Convert.ToString(_6.st_vseh_mest_za_sektor_isk[0])+" - "+Convert.ToString(_6.st_vseh_mest_za_sektor_isk[1]);
			}
			else if(_isk.Text=="Številu vseh mest")
			{
				_6.st_vseh_mest_isk[0]=Convert.ToInt32(od_isk.Text);
				_6.st_vseh_mest_isk[1]=Convert.ToInt32(do_isk.Text);
				isk_vseh_mest.Text=Convert.ToString(_6.st_vseh_mest_isk[0])+" - "+Convert.ToString(_6.st_vseh_mest_isk[1]);
			}
			else if(_isk.Text=="Številu zasedenih mest")
			{
				_6.st_z_mest_isk[0]=Convert.ToInt32(od_isk.Text);
				_6.st_z_mest_isk[1]=Convert.ToInt32(do_isk.Text);
				isk_zas_mest.Text=Convert.ToString(_6.st_z_mest_isk[0])+" - "+Convert.ToString(_6.st_z_mest_isk[1]);
			}
			else if(_isk.Text=="Ceni")
			{
				_6.cena_isk[0]=Convert.ToDouble(od_isk.Text);
				_6.cena_isk[1]=Convert.ToDouble(do_isk.Text);
				isk_cena.Text=Convert.ToString(_6.cena_isk[0])+" - "+Convert.ToString(_6.cena_isk[1]);
			}
			else if(_isk.Text=="Vsoti")
			{
				_6.vsota_isk[0]=Convert.ToDouble(od_isk.Text);
				_6.vsota_isk[1]=Convert.ToDouble(do_isk.Text);
				isk_vsota.Text=Convert.ToString(_6.vsota_isk[0])+" - "+Convert.ToString(_6.vsota_isk[1]);
			}
			vpis_podatkov_isk.Enabled=false;
			od_isk.Text="";
			do_isk.Text="";
		}
		private void _isk_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			vpis_podatkov_isk.Enabled=true;
		}

		private void od_isk_TextChanged(object sender, System.EventArgs e)
		{
			vpis_podatkov_isk.Enabled=true;
		}

		private void do_isk_TextChanged(object sender, System.EventArgs e)
		{
			vpis_podatkov_isk.Enabled=true;
		}

		private void izpis_vseh_podatkov_isk_Click(object sender, System.EventArgs e)
		{
			_6.i_isk=0;
			for(int k=0;k<10;k++)
			{
				_6.niz_sektorjev_isk[k]=" ";
			}
			if(Sektor_A.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="A";
				_6.i_isk++;
			}
			if(Sektor_B.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="B";
				_6.i_isk++;				
			}
			if(Sektor_C.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="C";
				_6.i_isk++;
			}
			if(Sektor_D.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="D";
				_6.i_isk++;
			}
			if(Sektor_E.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="E";
				_6.i_isk++;
			}
			if(Sektor_F.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="F";
				_6.i_isk++;
			}
			if(Sektor_G.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="G";
				_6.i_isk++;
			}
			if(Sektor_H.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="H";
				_6.i_isk++;
			}
			if(sektor_I.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="I";
				_6.i_isk++;
			}
			if(sektor_J.Checked==true)
			{
				_6.niz_sektorjev_isk[_6.i_isk]="J";
				_6.i_isk++;
			}
			_6.datum_isk_2="";
			if(dol_datum_da_isk.Checked==true)
			{
				_6.datum_isk_2=datum_isk.Text;
			}
			con_7.Open();
			if(comboBox1.Text=="")
			{
				MessageBox.Show("Iskanje ni doloèeno","Napaka",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				con_7.Close();
			}
			else if(comboBox1.Text=="Število sektorjev"&&isk_sektorji.Text!="Ni definirano")
			{
				dataView1.RowFilter="St_sektorjev >='"+_6.st_sektorjev_isk[0]+"' AND St_sektorjev <='"+_6.st_sektorjev_isk[1]+"'";
			}
			else if(comboBox1.Text=="Število mest za sektor"&&isk_mest_sektor.Text!="Ni definirano")
			{
				dataView1.RowFilter="St_mest_za_sektor>='"+_6.st_vseh_mest_za_sektor_isk[0]+"' AND St_mest_za_sektor<='"+_6.st_vseh_mest_za_sektor_isk[1]+"'";
			}
			else if(comboBox1.Text=="Število vseh mest"&&isk_vseh_mest.Text!="Ni definirano")
			{
				dataView1.RowFilter="St_vseh_mest>= '"+_6.st_vseh_mest_isk[0]+"' AND St_vseh_mest<='"+_6.st_vseh_mest_isk[1]+"'";
			}
			else if(comboBox1.Text=="Število zasedenih mest"&&isk_vseh_mest.Text!="Ni definirano")
			{
				dataView1.RowFilter="St_zasedenih_mest>='"+_6.st_z_mest_isk[0]+"' AND St_zasedenih_mest<='"+_6.st_z_mest_isk[1]+"'";
			}
			else if(comboBox1.Text=="Ceno"&&isk_cena.Text!="Ni definirano")
			{
				dataView1.RowFilter="Cena>='"+_6.cena_isk[0]+"' AND Cena<='"+_6.cena_isk[1]+"'";
			}
			else if(comboBox1.Text=="Vsoto"&&isk_vsota.Text!="Ni definirano")
			{
				dataView1.RowFilter="Vsota>='"+_6.vsota_isk[0]+"' AND Vsota<='"+_6.vsota_isk[1]+"'";
			}
			else if(comboBox1.Text=="Datum"&&dol_datum_da_isk.Checked==true)
			{
				dataView1.RowFilter="Datum='"+_6.datum_isk_2+"'";
			}
			else if(comboBox1.Text=="Doloèene sektorje"&&_6.niz_sektorjev_isk[0]!="")
			{
				dataView1.RowFilter="Doloceni_sektorji='"+_6.niz_sektorjev_isk[0]+" "+_6.niz_sektorjev_isk[1]+" "+_6.niz_sektorjev_isk[2]+" "+_6.niz_sektorjev_isk[3]+" "+_6.niz_sektorjev_isk[4]+" "+_6.niz_sektorjev_isk[5]+" "+_6.niz_sektorjev_isk[6]+" "+_6.niz_sektorjev_isk[7]+" "+_6.niz_sektorjev_isk[8]+" "+_6.niz_sektorjev_isk[9]+"'";
			}
			else if(comboBox1.Text=="Sektorje v areni")
			{
				if(sektor_I.Checked==true&&sektor_J.Checked==false)
				{
					dataView1.RowFilter="Sektorji_v_areni='I'";
				}
				else if(sektor_I.Checked==false&&sektor_J.Checked==true)
				{
					dataView1.RowFilter="Sektorji_v_areni='J'";
				}
				else if(sektor_I.Checked==true&&sektor_J.Checked==true)
				{
					dataView1.RowFilter="Sektorji_v_areni='I J'";
				}
				else
				{
					dataView1.RowFilter="Sektorji_v_areni='Ni sektorjev v areni'";
				}
			}
			oleDbDataAdapter7.Fill(dataSet51,"sektorji_2");
			con_7.Close();
			if(comboBox1.Text!="")
			{
				sprem_pod_2.Enabled=true;
			}
		}

		private void Form6_Load(object sender, System.EventArgs e)
		{
			datum_isk.Text=DateTime.Now.ToString();

			dol_datum_ne_isk.Checked=true;

			_isk.Text="";
			od_isk.Text="";
			do_isk.Text="";

			Sektor_A.Checked=false;
			Sektor_B.Checked=false;
			Sektor_C.Checked=false;
			Sektor_D.Checked=false;
			Sektor_E.Checked=false;
			Sektor_F.Checked=false;
			Sektor_G.Checked=false;
			Sektor_H.Checked=false;
			sektor_I.Checked=false;
			sektor_J.Checked=false;

			comboBox1.Text="";
			sprem_pod_2.Enabled=false;
			shrani_pod_2.Enabled=false;

			isk_sektorji.Text="Ni definirano";
			isk_mest_sektor.Text="Ni definirano";
			isk_vseh_mest.Text="Ni definirano";
			isk_zas_mest.Text="Ni definirano";
			isk_cena.Text="Ni definirano";
			isk_vsota.Text="Ni definirano";

			dataView1.RowFilter="ID=0";

			for(int i=0;i<2;i++)
			{
				_6.st_sektorjev_isk[i]=0;
				_6.st_vseh_mest_za_sektor_isk[i]=0;
				_6.st_vseh_mest_isk[i]=0;
				_6.st_z_mest_isk[i]=0;
				_6.cena_isk[i]=0;
				_6.vsota_isk[i]=0;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			dataGrid1.ReadOnly=false;
			shrani_pod_2.Enabled=true;
		}

		private void shrani_pod_2_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter7.Update(dataSet51,"sektorji_2");
			dataGrid1.ReadOnly=true;
			shrani_pod_2.Enabled=false;
		}
	}
}
