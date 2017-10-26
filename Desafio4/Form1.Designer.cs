namespace Desafio4
{
    partial class Form1
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.txbFrequencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(13, 13);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(146, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Digite uma frase para análise:";
            // 
            // txbFrase
            // 
            this.txbFrase.AcceptsReturn = true;
            this.txbFrase.Location = new System.Drawing.Point(13, 30);
            this.txbFrase.Multiline = true;
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbFrase.Size = new System.Drawing.Size(680, 120);
            this.txbFrase.TabIndex = 1;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(268, 156);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(162, 31);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "ANALISAR FREQUÊNCIA";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Location = new System.Drawing.Point(13, 192);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(122, 13);
            this.lblFrequencia.TabIndex = 3;
            this.lblFrequencia.Text = "Frequência de Palavras:";
            // 
            // txbFrequencia
            // 
            this.txbFrequencia.Location = new System.Drawing.Point(16, 208);
            this.txbFrequencia.Multiline = true;
            this.txbFrequencia.Name = "txbFrequencia";
            this.txbFrequencia.ReadOnly = true;
            this.txbFrequencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbFrequencia.Size = new System.Drawing.Size(677, 134);
            this.txbFrequencia.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 354);
            this.Controls.Add(this.txbFrequencia);
            this.Controls.Add(this.lblFrequencia);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.lblFrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Desafio 4 - FREQUÊNCIA DE PALAVRAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txbFrase;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.TextBox txbFrequencia;
    }
}

