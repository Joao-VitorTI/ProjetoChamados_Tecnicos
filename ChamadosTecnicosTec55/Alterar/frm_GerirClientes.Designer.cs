namespace ChamadosTecnicosTec55.Alterar
{
    partial class frm_GerirClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GerirClientes));
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_GerirClientes = new System.Windows.Forms.DataGridView();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GerirClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Location = new System.Drawing.Point(464, 41);
            this.txb_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(202, 20);
            this.txb_Buscar.TabIndex = 0;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(674, 39);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(88, 25);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "&Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_GerirClientes
            // 
            this.dgv_GerirClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GerirClientes.Location = new System.Drawing.Point(18, 88);
            this.dgv_GerirClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_GerirClientes.Name = "dgv_GerirClientes";
            this.dgv_GerirClientes.Size = new System.Drawing.Size(744, 299);
            this.dgv_GerirClientes.TabIndex = 2;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incluir.Location = new System.Drawing.Point(419, 404);
            this.btn_Incluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(109, 42);
            this.btn_Incluir.TabIndex = 3;
            this.btn_Incluir.Text = "&Incluir Cliente";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(536, 404);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(109, 42);
            this.btn_Alterar.TabIndex = 4;
            this.btn_Alterar.Text = "&Alterar Cliente";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(653, 404);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(109, 42);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "&Excluir Cliente";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gerir Cliente";
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.Location = new System.Drawing.Point(21, 404);
            this.btn_Reiniciar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(109, 42);
            this.btn_Reiniciar.TabIndex = 7;
            this.btn_Reiniciar.Text = "&Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // frm_GerirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.dgv_GerirClientes);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txb_Buscar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_GerirClientes";
            this.Text = "frm_GerirClientes";
            this.Load += new System.EventHandler(this.frm_GerirClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GerirClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_GerirClientes;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reiniciar;
    }
}