namespace wf_FrotadeVeiculos
{
    partial class Alertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRID_Alertas_Multas = new System.Windows.Forms.DataGridView();
            this.btn_VOLTAR_Alertas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GRID_Alertas_Motorista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PagarMulta = new System.Windows.Forms.Button();
            this.btn_DespedirMotorista = new System.Windows.Forms.Button();
            this.txt_CodigoMultas = new System.Windows.Forms.TextBox();
            this.txt_CodigoCNH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Alertas_Multas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Alertas_Motorista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(378, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALERTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(389, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GRID_Alertas_Multas
            // 
            this.GRID_Alertas_Multas.AllowUserToAddRows = false;
            this.GRID_Alertas_Multas.AllowUserToDeleteRows = false;
            this.GRID_Alertas_Multas.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Alertas_Multas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GRID_Alertas_Multas.Location = new System.Drawing.Point(31, 340);
            this.GRID_Alertas_Multas.Name = "GRID_Alertas_Multas";
            this.GRID_Alertas_Multas.ReadOnly = true;
            this.GRID_Alertas_Multas.RowHeadersVisible = false;
            this.GRID_Alertas_Multas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Alertas_Multas.Size = new System.Drawing.Size(585, 263);
            this.GRID_Alertas_Multas.TabIndex = 12;
            this.GRID_Alertas_Multas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_Alertas_CellClick);
            // 
            // btn_VOLTAR_Alertas
            // 
            this.btn_VOLTAR_Alertas.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Alertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Alertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Alertas.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Alertas.Image")));
            this.btn_VOLTAR_Alertas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Alertas.Location = new System.Drawing.Point(558, 609);
            this.btn_VOLTAR_Alertas.Name = "btn_VOLTAR_Alertas";
            this.btn_VOLTAR_Alertas.Size = new System.Drawing.Size(168, 57);
            this.btn_VOLTAR_Alertas.TabIndex = 39;
            this.btn_VOLTAR_Alertas.Text = "VOLTAR";
            this.btn_VOLTAR_Alertas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Alertas.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Alertas.Click += new System.EventHandler(this.btn_VOLTAR_Alertas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(445, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 43);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // GRID_Alertas_Motorista
            // 
            this.GRID_Alertas_Motorista.AllowUserToAddRows = false;
            this.GRID_Alertas_Motorista.AllowUserToDeleteRows = false;
            this.GRID_Alertas_Motorista.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Alertas_Motorista.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GRID_Alertas_Motorista.Location = new System.Drawing.Point(661, 340);
            this.GRID_Alertas_Motorista.Name = "GRID_Alertas_Motorista";
            this.GRID_Alertas_Motorista.ReadOnly = true;
            this.GRID_Alertas_Motorista.RowHeadersVisible = false;
            this.GRID_Alertas_Motorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Alertas_Motorista.Size = new System.Drawing.Size(585, 263);
            this.GRID_Alertas_Motorista.TabIndex = 41;
            this.GRID_Alertas_Motorista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_Alertas2_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "VENCIMENTO MULTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "VENCIMENTO CNH";
            // 
            // btn_PagarMulta
            // 
            this.btn_PagarMulta.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_PagarMulta.AutoSize = true;
            this.btn_PagarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagarMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PagarMulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_PagarMulta.Image")));
            this.btn_PagarMulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PagarMulta.Location = new System.Drawing.Point(133, 610);
            this.btn_PagarMulta.Name = "btn_PagarMulta";
            this.btn_PagarMulta.Size = new System.Drawing.Size(233, 56);
            this.btn_PagarMulta.TabIndex = 44;
            this.btn_PagarMulta.Text = "PAGAR MULTAR";
            this.btn_PagarMulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PagarMulta.UseVisualStyleBackColor = true;
            this.btn_PagarMulta.Click += new System.EventHandler(this.btn_PagarMulta_Click);
            // 
            // btn_DespedirMotorista
            // 
            this.btn_DespedirMotorista.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_DespedirMotorista.AutoSize = true;
            this.btn_DespedirMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DespedirMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DespedirMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btn_DespedirMotorista.Image")));
            this.btn_DespedirMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DespedirMotorista.Location = new System.Drawing.Point(861, 610);
            this.btn_DespedirMotorista.Name = "btn_DespedirMotorista";
            this.btn_DespedirMotorista.Size = new System.Drawing.Size(314, 56);
            this.btn_DespedirMotorista.TabIndex = 45;
            this.btn_DespedirMotorista.Text = "DESPEDIR MOTORISTA";
            this.btn_DespedirMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DespedirMotorista.UseVisualStyleBackColor = true;
            this.btn_DespedirMotorista.Click += new System.EventHandler(this.btn_DespedirMotorista_Click);
            // 
            // txt_CodigoMultas
            // 
            this.txt_CodigoMultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoMultas.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_CodigoMultas.Location = new System.Drawing.Point(31, 314);
            this.txt_CodigoMultas.Name = "txt_CodigoMultas";
            this.txt_CodigoMultas.ReadOnly = true;
            this.txt_CodigoMultas.Size = new System.Drawing.Size(78, 20);
            this.txt_CodigoMultas.TabIndex = 46;
            // 
            // txt_CodigoCNH
            // 
            this.txt_CodigoCNH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CodigoCNH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_CodigoCNH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoCNH.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_CodigoCNH.Location = new System.Drawing.Point(1168, 314);
            this.txt_CodigoCNH.Name = "txt_CodigoCNH";
            this.txt_CodigoCNH.ReadOnly = true;
            this.txt_CodigoCNH.Size = new System.Drawing.Size(78, 20);
            this.txt_CodigoCNH.TabIndex = 47;
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 678);
            this.Controls.Add(this.txt_CodigoCNH);
            this.Controls.Add(this.txt_CodigoMultas);
            this.Controls.Add(this.btn_DespedirMotorista);
            this.Controls.Add(this.btn_PagarMulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GRID_Alertas_Motorista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_VOLTAR_Alertas);
            this.Controls.Add(this.GRID_Alertas_Multas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alertas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Alertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Alertas_Multas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Alertas_Motorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GRID_Alertas_Multas;
        private System.Windows.Forms.Button btn_VOLTAR_Alertas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView GRID_Alertas_Motorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PagarMulta;
        private System.Windows.Forms.Button btn_DespedirMotorista;
        private System.Windows.Forms.TextBox txt_CodigoMultas;
        private System.Windows.Forms.TextBox txt_CodigoCNH;
    }
}