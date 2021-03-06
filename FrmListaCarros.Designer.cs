namespace desafio_atos
{
    partial class FrmListaCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCarros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFecharLista = new System.Windows.Forms.Button();
            this.btApagarListaEntrada = new System.Windows.Forms.Button();
            this.btApagarListaSaida = new System.Windows.Forms.Button();
            this.tbListaEntrada = new System.Windows.Forms.TextBox();
            this.tbListaSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = " Entrada de veiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saída de veiculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de veiculos da Garageplace";
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(609, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 80);
            this.label5.TabIndex = 13;
            // 
            // buttonFecharLista
            // 
            this.buttonFecharLista.BackColor = System.Drawing.Color.Moccasin;
            this.buttonFecharLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFecharLista.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharLista.ForeColor = System.Drawing.Color.Black;
            this.buttonFecharLista.Location = new System.Drawing.Point(12, 12);
            this.buttonFecharLista.Name = "buttonFecharLista";
            this.buttonFecharLista.Size = new System.Drawing.Size(120, 49);
            this.buttonFecharLista.TabIndex = 14;
            this.buttonFecharLista.Text = "Fechar lista";
            this.buttonFecharLista.UseVisualStyleBackColor = false;
            this.buttonFecharLista.Click += new System.EventHandler(this.buttonFecharLista_Click);
            // 
            // btApagarListaEntrada
            // 
            this.btApagarListaEntrada.BackColor = System.Drawing.Color.Moccasin;
            this.btApagarListaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarListaEntrada.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarListaEntrada.Location = new System.Drawing.Point(294, 316);
            this.btApagarListaEntrada.Name = "btApagarListaEntrada";
            this.btApagarListaEntrada.Size = new System.Drawing.Size(175, 73);
            this.btApagarListaEntrada.TabIndex = 15;
            this.btApagarListaEntrada.Text = "Apagar lista entrada";
            this.btApagarListaEntrada.UseVisualStyleBackColor = false;
            this.btApagarListaEntrada.Click += new System.EventHandler(this.btApagarListaEntrada_Click);
            // 
            // btApagarListaSaida
            // 
            this.btApagarListaSaida.BackColor = System.Drawing.Color.Moccasin;
            this.btApagarListaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarListaSaida.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarListaSaida.Location = new System.Drawing.Point(294, 415);
            this.btApagarListaSaida.Name = "btApagarListaSaida";
            this.btApagarListaSaida.Size = new System.Drawing.Size(175, 75);
            this.btApagarListaSaida.TabIndex = 16;
            this.btApagarListaSaida.Text = "Apagar lista saída";
            this.btApagarListaSaida.UseVisualStyleBackColor = false;
            this.btApagarListaSaida.Click += new System.EventHandler(this.btApagarListaSaida_Click);
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbListaEntrada.Enabled = false;
            this.tbListaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaEntrada.Location = new System.Drawing.Point(12, 139);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaEntrada.Size = new System.Drawing.Size(276, 361);
            this.tbListaEntrada.TabIndex = 19;
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbListaSaida.Enabled = false;
            this.tbListaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaSaida.Location = new System.Drawing.Point(475, 139);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaSaida.Size = new System.Drawing.Size(284, 361);
            this.tbListaSaida.TabIndex = 20;
            // 
            // FrmListaCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.tbListaSaida);
            this.Controls.Add(this.tbListaEntrada);
            this.Controls.Add(this.btApagarListaSaida);
            this.Controls.Add(this.btApagarListaEntrada);
            this.Controls.Add(this.buttonFecharLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaCarros";
            this.Load += new System.EventHandler(this.FrmListaCarros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFecharLista;
        private System.Windows.Forms.Button btApagarListaEntrada;
        private System.Windows.Forms.Button btApagarListaSaida;
        private System.Windows.Forms.TextBox tbListaEntrada;
        private System.Windows.Forms.TextBox tbListaSaida;
    }
}