namespace ChamadosTecnicosTec55
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.gestorDeTecnicosToolStripMenuItem,
            this.gestorToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.documentaçãoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.fecharSoluçãoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.técnicoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // técnicoToolStripMenuItem
            // 
            this.técnicoToolStripMenuItem.Name = "técnicoToolStripMenuItem";
            this.técnicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.técnicoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.técnicoToolStripMenuItem.Text = "Técnico";
            this.técnicoToolStripMenuItem.Click += new System.EventHandler(this.técnicoToolStripMenuItem_Click);
            // 
            // gestorDeTecnicosToolStripMenuItem
            // 
            this.gestorDeTecnicosToolStripMenuItem.Name = "gestorDeTecnicosToolStripMenuItem";
            this.gestorDeTecnicosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gestorDeTecnicosToolStripMenuItem.Text = "Gestor de Técnicos";
            this.gestorDeTecnicosToolStripMenuItem.Click += new System.EventHandler(this.gestorDeTecnicosToolStripMenuItem_Click);
            // 
            // gestorToolStripMenuItem
            // 
            this.gestorToolStripMenuItem.Name = "gestorToolStripMenuItem";
            this.gestorToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.gestorToolStripMenuItem.Text = "Gestor de Clientes";
            this.gestorToolStripMenuItem.Click += new System.EventHandler(this.gestorToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.documentaçãoToolStripMenuItem.Text = "Documentação";
            this.documentaçãoToolStripMenuItem.Click += new System.EventHandler(this.documentaçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // fecharSoluçãoToolStripMenuItem
            // 
            this.fecharSoluçãoToolStripMenuItem.Name = "fecharSoluçãoToolStripMenuItem";
            this.fecharSoluçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.fecharSoluçãoToolStripMenuItem.Text = "Fechar Solução";
            this.fecharSoluçãoToolStripMenuItem.Click += new System.EventHandler(this.fecharSoluçãoToolStripMenuItem_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Principal";
            this.Text = "frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeTecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSoluçãoToolStripMenuItem;
    }
}