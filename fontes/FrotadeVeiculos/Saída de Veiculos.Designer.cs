namespace wf_FrotadeVeiculos
{
    partial class Entradas_de_Veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entradas_de_Veiculos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DATA_ADD_SAIDA = new System.Windows.Forms.MaskedTextBox();
            this.GRID_SaidaVeiculo = new System.Windows.Forms.DataGridView();
            this.btnLIMPAR_CAMPO = new System.Windows.Forms.Button();
            this.btn_Voltar_SAIDA = new System.Windows.Forms.Button();
            this.btn_ADD_SAIDA_MOTORISTA = new System.Windows.Forms.Button();
            this.txt_CODIGO_Motorista_ADD_SAIDA = new System.Windows.Forms.ComboBox();
            this.txt_CODIGO_ADD_Saida = new System.Windows.Forms.TextBox();
            this.txt_CODIGO_Cliente_ADD_SAIDA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_SaidaVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adicionar Saída de Veiculos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(335, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 263);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(143, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "MOTORISTA";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "CÓDIGO";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "CLIENTE";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(464, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "DATA DE SAÍDA";
            // 
            // txt_DATA_ADD_SAIDA
            // 
            this.txt_DATA_ADD_SAIDA.Location = new System.Drawing.Point(464, 361);
            this.txt_DATA_ADD_SAIDA.Mask = "00/00/0000 90:00";
            this.txt_DATA_ADD_SAIDA.Name = "txt_DATA_ADD_SAIDA";
            this.txt_DATA_ADD_SAIDA.Size = new System.Drawing.Size(170, 20);
            this.txt_DATA_ADD_SAIDA.TabIndex = 42;
            this.txt_DATA_ADD_SAIDA.ValidatingType = typeof(System.DateTime);
            // 
            // GRID_SaidaVeiculo
            // 
            this.GRID_SaidaVeiculo.AllowUserToAddRows = false;
            this.GRID_SaidaVeiculo.AllowUserToDeleteRows = false;
            this.GRID_SaidaVeiculo.BackgroundColor = System.Drawing.Color.White;
            this.GRID_SaidaVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_SaidaVeiculo.Location = new System.Drawing.Point(44, 387);
            this.GRID_SaidaVeiculo.Name = "GRID_SaidaVeiculo";
            this.GRID_SaidaVeiculo.ReadOnly = true;
            this.GRID_SaidaVeiculo.RowHeadersVisible = false;
            this.GRID_SaidaVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_SaidaVeiculo.Size = new System.Drawing.Size(804, 183);
            this.GRID_SaidaVeiculo.TabIndex = 43;
            // 
            // btnLIMPAR_CAMPO
            // 
            this.btnLIMPAR_CAMPO.BackColor = System.Drawing.Color.White;
            this.btnLIMPAR_CAMPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPAR_CAMPO.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPAR_CAMPO.Image = ((System.Drawing.Image)(resources.GetObject("btnLIMPAR_CAMPO.Image")));
            this.btnLIMPAR_CAMPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLIMPAR_CAMPO.Location = new System.Drawing.Point(416, 576);
            this.btnLIMPAR_CAMPO.Name = "btnLIMPAR_CAMPO";
            this.btnLIMPAR_CAMPO.Size = new System.Drawing.Size(190, 55);
            this.btnLIMPAR_CAMPO.TabIndex = 218;
            this.btnLIMPAR_CAMPO.Text = "LIMPAR";
            this.btnLIMPAR_CAMPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLIMPAR_CAMPO.UseVisualStyleBackColor = false;
            this.btnLIMPAR_CAMPO.Click += new System.EventHandler(this.btnLIMPAR_CAMPO_Click);
            // 
            // btn_Voltar_SAIDA
            // 
            this.btn_Voltar_SAIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_SAIDA.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_Voltar_SAIDA.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar_SAIDA.Image")));
            this.btn_Voltar_SAIDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voltar_SAIDA.Location = new System.Drawing.Point(669, 576);
            this.btn_Voltar_SAIDA.Name = "btn_Voltar_SAIDA";
            this.btn_Voltar_SAIDA.Size = new System.Drawing.Size(165, 56);
            this.btn_Voltar_SAIDA.TabIndex = 217;
            this.btn_Voltar_SAIDA.Text = "Voltar";
            this.btn_Voltar_SAIDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Voltar_SAIDA.UseVisualStyleBackColor = true;
            this.btn_Voltar_SAIDA.Click += new System.EventHandler(this.btn_Voltar_SAIDA_Click);
            // 
            // btn_ADD_SAIDA_MOTORISTA
            // 
            this.btn_ADD_SAIDA_MOTORISTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ADD_SAIDA_MOTORISTA.Font = new System.Drawing.Font("Impact", 18.75F);
            this.btn_ADD_SAIDA_MOTORISTA.Image = ((System.Drawing.Image)(resources.GetObject("btn_ADD_SAIDA_MOTORISTA.Image")));
            this.btn_ADD_SAIDA_MOTORISTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ADD_SAIDA_MOTORISTA.Location = new System.Drawing.Point(90, 576);
            this.btn_ADD_SAIDA_MOTORISTA.Name = "btn_ADD_SAIDA_MOTORISTA";
            this.btn_ADD_SAIDA_MOTORISTA.Size = new System.Drawing.Size(262, 56);
            this.btn_ADD_SAIDA_MOTORISTA.TabIndex = 216;
            this.btn_ADD_SAIDA_MOTORISTA.Text = "Adicionar Saída";
            this.btn_ADD_SAIDA_MOTORISTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ADD_SAIDA_MOTORISTA.UseVisualStyleBackColor = true;
            this.btn_ADD_SAIDA_MOTORISTA.Click += new System.EventHandler(this.btn_ADD_SAIDA_MOTORISTA_Click);
            // 
            // txt_CODIGO_Motorista_ADD_Entrada
            // 
            this.txt_CODIGO_Motorista_ADD_SAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CODIGO_Motorista_ADD_SAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_CODIGO_Motorista_ADD_SAIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_CODIGO_Motorista_ADD_SAIDA.FormattingEnabled = true;
            this.txt_CODIGO_Motorista_ADD_SAIDA.Location = new System.Drawing.Point(141, 360);
            this.txt_CODIGO_Motorista_ADD_SAIDA.Name = "txt_CODIGO_Motorista_ADD_Entrada";
            this.txt_CODIGO_Motorista_ADD_SAIDA.Size = new System.Drawing.Size(137, 21);
            this.txt_CODIGO_Motorista_ADD_SAIDA.TabIndex = 219;
            // 
            // txt_CODIGO_ADD_Saida
            // 
            this.txt_CODIGO_ADD_Saida.Location = new System.Drawing.Point(44, 361);
            this.txt_CODIGO_ADD_Saida.Name = "txt_CODIGO_ADD_Saida";
            this.txt_CODIGO_ADD_Saida.ReadOnly = true;
            this.txt_CODIGO_ADD_Saida.Size = new System.Drawing.Size(93, 20);
            this.txt_CODIGO_ADD_Saida.TabIndex = 34;
            // 
            // txt_CODIGO_Cliente_ADD_SAIDA
            // 
            this.txt_CODIGO_Cliente_ADD_SAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CODIGO_Cliente_ADD_SAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_CODIGO_Cliente_ADD_SAIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_CODIGO_Cliente_ADD_SAIDA.FormattingEnabled = true;
            this.txt_CODIGO_Cliente_ADD_SAIDA.Location = new System.Drawing.Point(284, 361);
            this.txt_CODIGO_Cliente_ADD_SAIDA.Name = "txt_CODIGO_Cliente_ADD_SAIDA";
            this.txt_CODIGO_Cliente_ADD_SAIDA.Size = new System.Drawing.Size(174, 21);
            this.txt_CODIGO_Cliente_ADD_SAIDA.TabIndex = 220;
            // 
            // Entradas_de_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 661);
            this.Controls.Add(this.txt_CODIGO_Cliente_ADD_SAIDA);
            this.Controls.Add(this.txt_CODIGO_Motorista_ADD_SAIDA);
            this.Controls.Add(this.btnLIMPAR_CAMPO);
            this.Controls.Add(this.btn_Voltar_SAIDA);
            this.Controls.Add(this.btn_ADD_SAIDA_MOTORISTA);
            this.Controls.Add(this.GRID_SaidaVeiculo);
            this.Controls.Add(this.txt_DATA_ADD_SAIDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CODIGO_ADD_Saida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entradas_de_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Veiculos";
            this.Load += new System.EventHandler(this.Entradas_de_Veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_SaidaVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_DATA_ADD_SAIDA;
        private System.Windows.Forms.DataGridView GRID_SaidaVeiculo;
        private System.Windows.Forms.Button btnLIMPAR_CAMPO;
        private System.Windows.Forms.Button btn_Voltar_SAIDA;
        private System.Windows.Forms.Button btn_ADD_SAIDA_MOTORISTA;
        private System.Windows.Forms.ComboBox txt_CODIGO_Motorista_ADD_SAIDA;
        private System.Windows.Forms.TextBox txt_CODIGO_ADD_Saida;
        private System.Windows.Forms.ComboBox txt_CODIGO_Cliente_ADD_SAIDA;
    }
}