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
            this.buttonFecharLista = new System.Windows.Forms.Button();
            this.btApagarListaEntrada = new System.Windows.Forms.Button();
            this.btApagarListaSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.BackColor = System.Drawing.Color.Silver;
            this.tbListaEntrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaEntrada.ForeColor = System.Drawing.Color.Black;
            this.tbListaEntrada.Location = new System.Drawing.Point(12, 127);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaEntrada.Size = new System.Drawing.Size(275, 373);
            this.tbListaEntrada.TabIndex = 0;
            this.tbListaEntrada.TextChanged += new System.EventHandler(this.tbListaEntrada_TextChanged);
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.BackColor = System.Drawing.Color.Silver;
            this.tbListaSaida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaSaida.ForeColor = System.Drawing.Color.Black;
            this.tbListaSaida.Location = new System.Drawing.Point(467, 127);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaSaida.Size = new System.Drawing.Size(292, 373);
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
            // buttonFecharLista
            // 
            this.buttonFecharLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFecharLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFecharLista.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btApagarListaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btApagarListaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarListaEntrada.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarListaEntrada.Location = new System.Drawing.Point(303, 427);
            this.btApagarListaEntrada.Name = "btApagarListaEntrada";
            this.btApagarListaEntrada.Size = new System.Drawing.Size(158, 73);
            this.btApagarListaEntrada.TabIndex = 15;
            this.btApagarListaEntrada.Text = "Apagar lista entrada";
            this.btApagarListaEntrada.UseVisualStyleBackColor = false;
            this.btApagarListaEntrada.Click += new System.EventHandler(this.btApagarListaEntrada_Click);
            // 
            // btApagarListaSaida
            // 
            this.btApagarListaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btApagarListaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarListaSaida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarListaSaida.Location = new System.Drawing.Point(303, 326);
            this.btApagarListaSaida.Name = "btApagarListaSaida";
            this.btApagarListaSaida.Size = new System.Drawing.Size(158, 75);
            this.btApagarListaSaida.TabIndex = 16;
            this.btApagarListaSaida.Text = "Apagar lista saída";
            this.btApagarListaSaida.UseVisualStyleBackColor = false;
            // 
            // FrmListaCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.btApagarListaSaida);
            this.Controls.Add(this.btApagarListaEntrada);
            this.Controls.Add(this.buttonFecharLista);
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
        private System.Windows.Forms.Button buttonFecharLista;
        private System.Windows.Forms.Button btApagarListaEntrada;
        private System.Windows.Forms.Button btApagarListaSaida;
    }
}