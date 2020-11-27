namespace wf_FrotadeVeiculos
{
    partial class VALIDAR_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VALIDAR_LOGIN));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSENHALOGIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AcessarNovoCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(69, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 44);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // txtSENHALOGIN
            // 
            this.txtSENHALOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSENHALOGIN.Location = new System.Drawing.Point(194, 156);
            this.txtSENHALOGIN.Name = "txtSENHALOGIN";
            this.txtSENHALOGIN.PasswordChar = '*';
            this.txtSENHALOGIN.Size = new System.Drawing.Size(224, 29);
            this.txtSENHALOGIN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 82);
            this.label1.TabIndex = 8;
            this.label1.Text = "SOLICITE A SENHA COM O GERENTE PARA EFETUAR UM NOVO CADASTRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AcessarNovoCadastro
            // 
            this.btn_AcessarNovoCadastro.BackColor = System.Drawing.Color.White;
            this.btn_AcessarNovoCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AcessarNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AcessarNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcessarNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btn_AcessarNovoCadastro.Image")));
            this.btn_AcessarNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AcessarNovoCadastro.Location = new System.Drawing.Point(194, 206);
            this.btn_AcessarNovoCadastro.Name = "btn_AcessarNovoCadastro";
            this.btn_AcessarNovoCadastro.Size = new System.Drawing.Size(205, 53);
            this.btn_AcessarNovoCadastro.TabIndex = 9;
            this.btn_AcessarNovoCadastro.Text = "CONFIRMAR";
            this.btn_AcessarNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AcessarNovoCadastro.UseVisualStyleBackColor = false;
            this.btn_AcessarNovoCadastro.Click += new System.EventHandler(this.btn_AcessarNovoCadastro_Click);
            // 
            // VALIDAR_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 271);
            this.Controls.Add(this.btn_AcessarNovoCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSENHALOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VALIDAR_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VALIDAR LOGIN";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.VALIDAR_LOGIN_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSENHALOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AcessarNovoCadastro;
    }
}