namespace wf_FrotadeVeiculos
{
    partial class Alterar_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Veiculo));
            this.AlterarGridVEICULO = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modelo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPLACA_Alterar_Frotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.disponibilidade = new System.Windows.Forms.Label();
            this.btn_Alterar_Veiculo = new System.Windows.Forms.Button();
            this.btn_Voltar_Alterar_Veiculo = new System.Windows.Forms.Button();
            this.txtDISPONIBILIDADE_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            this.txtCONSUMO_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            this.txtMODELO_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            this.txtMARCA_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            this.txtTIPO_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            this.txtANO_Alterar_Frotas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlterarGridVEICULO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AlterarGridVEICULO
            // 
            this.AlterarGridVEICULO.AllowUserToAddRows = false;
            this.AlterarGridVEICULO.AllowUserToDeleteRows = false;
            this.AlterarGridVEICULO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlterarGridVEICULO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlterarGridVEICULO.Location = new System.Drawing.Point(26, 393);
            this.AlterarGridVEICULO.Name = "AlterarGridVEICULO";
            this.AlterarGridVEICULO.ReadOnly = true;
            this.AlterarGridVEICULO.RowHeadersVisible = false;
            this.AlterarGridVEICULO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AlterarGridVEICULO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlterarGridVEICULO.Size = new System.Drawing.Size(985, 225);
            this.AlterarGridVEICULO.TabIndex = 172;
            this.AlterarGridVEICULO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlterarGridVEICULO_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 46);
            this.label1.TabIndex = 170;
            this.label1.Text = "Alterar Veiculo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(357, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 282);
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Modelo.ForeColor = System.Drawing.Color.Black;
            this.Modelo.Location = new System.Drawing.Point(279, 333);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(111, 27);
            this.Modelo.TabIndex = 175;
            this.Modelo.Text = "MODELO";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(150, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 178;
            this.label8.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(408, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 173;
            this.label3.Text = "ANO";
            // 
            // txtPLACA_Alterar_Frotas
            // 
            this.txtPLACA_Alterar_Frotas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPLACA_Alterar_Frotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPLACA_Alterar_Frotas.Enabled = false;
            this.txtPLACA_Alterar_Frotas.ForeColor = System.Drawing.Color.Black;
            this.txtPLACA_Alterar_Frotas.Location = new System.Drawing.Point(25, 369);
            this.txtPLACA_Alterar_Frotas.Name = "txtPLACA_Alterar_Frotas";
            this.txtPLACA_Alterar_Frotas.ReadOnly = true;
            this.txtPLACA_Alterar_Frotas.Size = new System.Drawing.Size(114, 20);
            this.txtPLACA_Alterar_Frotas.TabIndex = 180;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 179;
            this.label5.Text = "PLACA";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.Location = new System.Drawing.Point(624, 334);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(66, 27);
            this.tipo.TabIndex = 181;
            this.tipo.Text = "TIPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(488, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 182;
            this.label6.Text = "CONSUMO";
            // 
            // disponibilidade
            // 
            this.disponibilidade.AutoSize = true;
            this.disponibilidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disponibilidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disponibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.disponibilidade.ForeColor = System.Drawing.Color.Black;
            this.disponibilidade.Location = new System.Drawing.Point(773, 333);
            this.disponibilidade.Name = "disponibilidade";
            this.disponibilidade.Size = new System.Drawing.Size(207, 27);
            this.disponibilidade.TabIndex = 185;
            this.disponibilidade.Text = "DISPONIBILIDADE";
            // 
            // btn_Alterar_Veiculo
            // 
            this.btn_Alterar_Veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar_Veiculo.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_Alterar_Veiculo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar_Veiculo.Image")));
            this.btn_Alterar_Veiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alterar_Veiculo.Location = new System.Drawing.Point(240, 626);
            this.btn_Alterar_Veiculo.Name = "btn_Alterar_Veiculo";
            this.btn_Alterar_Veiculo.Size = new System.Drawing.Size(230, 56);
            this.btn_Alterar_Veiculo.TabIndex = 187;
            this.btn_Alterar_Veiculo.Text = "Alterar Veiculo";
            this.btn_Alterar_Veiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar_Veiculo.UseVisualStyleBackColor = true;
            this.btn_Alterar_Veiculo.Click += new System.EventHandler(this.btn_Alterar_Veiculo_Click);
            // 
            // btn_Voltar_Alterar_Veiculo
            // 
            this.btn_Voltar_Alterar_Veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_Alterar_Veiculo.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_Voltar_Alterar_Veiculo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar_Alterar_Veiculo.Image")));
            this.btn_Voltar_Alterar_Veiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voltar_Alterar_Veiculo.Location = new System.Drawing.Point(619, 626);
            this.btn_Voltar_Alterar_Veiculo.Name = "btn_Voltar_Alterar_Veiculo";
            this.btn_Voltar_Alterar_Veiculo.Size = new System.Drawing.Size(165, 56);
            this.btn_Voltar_Alterar_Veiculo.TabIndex = 188;
            this.btn_Voltar_Alterar_Veiculo.Text = "Voltar";
            this.btn_Voltar_Alterar_Veiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Voltar_Alterar_Veiculo.UseVisualStyleBackColor = true;
            this.btn_Voltar_Alterar_Veiculo.Click += new System.EventHandler(this.btn_Voltar_Alterar_Veiculo_Click);
            // 
            // txtDISPONIBILIDADE_Alterar_Frotas
            // 
            this.txtDISPONIBILIDADE_Alterar_Frotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDISPONIBILIDADE_Alterar_Frotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDISPONIBILIDADE_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDISPONIBILIDADE_Alterar_Frotas.FormattingEnabled = true;
            this.txtDISPONIBILIDADE_Alterar_Frotas.ItemHeight = 13;
            this.txtDISPONIBILIDADE_Alterar_Frotas.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.txtDISPONIBILIDADE_Alterar_Frotas.Location = new System.Drawing.Point(773, 369);
            this.txtDISPONIBILIDADE_Alterar_Frotas.Name = "txtDISPONIBILIDADE_Alterar_Frotas";
            this.txtDISPONIBILIDADE_Alterar_Frotas.Size = new System.Drawing.Size(207, 21);
            this.txtDISPONIBILIDADE_Alterar_Frotas.TabIndex = 194;
            // 
            // txtCONSUMO_Alterar_Frotas
            // 
            this.txtCONSUMO_Alterar_Frotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCONSUMO_Alterar_Frotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCONSUMO_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCONSUMO_Alterar_Frotas.FormattingEnabled = true;
            this.txtCONSUMO_Alterar_Frotas.Items.AddRange(new object[] {
            "Alto",
            "Normal",
            "Baixo"});
            this.txtCONSUMO_Alterar_Frotas.Location = new System.Drawing.Point(488, 369);
            this.txtCONSUMO_Alterar_Frotas.Name = "txtCONSUMO_Alterar_Frotas";
            this.txtCONSUMO_Alterar_Frotas.Size = new System.Drawing.Size(125, 21);
            this.txtCONSUMO_Alterar_Frotas.TabIndex = 192;
            // 
            // txtMODELO_Alterar_Frotas
            // 
            this.txtMODELO_Alterar_Frotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMODELO_Alterar_Frotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMODELO_Alterar_Frotas.BackColor = System.Drawing.Color.White;
            this.txtMODELO_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMODELO_Alterar_Frotas.FormattingEnabled = true;
            this.txtMODELO_Alterar_Frotas.Items.AddRange(new object[] {
            "Amarok",
            "Argo",
            "C4 Cactus",
            "Captur",
            "City",
            "Civic",
            "Compass",
            "Corolla",
            "Creta",
            "Cronos",
            "Cruze Sedan",
            "Duster",
            "EcoSport",
            "Etios",
            "Fiat Siena",
            "Fiorino",
            "Fit",
            "Fox/Cross Fox",
            "Gol",
            "HB20",
            "HB20S",
            "HR-V",
            "Hilux",
            "Ka",
            "Ka Sedan",
            "Kicks",
            "Kwid",
            "Logan",
            "Mobi",
            "Onix",
            "Onix Plus",
            "Polo",
            "Prisma",
            "Ranger",
            "Renegade",
            "S10",
            "SW4",
            "Sandero",
            "Saveiro",
            "Spin",
            "Strada",
            "T-Cross",
            "Toro",
            "Tracker",
            "Uno",
            "Versa",
            "Virtus",
            "Voyage",
            "Yaris",
            "Yaris Sedan"});
            this.txtMODELO_Alterar_Frotas.Location = new System.Drawing.Point(279, 369);
            this.txtMODELO_Alterar_Frotas.Name = "txtMODELO_Alterar_Frotas";
            this.txtMODELO_Alterar_Frotas.Size = new System.Drawing.Size(123, 21);
            this.txtMODELO_Alterar_Frotas.TabIndex = 190;
            // 
            // txtMARCA_Alterar_Frotas
            // 
            this.txtMARCA_Alterar_Frotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMARCA_Alterar_Frotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMARCA_Alterar_Frotas.BackColor = System.Drawing.Color.White;
            this.txtMARCA_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMARCA_Alterar_Frotas.FormattingEnabled = true;
            this.txtMARCA_Alterar_Frotas.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chery",
            "Chevrolet",
            "Citroën",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jeep",
            "Kia",
            "Land Rover",
            "Mercedes-Benz",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.txtMARCA_Alterar_Frotas.Location = new System.Drawing.Point(150, 369);
            this.txtMARCA_Alterar_Frotas.Name = "txtMARCA_Alterar_Frotas";
            this.txtMARCA_Alterar_Frotas.Size = new System.Drawing.Size(123, 21);
            this.txtMARCA_Alterar_Frotas.TabIndex = 189;
            // 
            // txtTIPO_Alterar_Frotas
            // 
            this.txtTIPO_Alterar_Frotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTIPO_Alterar_Frotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTIPO_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTIPO_Alterar_Frotas.FormattingEnabled = true;
            this.txtTIPO_Alterar_Frotas.Items.AddRange(new object[] {
            "Automático",
            "Manual",
            "Eletrico",
            "CVT"});
            this.txtTIPO_Alterar_Frotas.Location = new System.Drawing.Point(623, 368);
            this.txtTIPO_Alterar_Frotas.Name = "txtTIPO_Alterar_Frotas";
            this.txtTIPO_Alterar_Frotas.Size = new System.Drawing.Size(144, 21);
            this.txtTIPO_Alterar_Frotas.TabIndex = 193;
            // 
            // txtANO_Alterar_Frotas
            // 
            this.txtANO_Alterar_Frotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtANO_Alterar_Frotas.FormattingEnabled = true;
            this.txtANO_Alterar_Frotas.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.txtANO_Alterar_Frotas.Location = new System.Drawing.Point(408, 369);
            this.txtANO_Alterar_Frotas.Name = "txtANO_Alterar_Frotas";
            this.txtANO_Alterar_Frotas.Size = new System.Drawing.Size(74, 21);
            this.txtANO_Alterar_Frotas.TabIndex = 191;
            // 
            // Alterar_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 686);
            this.Controls.Add(this.txtDISPONIBILIDADE_Alterar_Frotas);
            this.Controls.Add(this.txtCONSUMO_Alterar_Frotas);
            this.Controls.Add(this.txtMODELO_Alterar_Frotas);
            this.Controls.Add(this.txtMARCA_Alterar_Frotas);
            this.Controls.Add(this.txtTIPO_Alterar_Frotas);
            this.Controls.Add(this.txtANO_Alterar_Frotas);
            this.Controls.Add(this.btn_Voltar_Alterar_Veiculo);
            this.Controls.Add(this.btn_Alterar_Veiculo);
            this.Controls.Add(this.disponibilidade);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPLACA_Alterar_Frotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlterarGridVEICULO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alterar_Veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Veiculo";
            this.Load += new System.EventHandler(this.Alterar_Veiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlterarGridVEICULO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AlterarGridVEICULO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPLACA_Alterar_Frotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label disponibilidade;
        private System.Windows.Forms.Button btn_Alterar_Veiculo;
        private System.Windows.Forms.Button btn_Voltar_Alterar_Veiculo;
        private System.Windows.Forms.ComboBox txtDISPONIBILIDADE_Alterar_Frotas;
        private System.Windows.Forms.ComboBox txtCONSUMO_Alterar_Frotas;
        private System.Windows.Forms.ComboBox txtMODELO_Alterar_Frotas;
        private System.Windows.Forms.ComboBox txtMARCA_Alterar_Frotas;
        private System.Windows.Forms.ComboBox txtTIPO_Alterar_Frotas;
        private System.Windows.Forms.ComboBox txtANO_Alterar_Frotas;
    }
}