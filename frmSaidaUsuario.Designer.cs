namespace desafio_atos
{
    partial class frmSaidaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaidaUsuario));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvarSaida = new System.Windows.Forms.Button();
            this.btVoltarSaida = new System.Windows.Forms.Button();
            this.btLimparSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa do veiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadastro de saída de automóveis";
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(610, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 150);
            this.label5.TabIndex = 7;
            // 
            // btSalvarSaida
            // 
            this.btSalvarSaida.BackColor = System.Drawing.Color.Violet;
            this.btSalvarSaida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalvarSaida.Location = new System.Drawing.Point(27, 432);
            this.btSalvarSaida.Name = "btSalvarSaida";
            this.btSalvarSaida.Size = new System.Drawing.Size(149, 68);
            this.btSalvarSaida.TabIndex = 10;
            this.btSalvarSaida.Text = "Salvar\r\n";
            this.btSalvarSaida.UseVisualStyleBackColor = false;
            this.btSalvarSaida.Click += new System.EventHandler(this.btSalvarSaida_Click);
            // 
            // btVoltarSaida
            // 
            this.btVoltarSaida.BackColor = System.Drawing.Color.Violet;
            this.btVoltarSaida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVoltarSaida.Location = new System.Drawing.Point(557, 432);
            this.btVoltarSaida.Name = "btVoltarSaida";
            this.btVoltarSaida.Size = new System.Drawing.Size(149, 68);
            this.btVoltarSaida.TabIndex = 11;
            this.btVoltarSaida.Text = "Voltar";
            this.btVoltarSaida.UseVisualStyleBackColor = false;
            // 
            // btLimparSaida
            // 
            this.btLimparSaida.BackColor = System.Drawing.Color.Violet;
            this.btLimparSaida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimparSaida.Location = new System.Drawing.Point(292, 432);
            this.btLimparSaida.Name = "btLimparSaida";
            this.btLimparSaida.Size = new System.Drawing.Size(149, 68);
            this.btLimparSaida.TabIndex = 12;
            this.btLimparSaida.Text = "Limpar\r\n";
            this.btLimparSaida.UseVisualStyleBackColor = false;
            this.btLimparSaida.Click += new System.EventHandler(this.btLimparSaida_Click);
            // 
            // frmSaidaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.btLimparSaida);
            this.Controls.Add(this.btVoltarSaida);
            this.Controls.Add(this.btSalvarSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaidaUsuario";
            this.Text = "frmSaidaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvarSaida;
        private System.Windows.Forms.Button btVoltarSaida;
        private System.Windows.Forms.Button btLimparSaida;
    }
}