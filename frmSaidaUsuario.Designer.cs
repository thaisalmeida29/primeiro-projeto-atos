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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaidaUsuario));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvarSaida = new System.Windows.Forms.Button();
            this.btirListaCarros = new System.Windows.Forms.Button();
            this.btLimparSaida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDataSaida = new System.Windows.Forms.Label();
            this.lbHoraSaida = new System.Windows.Forms.Label();
            this.timerHoraSaida = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCoral;
            this.textBox1.Location = new System.Drawing.Point(163, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
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
            // btirListaCarros
            // 
            this.btirListaCarros.BackColor = System.Drawing.Color.Violet;
            this.btirListaCarros.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btirListaCarros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btirListaCarros.Location = new System.Drawing.Point(557, 432);
            this.btirListaCarros.Name = "btirListaCarros";
            this.btirListaCarros.Size = new System.Drawing.Size(149, 68);
            this.btirListaCarros.TabIndex = 11;
            this.btirListaCarros.Text = "Ir para a lista de carros";
            this.btirListaCarros.UseVisualStyleBackColor = false;
            this.btirListaCarros.Click += new System.EventHandler(this.btirListaCarros_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 56);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor por hora\r\n R$5,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 56);
            this.label7.TabIndex = 19;
            this.label7.Text = "Horário de funcionamento:\r\n7:00 ás 20:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hora:";
            // 
            // lbDataSaida
            // 
            this.lbDataSaida.AutoSize = true;
            this.lbDataSaida.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataSaida.Location = new System.Drawing.Point(101, 198);
            this.lbDataSaida.Name = "lbDataSaida";
            this.lbDataSaida.Size = new System.Drawing.Size(46, 21);
            this.lbDataSaida.TabIndex = 22;
            this.lbDataSaida.Text = "Data";
            this.lbDataSaida.Click += new System.EventHandler(this.lbDataSaida_Click);
            // 
            // lbHoraSaida
            // 
            this.lbHoraSaida.AutoSize = true;
            this.lbHoraSaida.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraSaida.Location = new System.Drawing.Point(101, 281);
            this.lbHoraSaida.Name = "lbHoraSaida";
            this.lbHoraSaida.Size = new System.Drawing.Size(47, 21);
            this.lbHoraSaida.TabIndex = 23;
            this.lbHoraSaida.Text = "Hora";
            // 
            // timerHoraSaida
            // 
            this.timerHoraSaida.Enabled = true;
            this.timerHoraSaida.Interval = 1;
            this.timerHoraSaida.Tick += new System.EventHandler(this.timerHoraSaida_Tick);
            // 
            // frmSaidaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.lbHoraSaida);
            this.Controls.Add(this.lbDataSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLimparSaida);
            this.Controls.Add(this.btirListaCarros);
            this.Controls.Add(this.btSalvarSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaidaUsuario";
            this.Text = "frmSaidaUsuario";
            this.Load += new System.EventHandler(this.frmSaidaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvarSaida;
        private System.Windows.Forms.Button btirListaCarros;
        private System.Windows.Forms.Button btLimparSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDataSaida;
        private System.Windows.Forms.Label lbHoraSaida;
        private System.Windows.Forms.Timer timerHoraSaida;
    }
}