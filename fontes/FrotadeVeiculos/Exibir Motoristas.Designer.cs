namespace wf_FrotadeVeiculos
{
    partial class Exibir_Motoristas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Motoristas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRID_Exibir_Motoristas = new System.Windows.Forms.DataGridView();
            this.btn_VOLTAR_Pneus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Motoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(303, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 277);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // GRID_Exibir_Motoristas
            // 
            this.GRID_Exibir_Motoristas.AllowUserToAddRows = false;
            this.GRID_Exibir_Motoristas.AllowUserToDeleteRows = false;
            this.GRID_Exibir_Motoristas.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Exibir_Motoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Exibir_Motoristas.Location = new System.Drawing.Point(48, 347);
            this.GRID_Exibir_Motoristas.Name = "GRID_Exibir_Motoristas";
            this.GRID_Exibir_Motoristas.ReadOnly = true;
            this.GRID_Exibir_Motoristas.RowHeadersVisible = false;
            this.GRID_Exibir_Motoristas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Exibir_Motoristas.Size = new System.Drawing.Size(916, 270);
            this.GRID_Exibir_Motoristas.TabIndex = 73;
            this.GRID_Exibir_Motoristas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_Exibir_Motoristas_CellContentClick);
            // 
            // btn_VOLTAR_Pneus
            // 
            this.btn_VOLTAR_Pneus.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Pneus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Pneus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Pneus.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Pneus.Image")));
            this.btn_VOLTAR_Pneus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VOLTAR_Pneus.Location = new System.Drawing.Point(729, 623);
            this.btn_VOLTAR_Pneus.Name = "btn_VOLTAR_Pneus";
            this.btn_VOLTAR_Pneus.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Pneus.TabIndex = 74;
            this.btn_VOLTAR_Pneus.Text = "VOLTAR";
            this.btn_VOLTAR_Pneus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Pneus.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Pneus.Click += new System.EventHandler(this.btn_VOLTAR_Pneus_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 75;
            this.label1.Text = "Motoristas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exibir_Motoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR_Pneus);
            this.Controls.Add(this.GRID_Exibir_Motoristas);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Exibir_Motoristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Motoristas";
            this.Load += new System.EventHandler(this.Exibir_Motoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Motoristas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GRID_Exibir_Motoristas;
        private System.Windows.Forms.Button btn_VOLTAR_Pneus;
        private System.Windows.Forms.Label label1;
    }
}