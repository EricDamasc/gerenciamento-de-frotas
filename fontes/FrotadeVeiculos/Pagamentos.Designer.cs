namespace wf_FrotadeVeiculos
{
    partial class Pagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VOLTAR_Pagamentos = new System.Windows.Forms.Button();
            this.GRID_PNEUS = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRID_PEÇAS = new System.Windows.Forms.DataGridView();
            this.txt_peca = new System.Windows.Forms.TextBox();
            this.txt_pneu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PagarPneu = new System.Windows.Forms.Button();
            this.btn_PagarPecas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PNEUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PEÇAS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 79;
            this.label1.Text = "Pagamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_VOLTAR_Pagamentos
            // 
            this.btn_VOLTAR_Pagamentos.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR_Pagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR_Pagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR_Pagamentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR_Pagamentos.Image")));
            this.btn_VOLTAR_Pagamentos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR_Pagamentos.Location = new System.Drawing.Point(555, 600);
            this.btn_VOLTAR_Pagamentos.Name = "btn_VOLTAR_Pagamentos";
            this.btn_VOLTAR_Pagamentos.Size = new System.Drawing.Size(160, 57);
            this.btn_VOLTAR_Pagamentos.TabIndex = 78;
            this.btn_VOLTAR_Pagamentos.Text = "VOLTAR";
            this.btn_VOLTAR_Pagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR_Pagamentos.UseVisualStyleBackColor = false;
            this.btn_VOLTAR_Pagamentos.Click += new System.EventHandler(this.btn_VOLTAR_Pagamentos_Click);
            // 
            // GRID_PNEUS
            // 
            this.GRID_PNEUS.AllowUserToAddRows = false;
            this.GRID_PNEUS.AllowUserToDeleteRows = false;
            this.GRID_PNEUS.BackgroundColor = System.Drawing.Color.White;
            this.GRID_PNEUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_PNEUS.Location = new System.Drawing.Point(34, 315);
            this.GRID_PNEUS.Name = "GRID_PNEUS";
            this.GRID_PNEUS.ReadOnly = true;
            this.GRID_PNEUS.RowHeadersVisible = false;
            this.GRID_PNEUS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_PNEUS.Size = new System.Drawing.Size(566, 270);
            this.GRID_PNEUS.TabIndex = 77;
            this.GRID_PNEUS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_PNEUS_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(432, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 255);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // GRID_PEÇAS
            // 
            this.GRID_PEÇAS.AllowUserToAddRows = false;
            this.GRID_PEÇAS.AllowUserToDeleteRows = false;
            this.GRID_PEÇAS.BackgroundColor = System.Drawing.Color.White;
            this.GRID_PEÇAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_PEÇAS.Location = new System.Drawing.Point(629, 315);
            this.GRID_PEÇAS.Name = "GRID_PEÇAS";
            this.GRID_PEÇAS.ReadOnly = true;
            this.GRID_PEÇAS.RowHeadersVisible = false;
            this.GRID_PEÇAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_PEÇAS.Size = new System.Drawing.Size(532, 270);
            this.GRID_PEÇAS.TabIndex = 83;
            this.GRID_PEÇAS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_PEÇAS_CellClick);
            // 
            // txt_peca
            // 
            this.txt_peca.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_peca.Enabled = false;
            this.txt_peca.Location = new System.Drawing.Point(1048, 289);
            this.txt_peca.Name = "txt_peca";
            this.txt_peca.Size = new System.Drawing.Size(113, 20);
            this.txt_peca.TabIndex = 84;
            // 
            // txt_pneu
            // 
            this.txt_pneu.BackColor = System.Drawing.Color.White;
            this.txt_pneu.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pneu.Enabled = false;
            this.txt_pneu.Location = new System.Drawing.Point(34, 289);
            this.txt_pneu.Name = "txt_pneu";
            this.txt_pneu.Size = new System.Drawing.Size(113, 20);
            this.txt_pneu.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "PNEUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1085, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "PEÇAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_PagarPneu
            // 
            this.btn_PagarPneu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_PagarPneu.AutoSize = true;
            this.btn_PagarPneu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagarPneu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PagarPneu.Image = ((System.Drawing.Image)(resources.GetObject("btn_PagarPneu.Image")));
            this.btn_PagarPneu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PagarPneu.Location = new System.Drawing.Point(78, 600);
            this.btn_PagarPneu.Name = "btn_PagarPneu";
            this.btn_PagarPneu.Size = new System.Drawing.Size(146, 56);
            this.btn_PagarPneu.TabIndex = 88;
            this.btn_PagarPneu.Text = "PAGAR";
            this.btn_PagarPneu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PagarPneu.UseVisualStyleBackColor = true;
            this.btn_PagarPneu.Click += new System.EventHandler(this.btn_PagarPneu_Click);
            // 
            // btn_PagarPecas
            // 
            this.btn_PagarPecas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_PagarPecas.AutoSize = true;
            this.btn_PagarPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagarPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PagarPecas.Image = ((System.Drawing.Image)(resources.GetObject("btn_PagarPecas.Image")));
            this.btn_PagarPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PagarPecas.Location = new System.Drawing.Point(1015, 601);
            this.btn_PagarPecas.Name = "btn_PagarPecas";
            this.btn_PagarPecas.Size = new System.Drawing.Size(146, 56);
            this.btn_PagarPecas.TabIndex = 89;
            this.btn_PagarPecas.Text = "PAGAR";
            this.btn_PagarPecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PagarPecas.UseVisualStyleBackColor = true;
            this.btn_PagarPecas.Click += new System.EventHandler(this.btn_PagarPecas_Click);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.btn_PagarPecas);
            this.Controls.Add(this.btn_PagarPneu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pneu);
            this.Controls.Add(this.txt_peca);
            this.Controls.Add(this.GRID_PEÇAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR_Pagamentos);
            this.Controls.Add(this.GRID_PNEUS);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PNEUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PEÇAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VOLTAR_Pagamentos;
        private System.Windows.Forms.DataGridView GRID_PNEUS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GRID_PEÇAS;
        private System.Windows.Forms.TextBox txt_peca;
        private System.Windows.Forms.TextBox txt_pneu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PagarPneu;
        private System.Windows.Forms.Button btn_PagarPecas;
    }
}