namespace CadsusDemo
{
    partial class FrmPesquisar
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeMae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPrecisaoPesquisa = new System.Windows.Forms.ComboBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(7, 94);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome da mãe:";
            // 
            // txbNomeMae
            // 
            this.txbNomeMae.Location = new System.Drawing.Point(86, 21);
            this.txbNomeMae.Name = "txbNomeMae";
            this.txbNomeMae.Size = new System.Drawing.Size(435, 20);
            this.txbNomeMae.TabIndex = 4;
            this.txbNomeMae.Text = "LINDYNALVA SOARES ARAUJO CORREIA LIMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precisão da pesquisa:";
            // 
            // cbbPrecisaoPesquisa
            // 
            this.cbbPrecisaoPesquisa.FormattingEnabled = true;
            this.cbbPrecisaoPesquisa.Location = new System.Drawing.Point(121, 57);
            this.cbbPrecisaoPesquisa.Name = "cbbPrecisaoPesquisa";
            this.cbbPrecisaoPesquisa.Size = new System.Drawing.Size(400, 21);
            this.cbbPrecisaoPesquisa.TabIndex = 6;
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.AllowUserToDeleteRows = false;
            this.dtgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(7, 136);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.Size = new System.Drawing.Size(514, 213);
            this.dtgResultado.TabIndex = 8;
            // 
            // FrmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 361);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbPrecisaoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomeMae);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "FrmPesquisar";
            this.Text = "Pesquisa por nome da mãe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeMae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPrecisaoPesquisa;
        private System.Windows.Forms.DataGridView dtgResultado;
    }
}

