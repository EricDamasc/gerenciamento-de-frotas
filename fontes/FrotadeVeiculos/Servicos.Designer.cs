namespace wf_FrotadeVeiculos
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VOLTAR_Servicos = new System.Windows.Forms.Button();
            this.GRID_Exibir_Servicos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbServicos = new System.Windows.Forms.ComboBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Servicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 79;
            this.label1.Text = "Serviços";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_VOLTAR_Servicos
            // 
            this.btn_VOLTAR_Servicos.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Servicos.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Servicos.Image")));
            this.btn_VOLTAR_Servicos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Servicos.Location = new System.Drawing.Point(759, 625);
            this.btn_VOLTAR_Servicos.Name = "btn_VOLTAR_Servicos";
            this.btn_VOLTAR_Servicos.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Servicos.TabIndex = 78;
            this.btn_VOLTAR_Servicos.Text = "VOLTAR";
            this.btn_VOLTAR_Servicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Servicos.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Servicos.Click += new System.EventHandler(this.btn_VOLTAR_Servicos_Click);
            // 
            // GRID_Exibir_Servicos
            // 
            this.GRID_Exibir_Servicos.AllowUserToAddRows = false;
            this.GRID_Exibir_Servicos.AllowUserToDeleteRows = false;
            this.GRID_Exibir_Servicos.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Exibir_Servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Exibir_Servicos.Location = new System.Drawing.Point(78, 349);
            this.GRID_Exibir_Servicos.Name = "GRID_Exibir_Servicos";
            this.GRID_Exibir_Servicos.ReadOnly = true;
            this.GRID_Exibir_Servicos.RowHeadersVisible = false;
            this.GRID_Exibir_Servicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_Exibir_Servicos.Size = new System.Drawing.Size(916, 270);
            this.GRID_Exibir_Servicos.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(333, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 277);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // cbServicos
            // 
            this.cbServicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbServicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbServicos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicos.FormattingEnabled = true;
            this.cbServicos.Items.AddRange(new object[] {
            "MULTAS",
            "MANUTENÇÃO",
            "LOCAÇÃO"});
            this.cbServicos.Location = new System.Drawing.Point(78, 296);
            this.cbServicos.Name = "cbServicos";
            this.cbServicos.Size = new System.Drawing.Size(121, 23);
            this.cbServicos.TabIndex = 80;
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregar.Image")));
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(218, 293);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(134, 35);
            this.btnCarregar.TabIndex = 81;
            this.btnCarregar.Text = "CARREGAR";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregar.UseCompatibleTextRendering = true;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 692);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.cbServicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR_Servicos);
            this.Controls.Add(this.GRID_Exibir_Servicos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Exibir_Servicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VOLTAR_Servicos;
        private System.Windows.Forms.DataGridView GRID_Exibir_Servicos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbServicos;
        private System.Windows.Forms.Button btnCarregar;
    }
}