namespace ChamadosTecnicosTec55.Alterar
{
    partial class frm_GerirTecnico
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
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.dgv_GerirTecnicos = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GerirTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.Location = new System.Drawing.Point(33, 387);
            this.btn_Reiniciar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(109, 42);
            this.btn_Reiniciar.TabIndex = 15;
            this.btn_Reiniciar.Text = "&Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gerir Técnico";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(665, 387);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(109, 42);
            this.btn_Excluir.TabIndex = 13;
            this.btn_Excluir.Text = "&Excluir Técnico";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(548, 387);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(109, 42);
            this.btn_Alterar.TabIndex = 12;
            this.btn_Alterar.Text = "&Alterar Técnico";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incluir.Location = new System.Drawing.Point(431, 387);
            this.btn_Incluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(109, 42);
            this.btn_Incluir.TabIndex = 11;
            this.btn_Incluir.Text = "&Incluir Técnico";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // dgv_GerirTecnicos
            // 
            this.dgv_GerirTecnicos.AllowUserToAddRows = false;
            this.dgv_GerirTecnicos.AllowUserToDeleteRows = false;
            this.dgv_GerirTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GerirTecnicos.Location = new System.Drawing.Point(30, 71);
            this.dgv_GerirTecnicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_GerirTecnicos.Name = "dgv_GerirTecnicos";
            this.dgv_GerirTecnicos.ReadOnly = true;
            this.dgv_GerirTecnicos.Size = new System.Drawing.Size(744, 299);
            this.dgv_GerirTecnicos.TabIndex = 10;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(686, 22);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(88, 25);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.Text = "&Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Location = new System.Drawing.Point(476, 24);
            this.txb_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(202, 20);
            this.txb_Buscar.TabIndex = 8;
            // 
            // frm_GerirTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.dgv_GerirTecnicos);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txb_Buscar);
            this.Name = "frm_GerirTecnico";
            this.Text = "frm_GerirTecnico";
            this.Load += new System.EventHandler(this.frm_GerirTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GerirTecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.DataGridView dgv_GerirTecnicos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txb_Buscar;
    }
}