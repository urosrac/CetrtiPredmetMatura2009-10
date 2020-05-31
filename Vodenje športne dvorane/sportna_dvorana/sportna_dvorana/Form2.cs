using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sportna_dvorana
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button sektorji_prejsnji;
		private System.Windows.Forms.Button sektorji_naslednji;
		private System.Windows.Forms.Button pb_shrani_sektorje;
		private System.Windows.Forms.TextBox pb_st_gledalcev;
		private System.Windows.Forms.TextBox pb_ime_sektorja;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox st_zas_sektorjev_2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button izracun_sektorjev;
		private System.Windows.Forms.TextBox stevilo_nedolocenih_gledalcev;
		private System.Data.OleDb.OleDbCommand Delete1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection con_1;
		private sportna_dvorana.DataSet1 dataSet11;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
			this.sektorji_prejsnji = new System.Windows.Forms.Button();
			this.sektorji_naslednji = new System.Windows.Forms.Button();
			this.pb_shrani_sektorje = new System.Windows.Forms.Button();
			this.pb_st_gledalcev = new System.Windows.Forms.TextBox();
			this.dataSet11 = new sportna_dvorana.DataSet1();
			this.pb_ime_sektorja = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.stevilo_nedolocenih_gledalcev = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.st_zas_sektorjev_2 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.izracun_sektorjev = new System.Windows.Forms.Button();
			this.Delete1 = new System.Data.OleDb.OleDbCommand();
			this.con_1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// sektorji_prejsnji
			// 
			this.sektorji_prejsnji.Location = new System.Drawing.Point(24, 96);
			this.sektorji_prejsnji.Name = "sektorji_prejsnji";
			this.sektorji_prejsnji.Size = new System.Drawing.Size(40, 23);
			this.sektorji_prejsnji.TabIndex = 94;
			this.sektorji_prejsnji.Text = "<<";
			this.sektorji_prejsnji.Click += new System.EventHandler(this.sektorji_prejsnji_Click);
			// 
			// sektorji_naslednji
			// 
			this.sektorji_naslednji.Location = new System.Drawing.Point(80, 96);
			this.sektorji_naslednji.Name = "sektorji_naslednji";
			this.sektorji_naslednji.Size = new System.Drawing.Size(40, 23);
			this.sektorji_naslednji.TabIndex = 93;
			this.sektorji_naslednji.Text = ">>";
			this.sektorji_naslednji.Click += new System.EventHandler(this.sektorji_naslednji_Click);
			// 
			// pb_shrani_sektorje
			// 
			this.pb_shrani_sektorje.Location = new System.Drawing.Point(144, 96);
			this.pb_shrani_sektorje.Name = "pb_shrani_sektorje";
			this.pb_shrani_sektorje.Size = new System.Drawing.Size(96, 23);
			this.pb_shrani_sektorje.TabIndex = 92;
			this.pb_shrani_sektorje.Text = "Shrani podatke";
			this.pb_shrani_sektorje.Click += new System.EventHandler(this.pb_shrani_sektorje_Click);
			// 
			// pb_st_gledalcev
			// 
			this.pb_st_gledalcev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "sektorji.st_gledalcev"));
			this.pb_st_gledalcev.Location = new System.Drawing.Point(168, 64);
			this.pb_st_gledalcev.Name = "pb_st_gledalcev";
			this.pb_st_gledalcev.Size = new System.Drawing.Size(80, 20);
			this.pb_st_gledalcev.TabIndex = 91;
			this.pb_st_gledalcev.Text = "";
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("sl-SI");
			// 
			// pb_ime_sektorja
			// 
			this.pb_ime_sektorja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "sektorji.ime_sektorja"));
			this.pb_ime_sektorja.Location = new System.Drawing.Point(168, 32);
			this.pb_ime_sektorja.Name = "pb_ime_sektorja";
			this.pb_ime_sektorja.ReadOnly = true;
			this.pb_ime_sektorja.Size = new System.Drawing.Size(80, 20);
			this.pb_ime_sektorja.TabIndex = 90;
			this.pb_ime_sektorja.Text = "";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label19.Location = new System.Drawing.Point(24, 64);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(136, 16);
			this.label19.TabIndex = 88;
			this.label19.Text = "Število gledalcev:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 16);
			this.label1.TabIndex = 86;
			this.label1.Text = "Ime sektorja:";
			// 
			// stevilo_nedolocenih_gledalcev
			// 
			this.stevilo_nedolocenih_gledalcev.Location = new System.Drawing.Point(216, 152);
			this.stevilo_nedolocenih_gledalcev.Name = "stevilo_nedolocenih_gledalcev";
			this.stevilo_nedolocenih_gledalcev.ReadOnly = true;
			this.stevilo_nedolocenih_gledalcev.Size = new System.Drawing.Size(56, 20);
			this.stevilo_nedolocenih_gledalcev.TabIndex = 85;
			this.stevilo_nedolocenih_gledalcev.Text = "";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label17.Location = new System.Drawing.Point(24, 152);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(192, 24);
			this.label17.TabIndex = 84;
			this.label17.Text = "Število nerazporejenih gledalcev:";
			// 
			// st_zas_sektorjev_2
			// 
			this.st_zas_sektorjev_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.st_zas_sektorjev_2.Location = new System.Drawing.Point(184, 184);
			this.st_zas_sektorjev_2.Name = "st_zas_sektorjev_2";
			this.st_zas_sektorjev_2.ReadOnly = true;
			this.st_zas_sektorjev_2.Size = new System.Drawing.Size(56, 21);
			this.st_zas_sektorjev_2.TabIndex = 83;
			this.st_zas_sektorjev_2.Text = "";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(238)));
			this.label16.Location = new System.Drawing.Point(24, 184);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(160, 24);
			this.label16.TabIndex = 82;
			this.label16.Text = "Število zasedenih sektorjev:";
			// 
			// izracun_sektorjev
			// 
			this.izracun_sektorjev.Location = new System.Drawing.Point(248, 184);
			this.izracun_sektorjev.Name = "izracun_sektorjev";
			this.izracun_sektorjev.Size = new System.Drawing.Size(96, 23);
			this.izracun_sektorjev.TabIndex = 81;
			this.izracun_sektorjev.Text = "Izraèunaj";
			this.izracun_sektorjev.Click += new System.EventHandler(this.izracun_sektorjev_Click);
			// 
			// Delete1
			// 
			this.Delete1.CommandText = "DELETE FROM sektorji";
			this.Delete1.Connection = this.con_1;
			// 
			// con_1
			// 
			this.con_1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""C:\Vodenje športne dvorane\sektorji.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "sektorji", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("st_sektorja", "st_sektorja"),
																																																					new System.Data.Common.DataColumnMapping("ime_sektorja", "ime_sektorja"),
																																																					new System.Data.Common.DataColumnMapping("st_gledalcev", "st_gledalcev")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM sektorji WHERE (st_sektorja = ?) AND (ime_sektorja = ? OR ? IS NULL A" +
				"ND ime_sektorja IS NULL) AND (st_gledalcev = ? OR ? IS NULL AND st_gledalcev IS " +
				"NULL)";
			this.oleDbDeleteCommand1.Connection = this.con_1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_sektorja", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja1", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO sektorji(ime_sektorja, st_gledalcev) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.con_1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, "ime_sektorja"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, "st_gledalcev"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT st_sektorja, ime_sektorja, st_gledalcev FROM sektorji";
			this.oleDbSelectCommand1.Connection = this.con_1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE sektorji SET ime_sektorja = ?, st_gledalcev = ? WHERE (st_sektorja = ?) AN" +
				"D (ime_sektorja = ? OR ? IS NULL AND ime_sektorja IS NULL) AND (st_gledalcev = ?" +
				" OR ? IS NULL AND st_gledalcev IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.con_1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, "ime_sektorja"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, "st_gledalcev"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_sektorja", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ime_sektorja1", System.Data.OleDb.OleDbType.VarWChar, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ime_sektorja", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_st_gledalcev1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "st_gledalcev", System.Data.DataRowVersion.Original, null));
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 230);
			this.Controls.Add(this.sektorji_prejsnji);
			this.Controls.Add(this.sektorji_naslednji);
			this.Controls.Add(this.pb_shrani_sektorje);
			this.Controls.Add(this.pb_st_gledalcev);
			this.Controls.Add(this.pb_ime_sektorja);
			this.Controls.Add(this.stevilo_nedolocenih_gledalcev);
			this.Controls.Add(this.st_zas_sektorjev_2);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.izracun_sektorjev);
			this.Name = "Form2";
			this.Text = "Razporeditev gledalcev glede na sektorje";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		public Class1 _3 = new Class1();
		public BindingManagerBase pb_1;

		public int i
		{
			set{_3.i=value;}
		}
		public string []niz_sektorjev
		{
			set{_3.niz_sektorjev=value;}
		}
		public int st_z_mest
		{
			set{_3.st_z_mest=value;}
		}
		public int st_vseh_mest_za_sektor
		{
			set{_3.st_vseh_mest_za_sektor=value;}
		}
		public bool vsi_sektorji_zasedeni
		{
			set{_3.vsi_sektorji_zasedeni=value;}
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
			con_1.Open();
			Delete1.ExecuteNonQuery();
			for(int j=0;j<_3.i;j++)
			{
				oleDbInsertCommand1.Parameters["ime_sektorja"].Value = "Sektor_"+_3.niz_sektorjev[j].ToString();
				if(_3.vsi_sektorji_zasedeni)
				{
					oleDbInsertCommand1.Parameters["st_gledalcev"].Value = _3.st_vseh_mest_za_sektor;
				}
				else
				{
					oleDbInsertCommand1.Parameters["st_gledalcev"].Value = 0;
				}
				oleDbInsertCommand1.ExecuteNonQuery();
			}
			con_1.Close();
			oleDbDataAdapter1.Fill(dataSet11,"sektorji");
			pb_1=this.BindingContext[dataSet11,"sektorji"];
			pb_1.Position=0;
		
			if(_3.vsi_sektorji_zasedeni)
			{
				stevilo_nedolocenih_gledalcev.Text="0";
			}
			else
			{
				System.Data.OleDb.OleDbDataReader dr;
				con_1.Open();
				dr=oleDbSelectCommand1.ExecuteReader();
				while(dr.Read())
				{
					_3.vs_gled_1 += Convert.ToInt32(dr["st_gledalcev"]);
				}
				dr.Close();
				con_1.Close();
				stevilo_nedolocenih_gledalcev.Text=Convert.ToString(_3.st_z_mest-_3.vs_gled_1);
			}
			st_zas_sektorjev_2.Text="0";
		}

		private void sektorji_prejsnji_Click(object sender, System.EventArgs e)
		{
			pb_1.Position -=1;
		}

		private void sektorji_naslednji_Click(object sender, System.EventArgs e)
		{
			pb_1.Position +=1;
		}

		private void izracun_sektorjev_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Update(dataSet11,"sektorji");
			_3.st_vs_zas_sek=0;
			System.Data.OleDb.OleDbDataReader dr;
			con_1.Open();
			dr=oleDbSelectCommand1.ExecuteReader();

			while(dr.Read())
			{
				if(_3.st_vseh_mest_za_sektor==(int)dr["st_gledalcev"])
				{
					_3.st_vs_zas_sek++;
				}
			}
			dr.Close();
			con_1.Close();
			st_zas_sektorjev_2.Text=Convert.ToString(_3.st_vs_zas_sek);
		}
		
		private void pb_shrani_sektorje_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Update(dataSet11,"sektorji");
			_3.vs_gled_1=0;
			_3.max_st_gled=0;
			System.Data.OleDb.OleDbDataReader dr;
			con_1.Open();
			dr=oleDbSelectCommand1.ExecuteReader();
			while(dr.Read())
			{
				if(Convert.ToInt32(dr["st_gledalcev"])>_3.max_st_gled)
				{
					_3.max_st_gled_sek=dr["ime_sektorja"].ToString();
					_3.max_st_gled=Convert.ToInt32(dr["st_gledalcev"]);
				}
			}
			dr.Close();
			if(_3.st_vseh_mest_za_sektor<_3.max_st_gled)
			{
				MessageBox.Show("Za "+_3.max_st_gled_sek+" je preseženo število gledalcev","Napaka",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			con_1.Close();
			if(_3.st_vseh_mest_za_sektor>=_3.max_st_gled)
			{
				System.Data.OleDb.OleDbDataReader _dr;
				con_1.Open();
				_dr=oleDbSelectCommand1.ExecuteReader();
				while(_dr.Read())
				{
					_3.vs_gled_1 += Convert.ToInt32(_dr["st_gledalcev"]);
				}
				_dr.Close();
				con_1.Close();
				if(_3.vs_gled_1>_3.st_z_mest)
				{
					MessageBox.Show("Število doloèenih gledalcev presega število nerazporejenih.","Napaka",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				_3.st_nedol_gled=_3.st_z_mest;
				_3.st_nedol_gled -=_3.vs_gled_1;
				stevilo_nedolocenih_gledalcev.Text=Convert.ToString(_3.st_nedol_gled);
				if(_3.st_nedol_gled==0)
				{
					MessageBox.Show("Vsi gledalci so razvršèeni","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
		}
	}
}
