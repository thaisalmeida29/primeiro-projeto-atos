namespace desafio_atos
{
    partial class FrCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCadastroUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlacaEntrada = new System.Windows.Forms.TextBox();
            this.buttonCadatrarEntrada = new System.Windows.Forms.Button();
            this.buttonVoltarHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDataEntrada = new System.Windows.Forms.Label();
            this.lbHoraEntrada = new System.Windows.Forms.Label();
            this.timerHoraEntrada = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de entrada de automóveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa do veiculo:";
            // 
            // tbPlacaEntrada
            // 
            this.tbPlacaEntrada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPlacaEntrada.Location = new System.Drawing.Point(161, 112);
            this.tbPlacaEntrada.Name = "tbPlacaEntrada";
            this.tbPlacaEntrada.Size = new System.Drawing.Size(132, 31);
            this.tbPlacaEntrada.TabIndex = 3;
            // 
            // buttonCadatrarEntrada
            // 
            this.buttonCadatrarEntrada.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCadatrarEntrada.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadatrarEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCadatrarEntrada.Location = new System.Drawing.Point(12, 432);
            this.buttonCadatrarEntrada.Name = "buttonCadatrarEntrada";
            this.buttonCadatrarEntrada.Size = new System.Drawing.Size(149, 68);
            this.buttonCadatrarEntrada.TabIndex = 9;
            this.buttonCadatrarEntrada.Text = "Cadastrar\r\n";
            this.buttonCadatrarEntrada.UseVisualStyleBackColor = false;
            this.buttonCadatrarEntrada.Click += new System.EventHandler(this.buttonCadatrarEntrada_Click);
            // 
            // buttonVoltarHome
            // 
            this.buttonVoltarHome.BackColor = System.Drawing.Color.Moccasin;
            this.buttonVoltarHome.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVoltarHome.Location = new System.Drawing.Point(249, 432);
            this.buttonVoltarHome.Name = "buttonVoltarHome";
            this.buttonVoltarHome.Size = new System.Drawing.Size(149, 68);
            this.buttonVoltarHome.TabIndex = 11;
            this.buttonVoltarHome.Text = "Ir para a lista de carros";
            this.buttonVoltarHome.UseVisualStyleBackColor = false;
            this.buttonVoltarHome.Click += new System.EventHandler(this.buttonVoltarHome_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(600, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 102);
            this.label5.TabIndex = 12;
            // 
            // lbDataEntrada
            // 
            this.lbDataEntrada.AutoSize = true;
            this.lbDataEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEntrada.Location = new System.Drawing.Point(90, 202);
            this.lbDataEntrada.Name = "lbDataEntrada";
            this.lbDataEntrada.Size = new System.Drawing.Size(46, 21);
            this.lbDataEntrada.TabIndex = 13;
            this.lbDataEntrada.Text = "Data";
            // 
            // lbHoraEntrada
            // 
            this.lbHoraEntrada.AutoSize = true;
            this.lbHoraEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraEntrada.Location = new System.Drawing.Point(90, 280);
            this.lbHoraEntrada.Name = "lbHoraEntrada";
            this.lbHoraEntrada.Size = new System.Drawing.Size(47, 21);
            this.lbHoraEntrada.TabIndex = 14;
            this.lbHoraEntrada.Text = "Hora";
            // 
            // timerHoraEntrada
            // 
            this.timerHoraEntrada.Enabled = true;
            this.timerHoraEntrada.Interval = 1;
            this.timerHoraEntrada.Tick += new System.EventHandler(this.timerHoraEntrada_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 60);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor por hora\r\n R$5,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 60);
            this.label7.TabIndex = 18;
            this.label7.Text = "Horário de funcionamento:\r\n7:00 ás 20:00";
            // 
            // FrCadastroUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHoraEntrada);
            this.Controls.Add(this.lbDataEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonVoltarHome);
            this.Controls.Add(this.buttonCadatrarEntrada);
            this.Controls.Add(this.tbPlacaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrCadastroUsuarios";
            this.Text = "CadastroUsuarios";
            this.Load += new System.EventHandler(this.FrCadastroUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlacaEntrada;
        private System.Windows.Forms.Button buttonCadatrarEntrada;
        private System.Windows.Forms.Button buttonVoltarHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDataEntrada;
        private System.Windows.Forms.Label lbHoraEntrada;
        private System.Windows.Forms.Timer timerHoraEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}