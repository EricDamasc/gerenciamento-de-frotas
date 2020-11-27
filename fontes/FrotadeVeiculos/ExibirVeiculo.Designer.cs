namespace wf_FrotadeVeiculos
{
    partial class ExibirVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VOLTAR_Veiculos = new System.Windows.Forms.Button();
            this.GRID_Exibir_Veiculos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Veiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 79;
            this.label1.Text = "Veiculos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_VOLTAR_Veiculos
            // 
            this.btn_VOLTAR_Veiculos.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Veiculos.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Veiculos.Image")));
            this.btn_VOLTAR_Veiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VOLTAR_Veiculos.Location = new System.Drawing.Point(727, 624);
            this.btn_VOLTAR_Veiculos.Name = "btn_VOLTAR_Veiculos";
            this.btn_VOLTAR_Veiculos.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Veiculos.TabIndex = 78;
            this.btn_VOLTAR_Veiculos.Text = "VOLTAR";
            this.btn_VOLTAR_Veiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Veiculos.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Veiculos.Click += new System.EventHandler(this.btn_VOLTAR_Veiculos_Click);
            // 
            // GRID_Exibir_Veiculos
            // 
            this.GRID_Exibir_Veiculos.AllowUserToAddRows = false;
            this.GRID_Exibir_Veiculos.AllowUserToDeleteRows = false;
            this.GRID_Exibir_Veiculos.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Exibir_Veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Exibir_Veiculos.Location = new System.Drawing.Point(46, 348);
            this.GRID_Exibir_Veiculos.Name = "GRID_Exibir_Veiculos";
            this.GRID_Exibir_Veiculos.ReadOnly = true;
            this.GRID_Exibir_Veiculos.RowHeadersVisible = false;
            this.GRID_Exibir_Veiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Exibir_Veiculos.Size = new System.Drawing.Size(916, 270);
            this.GRID_Exibir_Veiculos.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(301, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 277);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ExibirVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR_Veiculos);
            this.Controls.Add(this.GRID_Exibir_Veiculos);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "ExibirVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.ExibirVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Veiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VOLTAR_Veiculos;
        private System.Windows.Forms.DataGridView GRID_Exibir_Veiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}