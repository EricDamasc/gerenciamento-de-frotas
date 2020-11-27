namespace wf_FrotadeVeiculos
{
    partial class Entrada_de_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_de_Veiculo));
            this.btnLIMPAR_CAMPO = new System.Windows.Forms.Button();
            this.btn_Voltar_ENTRADA = new System.Windows.Forms.Button();
            this.btn_ADD_ENTRADA_MOTORISTA = new System.Windows.Forms.Button();
            this.GRID_ENTRADA = new System.Windows.Forms.DataGridView();
            this.txt_DATA_ADD_SAIDA = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_DATA_Motorista_ADD_Entrada = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CODIGO_Cliente_ADD_Entrada = new System.Windows.Forms.ComboBox();
            this.txt_CODIGO_Motorista_ADD_Entrada = new System.Windows.Forms.ComboBox();
            this.txt_CODIGO_ADD_Entrada = new System.Windows.Forms.ComboBox();
            this.GRID_ENTRADA_2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ENTRADA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ENTRADA_2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLIMPAR_CAMPO
            // 
            this.btnLIMPAR_CAMPO.BackColor = System.Drawing.Color.White;
            this.btnLIMPAR_CAMPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPAR_CAMPO.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPAR_CAMPO.Image = ((System.Drawing.Image)(resources.GetObject("btnLIMPAR_CAMPO.Image")));
            this.btnLIMPAR_CAMPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLIMPAR_CAMPO.Location = new System.Drawing.Point(397, 589);
            this.btnLIMPAR_CAMPO.Name = "btnLIMPAR_CAMPO";
            this.btnLIMPAR_CAMPO.Size = new System.Drawing.Size(190, 55);
            this.btnLIMPAR_CAMPO.TabIndex = 232;
            this.btnLIMPAR_CAMPO.Text = "LIMPAR";
            this.btnLIMPAR_CAMPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLIMPAR_CAMPO.UseVisualStyleBackColor = false;
            // 
            // btn_Voltar_ENTRADA
            // 
            this.btn_Voltar_ENTRADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_ENTRADA.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_Voltar_ENTRADA.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar_ENTRADA.Image")));
            this.btn_Voltar_ENTRADA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voltar_ENTRADA.Location = new System.Drawing.Point(630, 589);
            this.btn_Voltar_ENTRADA.Name = "btn_Voltar_ENTRADA";
            this.btn_Voltar_ENTRADA.Size = new System.Drawing.Size(165, 56);
            this.btn_Voltar_ENTRADA.TabIndex = 231;
            this.btn_Voltar_ENTRADA.Text = "Voltar";
            this.btn_Voltar_ENTRADA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Voltar_ENTRADA.UseVisualStyleBackColor = true;
            this.btn_Voltar_ENTRADA.Click += new System.EventHandler(this.btn_Voltar_ENTRADA_Click);
            // 
            // btn_ADD_ENTRADA_MOTORISTA
            // 
            this.btn_ADD_ENTRADA_MOTORISTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ADD_ENTRADA_MOTORISTA.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_ADD_ENTRADA_MOTORISTA.Image = ((System.Drawing.Image)(resources.GetObject("btn_ADD_ENTRADA_MOTORISTA.Image")));
            this.btn_ADD_ENTRADA_MOTORISTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ADD_ENTRADA_MOTORISTA.Location = new System.Drawing.Point(98, 587);
            this.btn_ADD_ENTRADA_MOTORISTA.Name = "btn_ADD_ENTRADA_MOTORISTA";
            this.btn_ADD_ENTRADA_MOTORISTA.Size = new System.Drawing.Size(262, 56);
            this.btn_ADD_ENTRADA_MOTORISTA.TabIndex = 230;
            this.btn_ADD_ENTRADA_MOTORISTA.Text = "Confirmar Entrada";
            this.btn_ADD_ENTRADA_MOTORISTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ADD_ENTRADA_MOTORISTA.UseVisualStyleBackColor = true;
            this.btn_ADD_ENTRADA_MOTORISTA.Click += new System.EventHandler(this.btn_ADD_ENTRADA_MOTORISTA_Click);
            // 
            // GRID_ENTRADA
            // 
            this.GRID_ENTRADA.AllowUserToAddRows = false;
            this.GRID_ENTRADA.AllowUserToDeleteRows = false;
            this.GRID_ENTRADA.BackgroundColor = System.Drawing.Color.White;
            this.GRID_ENTRADA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_ENTRADA.Location = new System.Drawing.Point(52, 398);
            this.GRID_ENTRADA.Name = "GRID_ENTRADA";
            this.GRID_ENTRADA.ReadOnly = true;
            this.GRID_ENTRADA.RowHeadersVisible = false;
            this.GRID_ENTRADA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_ENTRADA.Size = new System.Drawing.Size(488, 183);
            this.GRID_ENTRADA.TabIndex = 229;
            this.GRID_ENTRADA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_ENTRADA_CellClick);
            // 
            // txt_DATA_ADD_SAIDA
            // 
            this.txt_DATA_ADD_SAIDA.Enabled = false;
            this.txt_DATA_ADD_SAIDA.Location = new System.Drawing.Point(451, 372);
            this.txt_DATA_ADD_SAIDA.Mask = "00/00/0000 90:00";
            this.txt_DATA_ADD_SAIDA.Name = "txt_DATA_ADD_SAIDA";
            this.txt_DATA_ADD_SAIDA.ReadOnly = true;
            this.txt_DATA_ADD_SAIDA.Size = new System.Drawing.Size(170, 20);
            this.txt_DATA_ADD_SAIDA.TabIndex = 228;
            this.txt_DATA_ADD_SAIDA.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(451, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 227;
            this.label5.Text = "DATA DE SAÍDA";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 226;
            this.label3.Text = "CLIENTE";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 224;
            this.label4.Text = "MOTORISTA";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 222;
            this.label2.Text = "CÓDIGO";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 40);
            this.label1.TabIndex = 219;
            this.label1.Text = "Adicionar Entrada de Veiculos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 263);
            this.pictureBox1.TabIndex = 220;
            this.pictureBox1.TabStop = false;
            // 
            // txt_DATA_Motorista_ADD_Entrada
            // 
            this.txt_DATA_Motorista_ADD_Entrada.Location = new System.Drawing.Point(627, 372);
            this.txt_DATA_Motorista_ADD_Entrada.Mask = "00/00/0000 90:00";
            this.txt_DATA_Motorista_ADD_Entrada.Name = "txt_DATA_Motorista_ADD_Entrada";
            this.txt_DATA_Motorista_ADD_Entrada.Size = new System.Drawing.Size(170, 20);
            this.txt_DATA_Motorista_ADD_Entrada.TabIndex = 234;
            this.txt_DATA_Motorista_ADD_Entrada.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(627, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 26);
            this.label6.TabIndex = 233;
            this.label6.Text = "DATA DE ENTRADA";
            // 
            // txt_CODIGO_Cliente_ADD_Entrada
            // 
            this.txt_CODIGO_Cliente_ADD_Entrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CODIGO_Cliente_ADD_Entrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_CODIGO_Cliente_ADD_Entrada.Enabled = false;
            this.txt_CODIGO_Cliente_ADD_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_CODIGO_Cliente_ADD_Entrada.FormattingEnabled = true;
            this.txt_CODIGO_Cliente_ADD_Entrada.Location = new System.Drawing.Point(310, 372);
            this.txt_CODIGO_Cliente_ADD_Entrada.Name = "txt_CODIGO_Cliente_ADD_Entrada";
            this.txt_CODIGO_Cliente_ADD_Entrada.Size = new System.Drawing.Size(135, 21);
            this.txt_CODIGO_Cliente_ADD_Entrada.TabIndex = 236;
            // 
            // txt_CODIGO_Motorista_ADD_Entrada
            // 
            this.txt_CODIGO_Motorista_ADD_Entrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CODIGO_Motorista_ADD_Entrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_CODIGO_Motorista_ADD_Entrada.Enabled = false;
            this.txt_CODIGO_Motorista_ADD_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_CODIGO_Motorista_ADD_Entrada.FormattingEnabled = true;
            this.txt_CODIGO_Motorista_ADD_Entrada.Location = new System.Drawing.Point(167, 372);
            this.txt_CODIGO_Motorista_ADD_Entrada.Name = "txt_CODIGO_Motorista_ADD_Entrada";
            this.txt_CODIGO_Motorista_ADD_Entrada.Size = new System.Drawing.Size(137, 21);
            this.txt_CODIGO_Motorista_ADD_Entrada.TabIndex = 235;
            // 
            // txt_CODIGO_ADD_Entrada
            // 
            this.txt_CODIGO_ADD_Entrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CODIGO_ADD_Entrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_CODIGO_ADD_Entrada.Enabled = false;
            this.txt_CODIGO_ADD_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_CODIGO_ADD_Entrada.FormattingEnabled = true;
            this.txt_CODIGO_ADD_Entrada.Location = new System.Drawing.Point(70, 372);
            this.txt_CODIGO_ADD_Entrada.Name = "txt_CODIGO_ADD_Entrada";
            this.txt_CODIGO_ADD_Entrada.Size = new System.Drawing.Size(93, 21);
            this.txt_CODIGO_ADD_Entrada.TabIndex = 237;
            // 
            // GRID_ENTRADA_2
            // 
            this.GRID_ENTRADA_2.AllowUserToAddRows = false;
            this.GRID_ENTRADA_2.AllowUserToDeleteRows = false;
            this.GRID_ENTRADA_2.BackgroundColor = System.Drawing.Color.White;
            this.GRID_ENTRADA_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_ENTRADA_2.Location = new System.Drawing.Point(546, 398);
            this.GRID_ENTRADA_2.Name = "GRID_ENTRADA_2";
            this.GRID_ENTRADA_2.ReadOnly = true;
            this.GRID_ENTRADA_2.RowHeadersVisible = false;
            this.GRID_ENTRADA_2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_ENTRADA_2.Size = new System.Drawing.Size(339, 183);
            this.GRID_ENTRADA_2.TabIndex = 238;
            // 
            // Entrada_de_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 661);
            this.Controls.Add(this.GRID_ENTRADA_2);
            this.Controls.Add(this.txt_CODIGO_ADD_Entrada);
            this.Controls.Add(this.txt_CODIGO_Cliente_ADD_Entrada);
            this.Controls.Add(this.txt_CODIGO_Motorista_ADD_Entrada);
            this.Controls.Add(this.txt_DATA_Motorista_ADD_Entrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLIMPAR_CAMPO);
            this.Controls.Add(this.btn_Voltar_ENTRADA);
            this.Controls.Add(this.btn_ADD_ENTRADA_MOTORISTA);
            this.Controls.Add(this.GRID_ENTRADA);
            this.Controls.Add(this.txt_DATA_ADD_SAIDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entrada_de_Veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Veiculo";
            this.Load += new System.EventHandler(this.Entrada_de_Veiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ENTRADA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ENTRADA_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLIMPAR_CAMPO;
        private System.Windows.Forms.Button btn_Voltar_ENTRADA;
        private System.Windows.Forms.Button btn_ADD_ENTRADA_MOTORISTA;
        private System.Windows.Forms.DataGridView GRID_ENTRADA;
        private System.Windows.Forms.MaskedTextBox txt_DATA_ADD_SAIDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_DATA_Motorista_ADD_Entrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_CODIGO_Cliente_ADD_Entrada;
        private System.Windows.Forms.ComboBox txt_CODIGO_Motorista_ADD_Entrada;
        private System.Windows.Forms.ComboBox txt_CODIGO_ADD_Entrada;
        private System.Windows.Forms.DataGridView GRID_ENTRADA_2;
    }
}