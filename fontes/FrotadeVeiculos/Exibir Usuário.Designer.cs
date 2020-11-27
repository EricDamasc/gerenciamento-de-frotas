namespace wf_FrotadeVeiculos
{
    partial class Exibir_Usuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Usuário));
            this.btn_VOLTAR_Usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GRID_Exibir_Usuario = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VOLTAR_Usuario
            // 
            this.btn_VOLTAR_Usuario.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Usuario.Image")));
            this.btn_VOLTAR_Usuario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Usuario.Location = new System.Drawing.Point(537, 567);
            this.btn_VOLTAR_Usuario.Name = "btn_VOLTAR_Usuario";
            this.btn_VOLTAR_Usuario.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Usuario.TabIndex = 106;
            this.btn_VOLTAR_Usuario.Text = "VOLTAR";
            this.btn_VOLTAR_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Usuario.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Usuario.Click += new System.EventHandler(this.btn_VOLTAR_Usuario_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 104;
            this.label1.Text = "Exibir Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GRID_Exibir_Usuario
            // 
            this.GRID_Exibir_Usuario.AllowUserToAddRows = false;
            this.GRID_Exibir_Usuario.AllowUserToDeleteRows = false;
            this.GRID_Exibir_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Exibir_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Exibir_Usuario.Location = new System.Drawing.Point(107, 319);
            this.GRID_Exibir_Usuario.Name = "GRID_Exibir_Usuario";
            this.GRID_Exibir_Usuario.ReadOnly = true;
            this.GRID_Exibir_Usuario.RowHeadersVisible = false;
            this.GRID_Exibir_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Exibir_Usuario.Size = new System.Drawing.Size(651, 242);
            this.GRID_Exibir_Usuario.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(219, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 247);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // Exibir_Usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 626);
            this.Controls.Add(this.btn_VOLTAR_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRID_Exibir_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Exibir_Usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Usuário";
            this.Load += new System.EventHandler(this.Exibir_Usuário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VOLTAR_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GRID_Exibir_Usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}