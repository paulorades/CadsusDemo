namespace CadsusDemo
{
    partial class FrmAuditoriaCadsusPS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNS = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataUltimaAtualizacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CNS:";
            // 
            // txtCNS
            // 
            this.txtCNS.Location = new System.Drawing.Point(44, 12);
            this.txtCNS.Name = "txtCNS";
            this.txtCNS.Size = new System.Drawing.Size(254, 20);
            this.txtCNS.TabIndex = 8;
            this.txtCNS.Text = "898004405759407";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(11, 54);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data de última atualização:";
            // 
            // lblDataUltimaAtualizacao
            // 
            this.lblDataUltimaAtualizacao.AutoSize = true;
            this.lblDataUltimaAtualizacao.Location = new System.Drawing.Point(153, 97);
            this.lblDataUltimaAtualizacao.Name = "lblDataUltimaAtualizacao";
            this.lblDataUltimaAtualizacao.Size = new System.Drawing.Size(35, 13);
            this.lblDataUltimaAtualizacao.TabIndex = 12;
            this.lblDataUltimaAtualizacao.Text = "label3";
            // 
            // FrmAuditoriaCadsusPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 256);
            this.Controls.Add(this.lblDataUltimaAtualizacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNS);
            this.Name = "FrmAuditoriaCadsusPS";
            this.Text = "Auditoria Cadsus PS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNS;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataUltimaAtualizacao;
    }
}