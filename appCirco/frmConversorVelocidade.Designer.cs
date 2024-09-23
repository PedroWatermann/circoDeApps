namespace appCirco
{
    partial class frmConversorVelocidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversorVelocidade));
            this.btnConverter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPara = new System.Windows.Forms.ComboBox();
            this.lblVel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.AutoSize = true;
            this.btnConverter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(102)))), ((int)(((byte)(46)))));
            this.btnConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(153)))), ((int)(((byte)(99)))));
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnConverter.Location = new System.Drawing.Point(63, 169);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(93, 30);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appCirco.Properties.Resources.velocimetro;
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidade:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(14)))), ((int)(((byte)(10)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnVoltar.Location = new System.Drawing.Point(395, 419);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 30);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(15, 34);
            this.txtVelocidade.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(192, 20);
            this.txtVelocidade.TabIndex = 0;
            this.txtVelocidade.Click += new System.EventHandler(this.txtVelocidade_Click);
            this.txtVelocidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVelocidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "De:";
            // 
            // cbxDe
            // 
            this.cbxDe.FormattingEnabled = true;
            this.cbxDe.Items.AddRange(new object[] {
            "Milha por hora (mph)",
            "Pés por segundo (fps)",
            "Metro por segundo (m/s)",
            "Quilômetro por hora (km/h)",
            "Nó (kn)"});
            this.cbxDe.Location = new System.Drawing.Point(15, 86);
            this.cbxDe.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.cbxDe.Name = "cbxDe";
            this.cbxDe.Size = new System.Drawing.Size(192, 21);
            this.cbxDe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Para:";
            // 
            // cbxPara
            // 
            this.cbxPara.FormattingEnabled = true;
            this.cbxPara.Items.AddRange(new object[] {
            "Milha por hora (mph)",
            "Pés por segundo (fps)",
            "Metro por segundo (m/s)",
            "Quilômetro por hora (km/h)",
            "Nó (kn)"});
            this.cbxPara.Location = new System.Drawing.Point(15, 137);
            this.cbxPara.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.cbxPara.Name = "cbxPara";
            this.cbxPara.Size = new System.Drawing.Size(192, 21);
            this.cbxPara.TabIndex = 2;
            // 
            // lblVel
            // 
            this.lblVel.AutoSize = true;
            this.lblVel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel.Location = new System.Drawing.Point(15, 325);
            this.lblVel.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblVel.Name = "lblVel";
            this.lblVel.Size = new System.Drawing.Size(0, 38);
            this.lblVel.TabIndex = 20;
            // 
            // frmConversorVelocidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblVel);
            this.Controls.Add(this.cbxPara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConverter);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConversorVelocidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Velocidade";
            this.Load += new System.EventHandler(this.frmConversorVelocidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPara;
        private System.Windows.Forms.Label lblVel;
    }
}