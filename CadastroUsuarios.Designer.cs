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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCadastroUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlacaEntrada = new System.Windows.Forms.TextBox();
            this.buttonCadatrarEntrada = new System.Windows.Forms.Button();
            this.buttonLimparEntrada = new System.Windows.Forms.Button();
            this.buttonVoltarHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de entrada de automóveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa do veiculo:";
            // 
            // tbPlacaEntrada
            // 
            this.tbPlacaEntrada.Location = new System.Drawing.Point(183, 81);
            this.tbPlacaEntrada.Name = "tbPlacaEntrada";
            this.tbPlacaEntrada.Size = new System.Drawing.Size(108, 20);
            this.tbPlacaEntrada.TabIndex = 3;
            // 
            // buttonCadatrarEntrada
            // 
            this.buttonCadatrarEntrada.BackColor = System.Drawing.Color.Violet;
            this.buttonCadatrarEntrada.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadatrarEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCadatrarEntrada.Location = new System.Drawing.Point(17, 432);
            this.buttonCadatrarEntrada.Name = "buttonCadatrarEntrada";
            this.buttonCadatrarEntrada.Size = new System.Drawing.Size(149, 68);
            this.buttonCadatrarEntrada.TabIndex = 9;
            this.buttonCadatrarEntrada.Text = "Cadastrar\r\n";
            this.buttonCadatrarEntrada.UseVisualStyleBackColor = false;
            this.buttonCadatrarEntrada.Click += new System.EventHandler(this.buttonCadatrarEntrada_Click);
            // 
            // buttonLimparEntrada
            // 
            this.buttonLimparEntrada.BackColor = System.Drawing.Color.Violet;
            this.buttonLimparEntrada.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimparEntrada.Location = new System.Drawing.Point(287, 432);
            this.buttonLimparEntrada.Name = "buttonLimparEntrada";
            this.buttonLimparEntrada.Size = new System.Drawing.Size(149, 68);
            this.buttonLimparEntrada.TabIndex = 10;
            this.buttonLimparEntrada.Text = "Limpar";
            this.buttonLimparEntrada.UseVisualStyleBackColor = false;
            this.buttonLimparEntrada.Click += new System.EventHandler(this.buttonLimparEntrada_Click);
            // 
            // buttonVoltarHome
            // 
            this.buttonVoltarHome.BackColor = System.Drawing.Color.Violet;
            this.buttonVoltarHome.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVoltarHome.Location = new System.Drawing.Point(576, 432);
            this.buttonVoltarHome.Name = "buttonVoltarHome";
            this.buttonVoltarHome.Size = new System.Drawing.Size(149, 68);
            this.buttonVoltarHome.TabIndex = 11;
            this.buttonVoltarHome.Text = "Voltar";
            this.buttonVoltarHome.UseVisualStyleBackColor = false;
            this.buttonVoltarHome.Click += new System.EventHandler(this.buttonVoltarHome_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(612, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 117);
            this.label5.TabIndex = 12;
            // 
            // FrCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonVoltarHome);
            this.Controls.Add(this.buttonLimparEntrada);
            this.Controls.Add(this.buttonCadatrarEntrada);
            this.Controls.Add(this.tbPlacaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button buttonLimparEntrada;
        private System.Windows.Forms.Button buttonVoltarHome;
        private System.Windows.Forms.Label label5;
    }
}