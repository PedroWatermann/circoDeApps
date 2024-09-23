namespace appCirco
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblConversorVelocidade = new System.Windows.Forms.Label();
            this.lblBuscaCep = new System.Windows.Forms.Label();
            this.lblViagem = new System.Windows.Forms.Label();
            this.lblSolar = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbxConversor = new System.Windows.Forms.PictureBox();
            this.pbxViagem = new System.Windows.Forms.PictureBox();
            this.pbxBuscaCep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(14)))), ((int)(((byte)(10)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(366, 214);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 30);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblConversorVelocidade
            // 
            this.lblConversorVelocidade.AutoSize = true;
            this.lblConversorVelocidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConversorVelocidade.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorVelocidade.Location = new System.Drawing.Point(38, 427);
            this.lblConversorVelocidade.Margin = new System.Windows.Forms.Padding(3);
            this.lblConversorVelocidade.Name = "lblConversorVelocidade";
            this.lblConversorVelocidade.Size = new System.Drawing.Size(99, 18);
            this.lblConversorVelocidade.TabIndex = 2;
            this.lblConversorVelocidade.Text = "CONVERSOR";
            this.lblConversorVelocidade.Click += new System.EventHandler(this.lblConversorVelocidade_Click);
            // 
            // lblBuscaCep
            // 
            this.lblBuscaCep.AutoSize = true;
            this.lblBuscaCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuscaCep.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCep.ForeColor = System.Drawing.Color.Black;
            this.lblBuscaCep.Location = new System.Drawing.Point(43, 12);
            this.lblBuscaCep.Margin = new System.Windows.Forms.Padding(3);
            this.lblBuscaCep.Name = "lblBuscaCep";
            this.lblBuscaCep.Size = new System.Drawing.Size(90, 18);
            this.lblBuscaCep.TabIndex = 0;
            this.lblBuscaCep.Text = "BUSCA CEP";
            this.lblBuscaCep.Click += new System.EventHandler(this.lblBuscaCep_Click);
            // 
            // lblViagem
            // 
            this.lblViagem.AutoSize = true;
            this.lblViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViagem.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViagem.Location = new System.Drawing.Point(201, 12);
            this.lblViagem.Margin = new System.Windows.Forms.Padding(3);
            this.lblViagem.Name = "lblViagem";
            this.lblViagem.Size = new System.Drawing.Size(162, 18);
            this.lblViagem.TabIndex = 1;
            this.lblViagem.Text = "CÁLCULO DA VIAGEM";
            this.lblViagem.Click += new System.EventHandler(this.lblViagem_Click);
            // 
            // lblSolar
            // 
            this.lblSolar.AutoSize = true;
            this.lblSolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSolar.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolar.Location = new System.Drawing.Point(255, 427);
            this.lblSolar.Margin = new System.Windows.Forms.Padding(3);
            this.lblSolar.Name = "lblSolar";
            this.lblSolar.Size = new System.Drawing.Size(57, 18);
            this.lblSolar.TabIndex = 3;
            this.lblSolar.Text = "SOLAR";
            this.lblSolar.Click += new System.EventHandler(this.lblSolar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(208, 271);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pbxSolar_Click);
            // 
            // pbxConversor
            // 
            this.pbxConversor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxConversor.Image = global::appCirco.Properties.Resources.velocimetro;
            this.pbxConversor.Location = new System.Drawing.Point(12, 271);
            this.pbxConversor.Name = "pbxConversor";
            this.pbxConversor.Size = new System.Drawing.Size(150, 150);
            this.pbxConversor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConversor.TabIndex = 6;
            this.pbxConversor.TabStop = false;
            this.pbxConversor.Click += new System.EventHandler(this.pbxConversorVelocidade_Click);
            // 
            // pbxViagem
            // 
            this.pbxViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxViagem.Image = global::appCirco.Properties.Resources.viagem;
            this.pbxViagem.Location = new System.Drawing.Point(208, 36);
            this.pbxViagem.Name = "pbxViagem";
            this.pbxViagem.Size = new System.Drawing.Size(150, 150);
            this.pbxViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxViagem.TabIndex = 4;
            this.pbxViagem.TabStop = false;
            this.pbxViagem.Click += new System.EventHandler(this.pbxViagem_Click);
            // 
            // pbxBuscaCep
            // 
            this.pbxBuscaCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBuscaCep.Image = global::appCirco.Properties.Resources.cep;
            this.pbxBuscaCep.Location = new System.Drawing.Point(12, 36);
            this.pbxBuscaCep.Name = "pbxBuscaCep";
            this.pbxBuscaCep.Size = new System.Drawing.Size(150, 150);
            this.pbxBuscaCep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscaCep.TabIndex = 2;
            this.pbxBuscaCep.TabStop = false;
            this.pbxBuscaCep.Click += new System.EventHandler(this.pbxBuscaCep_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.lblSolar);
            this.Controls.Add(this.lblViagem);
            this.Controls.Add(this.lblBuscaCep);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbxConversor);
            this.Controls.Add(this.lblConversorVelocidade);
            this.Controls.Add(this.pbxViagem);
            this.Controls.Add(this.pbxBuscaCep);
            this.Controls.Add(this.btnFechar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbxBuscaCep;
        private System.Windows.Forms.PictureBox pbxViagem;
        private System.Windows.Forms.PictureBox pbxConversor;
        private System.Windows.Forms.Label lblConversorVelocidade;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBuscaCep;
        private System.Windows.Forms.Label lblViagem;
        private System.Windows.Forms.Label lblSolar;
    }
}

