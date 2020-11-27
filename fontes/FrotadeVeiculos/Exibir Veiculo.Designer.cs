namespace wf_FrotadeVeiculos
{
    partial class Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_VOLTAR_Usuario = new System.Windows.Forms.Button();
            this.ExibirGridVEICULO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExibirGridVEICULO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 45);
            this.label1.TabIndex = 108;
            this.label1.Text = "Exibir Veiculo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 282);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // btn_VOLTAR_Usuario
            // 
            this.btn_VOLTAR_Usuario.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Usuario.Image")));
            this.btn_VOLTAR_Usuario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Usuario.Location = new System.Drawing.Point(684, 618);
            this.btn_VOLTAR_Usuario.Name = "btn_VOLTAR_Usuario";
            this.btn_VOLTAR_Usuario.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Usuario.TabIndex = 111;
            this.btn_VOLTAR_Usuario.Text = "VOLTAR";
            this.btn_VOLTAR_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Usuario.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Usuario.Click += new System.EventHandler(this.btn_VOLTAR_Usuario_Click);
            // 
            // ExibirGridVEICULO
            // 
            this.ExibirGridVEICULO.AllowUserToAddRows = false;
            this.ExibirGridVEICULO.AllowUserToDeleteRows = false;
            this.ExibirGridVEICULO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExibirGridVEICULO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibirGridVEICULO.Location = new System.Drawing.Point(31, 346);
            this.ExibirGridVEICULO.Name = "ExibirGridVEICULO";
            this.ExibirGridVEICULO.ReadOnly = true;
            this.ExibirGridVEICULO.RowHeadersVisible = false;
            this.ExibirGridVEICULO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExibirGridVEICULO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExibirGridVEICULO.Size = new System.Drawing.Size(985, 266);
            this.ExibirGridVEICULO.TabIndex = 169;
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 683);
            this.Controls.Add(this.ExibirGridVEICULO);
            this.Controls.Add(this.btn_VOLTAR_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExibirGridVEICULO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_VOLTAR_Usuario;
        private System.Windows.Forms.DataGridView ExibirGridVEICULO;
    }
}