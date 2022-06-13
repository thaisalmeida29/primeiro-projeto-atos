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
            this.tbListaEntrada = new System.Windows.Forms.TextBox();
            this.tbListaSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.BackColor = System.Drawing.Color.RosyBrown;
            this.tbListaEntrada.Enabled = false;
            this.tbListaEntrada.Location = new System.Drawing.Point(12, 127);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.Size = new System.Drawing.Size(285, 373);
            this.tbListaEntrada.TabIndex = 0;
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.BackColor = System.Drawing.Color.RosyBrown;
            this.tbListaSaida.Enabled = false;
            this.tbListaSaida.Location = new System.Drawing.Point(458, 127);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.Size = new System.Drawing.Size(301, 373);
            this.tbListaSaida.TabIndex = 2;
            this.tbListaSaida.TextChanged += new System.EventHandler(this.tbListaSaida_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = " Entrada de veiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saída de veiculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 28);
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
            // FrmListaCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbListaSaida);
            this.Controls.Add(this.tbListaEntrada);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaCarros";
            this.Text = "FrmListaCarros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbListaEntrada;
        private System.Windows.Forms.TextBox tbListaSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}