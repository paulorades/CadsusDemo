namespace CadsusDemo
{
    partial class FrmConsultarUsuario
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
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCPFsuario = new System.Windows.Forms.TextBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.Location = new System.Drawing.Point(6, 48);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarUsuario.TabIndex = 0;
            this.btnConsultarUsuario.Text = "Consultar";
            this.btnConsultarUsuario.UseVisualStyleBackColor = true;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPF:";
            // 
            // txbCPFsuario
            // 
            this.txbCPFsuario.Location = new System.Drawing.Point(53, 9);
            this.txbCPFsuario.Name = "txbCPFsuario";
            this.txbCPFsuario.Size = new System.Drawing.Size(412, 20);
            this.txbCPFsuario.TabIndex = 12;
            this.txbCPFsuario.Text = "66105234368";
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.AllowUserToDeleteRows = false;
            this.dtgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(6, 87);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.Size = new System.Drawing.Size(459, 343);
            this.dtgResultado.TabIndex = 15;
            // 
            // FrmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 442);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCPFsuario);
            this.Controls.Add(this.btnConsultarUsuario);
            this.Name = "FrmConsultarUsuario";
            this.Text = "Consultar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCPFsuario;
        private System.Windows.Forms.DataGridView dtgResultado;
    }
}