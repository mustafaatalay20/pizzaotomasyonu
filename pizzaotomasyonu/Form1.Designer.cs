namespace pizzaotomasyonu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxicecek = new System.Windows.Forms.ComboBox();
            this.cmbxpizzaboy = new System.Windows.Forms.ComboBox();
            this.maskedtxttel = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txticecekadet = new System.Windows.Forms.TextBox();
            this.txtpizzaadet = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbbxpizzatur = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblsiparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaotomasyonuDataSet = new pizzaotomasyonu.pizzaotomasyonuDataSet();
            this.tbl_siparislerTableAdapter = new pizzaotomasyonu.pizzaotomasyonuDataSetTableAdapters.tbl_siparislerTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaboyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekstraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icecekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icecekadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsiparislerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaotomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtucret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbxicecek);
            this.groupBox1.Controls.Add(this.cmbxpizzaboy);
            this.groupBox1.Controls.Add(this.maskedtxttel);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.txticecekadet);
            this.groupBox1.Controls.Add(this.txtpizzaadet);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(316, 137);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(121, 20);
            this.txtucret.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ücret";
            // 
            // cmbxicecek
            // 
            this.cmbxicecek.FormattingEnabled = true;
            this.cmbxicecek.Items.AddRange(new object[] {
            "Coca Cola",
            "Sprite",
            "Fanta",
            "İce Tea",
            "Ayran",
            "Su"});
            this.cmbxicecek.Location = new System.Drawing.Point(316, 80);
            this.cmbxicecek.Name = "cmbxicecek";
            this.cmbxicecek.Size = new System.Drawing.Size(121, 21);
            this.cmbxicecek.TabIndex = 3;
            // 
            // cmbxpizzaboy
            // 
            this.cmbxpizzaboy.FormattingEnabled = true;
            this.cmbxpizzaboy.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbxpizzaboy.Location = new System.Drawing.Point(316, 25);
            this.cmbxpizzaboy.Name = "cmbxpizzaboy";
            this.cmbxpizzaboy.Size = new System.Drawing.Size(121, 21);
            this.cmbxpizzaboy.TabIndex = 3;
            // 
            // maskedtxttel
            // 
            this.maskedtxttel.Location = new System.Drawing.Point(78, 78);
            this.maskedtxttel.Mask = "(999) 000-0000";
            this.maskedtxttel.Name = "maskedtxttel";
            this.maskedtxttel.Size = new System.Drawing.Size(157, 20);
            this.maskedtxttel.TabIndex = 2;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(78, 105);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(157, 68);
            this.txtadres.TabIndex = 1;
            // 
            // txticecekadet
            // 
            this.txticecekadet.Location = new System.Drawing.Point(316, 111);
            this.txticecekadet.Name = "txticecekadet";
            this.txticecekadet.Size = new System.Drawing.Size(121, 20);
            this.txticecekadet.TabIndex = 1;
            // 
            // txtpizzaadet
            // 
            this.txtpizzaadet.Location = new System.Drawing.Point(316, 52);
            this.txtpizzaadet.Name = "txtpizzaadet";
            this.txtpizzaadet.Size = new System.Drawing.Size(121, 20);
            this.txtpizzaadet.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(78, 51);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(157, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(78, 26);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(157, 20);
            this.txtad.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "İçecek Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "İçecek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pizza Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pizza Boy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbbxpizzatur);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(470, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EKSTRA";
            // 
            // cmbbxpizzatur
            // 
            this.cmbbxpizzatur.FormattingEnabled = true;
            this.cmbbxpizzatur.Items.AddRange(new object[] {
            "Karışık",
            "Sucuklu",
            "Kaşarlı",
            "Peynirli",
            "Mısırlı",
            "Zeytinli",
            "Sosisli"});
            this.cmbbxpizzatur.Location = new System.Drawing.Point(95, 47);
            this.cmbbxpizzatur.Name = "cmbbxpizzatur";
            this.cmbbxpizzatur.Size = new System.Drawing.Size(153, 21);
            this.cmbbxpizzatur.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pizza Türü";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sipariş Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Siparişleri Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 288);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SİPARİŞLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.pizzaboyDataGridViewTextBoxColumn,
            this.pizzaadetDataGridViewTextBoxColumn,
            this.ekstraDataGridViewTextBoxColumn,
            this.icecekDataGridViewTextBoxColumn,
            this.icecekadetDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView1.DataSource = this.tblsiparislerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // tblsiparislerBindingSource
            // 
            this.tblsiparislerBindingSource.DataMember = "tbl_siparisler";
            this.tblsiparislerBindingSource.DataSource = this.pizzaotomasyonuDataSet;
            // 
            // pizzaotomasyonuDataSet
            // 
            this.pizzaotomasyonuDataSet.DataSetName = "pizzaotomasyonuDataSet";
            this.pizzaotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_siparislerTableAdapter
            // 
            this.tbl_siparislerTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // pizzaboyDataGridViewTextBoxColumn
            // 
            this.pizzaboyDataGridViewTextBoxColumn.DataPropertyName = "pizzaboy";
            this.pizzaboyDataGridViewTextBoxColumn.HeaderText = "pizzaboy";
            this.pizzaboyDataGridViewTextBoxColumn.Name = "pizzaboyDataGridViewTextBoxColumn";
            // 
            // pizzaadetDataGridViewTextBoxColumn
            // 
            this.pizzaadetDataGridViewTextBoxColumn.DataPropertyName = "pizzaadet";
            this.pizzaadetDataGridViewTextBoxColumn.HeaderText = "pizzaadet";
            this.pizzaadetDataGridViewTextBoxColumn.Name = "pizzaadetDataGridViewTextBoxColumn";
            // 
            // ekstraDataGridViewTextBoxColumn
            // 
            this.ekstraDataGridViewTextBoxColumn.DataPropertyName = "ekstra";
            this.ekstraDataGridViewTextBoxColumn.HeaderText = "ekstra";
            this.ekstraDataGridViewTextBoxColumn.Name = "ekstraDataGridViewTextBoxColumn";
            // 
            // icecekDataGridViewTextBoxColumn
            // 
            this.icecekDataGridViewTextBoxColumn.DataPropertyName = "icecek";
            this.icecekDataGridViewTextBoxColumn.HeaderText = "icecek";
            this.icecekDataGridViewTextBoxColumn.Name = "icecekDataGridViewTextBoxColumn";
            // 
            // icecekadetDataGridViewTextBoxColumn
            // 
            this.icecekadetDataGridViewTextBoxColumn.DataPropertyName = "icecekadet";
            this.icecekadetDataGridViewTextBoxColumn.HeaderText = "icecekadet";
            this.icecekadetDataGridViewTextBoxColumn.Name = "icecekadetDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsiparislerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaotomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxicecek;
        private System.Windows.Forms.ComboBox cmbxpizzaboy;
        private System.Windows.Forms.MaskedTextBox maskedtxttel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbbxpizzatur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txticecekadet;
        private System.Windows.Forms.TextBox txtpizzaadet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pizzaotomasyonuDataSet pizzaotomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblsiparislerBindingSource;
        private pizzaotomasyonuDataSetTableAdapters.tbl_siparislerTableAdapter tbl_siparislerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaboyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekstraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icecekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icecekadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

