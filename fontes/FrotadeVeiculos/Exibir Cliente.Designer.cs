namespace wf_FrotadeVeiculos
{
    partial class Exibir_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VOLTAR_Pneus = new System.Windows.Forms.Button();
            this.GRID_Exibir_Cliente = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 79;
            this.label1.Text = "Exibir Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_VOLTAR_Pneus
            // 
            this.btn_VOLTAR_Pneus.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Pneus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Pneus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Pneus.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Pneus.Image")));
            this.btn_VOLTAR_Pneus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Pneus.Location = new System.Drawing.Point(750, 625);
            this.btn_VOLTAR_Pneus.Name = "btn_VOLTAR_Pneus";
            this.btn_VOLTAR_Pneus.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Pneus.TabIndex = 78;
            this.btn_VOLTAR_Pneus.Text = "VOLTAR";
            this.btn_VOLTAR_Pneus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Pneus.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Pneus.Click += new System.EventHandler(this.btn_VOLTAR_Pneus_Click);
            // 
            // GRID_Exibir_Cliente
            // 
            this.GRID_Exibir_Cliente.AllowUserToAddRows = false;
            this.GRID_Exibir_Cliente.AllowUserToDeleteRows = false;
            this.GRID_Exibir_Cliente.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Exibir_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Exibir_Cliente.Location = new System.Drawing.Point(75, 349);
            this.GRID_Exibir_Cliente.Name = "GRID_Exibir_Cliente";
            this.GRID_Exibir_Cliente.ReadOnly = true;
            this.GRID_Exibir_Cliente.RowHeadersVisible = false;
            this.GRID_Exibir_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Exibir_Cliente.Size = new System.Drawing.Size(916, 270);
            this.GRID_Exibir_Cliente.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(324, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 277);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // Exibir_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR_Pneus);
            this.Controls.Add(this.GRID_Exibir_Cliente);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exibir_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Cliente";
            this.Load += new System.EventHandler(this.Exibir_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VOLTAR_Pneus;
        private System.Windows.Forms.DataGridView GRID_Exibir_Cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}