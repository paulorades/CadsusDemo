namespace CadsusDemo
{
    partial class FrmUsuariosCNSSanitas
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
            this.dtgUsuariosSemCNS = new System.Windows.Forms.DataGridView();
            this.btnAtualizarCNS = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuariosSemCNS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuariosSemCNS
            // 
            this.dtgUsuariosSemCNS.AllowUserToAddRows = false;
            this.dtgUsuariosSemCNS.AllowUserToDeleteRows = false;
            this.dtgUsuariosSemCNS.AllowUserToResizeRows = false;
            this.dtgUsuariosSemCNS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUsuariosSemCNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuariosSemCNS.Location = new System.Drawing.Point(12, 25);
            this.dtgUsuariosSemCNS.MultiSelect = false;
            this.dtgUsuariosSemCNS.Name = "dtgUsuariosSemCNS";
            this.dtgUsuariosSemCNS.ReadOnly = true;
            this.dtgUsuariosSemCNS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuariosSemCNS.Size = new System.Drawing.Size(627, 274);
            this.dtgUsuariosSemCNS.TabIndex = 0;
            // 
            // btnAtualizarCNS
            // 
            this.btnAtualizarCNS.Location = new System.Drawing.Point(12, 305);
            this.btnAtualizarCNS.Name = "btnAtualizarCNS";
            this.btnAtualizarCNS.Size = new System.Drawing.Size(627, 52);
            this.btnAtualizarCNS.TabIndex = 1;
            this.btnAtualizarCNS.Text = "ATUALUZAR CNS";
            this.btnAtualizarCNS.UseVisualStyleBackColor = true;
            this.btnAtualizarCNS.Click += new System.EventHandler(this.btnAtualizarCNS_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 9);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // FrmUsuariosCNSSanitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 369);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnAtualizarCNS);
            this.Controls.Add(this.dtgUsuariosSemCNS);
            this.Name = "FrmUsuariosCNSSanitas";
            this.Text = "Atualização de CNS - Sanitas";
            this.Load += new System.EventHandler(this.FrmUsuariosCNSSanitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuariosSemCNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuariosSemCNS;
        private System.Windows.Forms.Button btnAtualizarCNS;
        private System.Windows.Forms.Label lblCPF;
    }
}