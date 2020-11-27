namespace wf_FrotadeVeiculos
{
    partial class Manutençao_Prevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutençao_Prevista));
            this.btn_VOLTAR_Manutenção = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GRID_MANUTENCAO_Prevista = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_MANUTENCAO_Prevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VOLTAR_Manutenção
            // 
            this.btn_VOLTAR_Manutenção.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Manutenção.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Manutenção.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Manutenção.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Manutenção.Image")));
            this.btn_VOLTAR_Manutenção.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Manutenção.Location = new System.Drawing.Point(676, 623);
            this.btn_VOLTAR_Manutenção.Name = "btn_VOLTAR_Manutenção";
            this.btn_VOLTAR_Manutenção.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Manutenção.TabIndex = 106;
            this.btn_VOLTAR_Manutenção.Text = "VOLTAR";
            this.btn_VOLTAR_Manutenção.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Manutenção.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Manutenção.Click += new System.EventHandler(this.btn_VOLTAR_Manutenção_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 45);
            this.label1.TabIndex = 104;
            this.label1.Text = "Manutenções Previstas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GRID_MANUTENCAO_Prevista
            // 
            this.GRID_MANUTENCAO_Prevista.AllowUserToAddRows = false;
            this.GRID_MANUTENCAO_Prevista.AllowUserToDeleteRows = false;
            this.GRID_MANUTENCAO_Prevista.BackgroundColor = System.Drawing.Color.White;
            this.GRID_MANUTENCAO_Prevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_MANUTENCAO_Prevista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GRID_MANUTENCAO_Prevista.Location = new System.Drawing.Point(74, 338);
            this.GRID_MANUTENCAO_Prevista.Name = "GRID_MANUTENCAO_Prevista";
            this.GRID_MANUTENCAO_Prevista.ReadOnly = true;
            this.GRID_MANUTENCAO_Prevista.RowHeadersVisible = false;
            this.GRID_MANUTENCAO_Prevista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_MANUTENCAO_Prevista.Size = new System.Drawing.Size(916, 278);
            this.GRID_MANUTENCAO_Prevista.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(371, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 247);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // Manutençao_Prevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 692);
            this.Controls.Add(this.btn_VOLTAR_Manutenção);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRID_MANUTENCAO_Prevista);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Manutençao_Prevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutençao Prevista";
            this.Load += new System.EventHandler(this.Manutençao_Prevista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_MANUTENCAO_Prevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VOLTAR_Manutenção;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GRID_MANUTENCAO_Prevista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}