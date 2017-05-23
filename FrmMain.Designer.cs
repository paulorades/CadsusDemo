namespace CadsusDemo
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNomeDaMaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorCPFtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorNomeCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAtaualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirNovoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.últimaDataDeAlteraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarToolStripMenuItem,
            this.incluirToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNomeDaMaeToolStripMenuItem,
            this.pesquisarPorCPFtoolStripMenuItem,
            this.pesquisarPorNomeCompletoToolStripMenuItem,
            this.verificarAtaualizaçãoToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // porNomeDaMaeToolStripMenuItem
            // 
            this.porNomeDaMaeToolStripMenuItem.Name = "porNomeDaMaeToolStripMenuItem";
            this.porNomeDaMaeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.porNomeDaMaeToolStripMenuItem.Text = "Por nome da mãe";
            this.porNomeDaMaeToolStripMenuItem.Click += new System.EventHandler(this.porNomeDaMaeToolStripMenuItem_Click);
            // 
            // pesquisarPorCPFtoolStripMenuItem
            // 
            this.pesquisarPorCPFtoolStripMenuItem.Name = "pesquisarPorCPFtoolStripMenuItem";
            this.pesquisarPorCPFtoolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.pesquisarPorCPFtoolStripMenuItem.Text = "Pesquisa por CPF";
            this.pesquisarPorCPFtoolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorCPFtoolStripMenuItem_Click);
            // 
            // pesquisarPorNomeCompletoToolStripMenuItem
            // 
            this.pesquisarPorNomeCompletoToolStripMenuItem.Name = "pesquisarPorNomeCompletoToolStripMenuItem";
            this.pesquisarPorNomeCompletoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.pesquisarPorNomeCompletoToolStripMenuItem.Text = "Pesquisar por nome completo";
            this.pesquisarPorNomeCompletoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorNomeCompletoToolStripMenuItem_Click);
            // 
            // verificarAtaualizaçãoToolStripMenuItem
            // 
            this.verificarAtaualizaçãoToolStripMenuItem.Name = "verificarAtaualizaçãoToolStripMenuItem";
            this.verificarAtaualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.verificarAtaualizaçãoToolStripMenuItem.Text = "Consultar usuário";
            this.verificarAtaualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.verificarAtaualizaçãoToolStripMenuItem_Click);
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirNovoUsuarioToolStripMenuItem});
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.incluirToolStripMenuItem.Text = "Incluir";
            // 
            // incluirNovoUsuarioToolStripMenuItem
            // 
            this.incluirNovoUsuarioToolStripMenuItem.Name = "incluirNovoUsuarioToolStripMenuItem";
            this.incluirNovoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.incluirNovoUsuarioToolStripMenuItem.Text = "Incluir novo usuário";
            this.incluirNovoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.incluirNovoUsuarioToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.últimaDataDeAlteraçãoToolStripMenuItem});
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // últimaDataDeAlteraçãoToolStripMenuItem
            // 
            this.últimaDataDeAlteraçãoToolStripMenuItem.Name = "últimaDataDeAlteraçãoToolStripMenuItem";
            this.últimaDataDeAlteraçãoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.últimaDataDeAlteraçãoToolStripMenuItem.Text = "Última data de alteração";
            this.últimaDataDeAlteraçãoToolStripMenuItem.Click += new System.EventHandler(this.últimaDataDeAlteraçãoToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 309);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Formulário Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNomeDaMaeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorCPFtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorNomeCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAtaualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirNovoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem últimaDataDeAlteraçãoToolStripMenuItem;
    }
}