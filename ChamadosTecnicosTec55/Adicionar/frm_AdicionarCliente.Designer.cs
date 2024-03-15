namespace ChamadosTecnicosTec55.Adicionar
{
    partial class frm_AdicionarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Profissao = new System.Windows.Forms.TextBox();
            this.txb_Setor = new System.Windows.Forms.TextBox();
            this.txb_Obs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(12, 80);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(336, 20);
            this.txb_Nome.TabIndex = 1;
            // 
            // txb_Profissao
            // 
            this.txb_Profissao.Location = new System.Drawing.Point(12, 128);
            this.txb_Profissao.Name = "txb_Profissao";
            this.txb_Profissao.Size = new System.Drawing.Size(336, 20);
            this.txb_Profissao.TabIndex = 2;
            // 
            // txb_Setor
            // 
            this.txb_Setor.Location = new System.Drawing.Point(12, 174);
            this.txb_Setor.Name = "txb_Setor";
            this.txb_Setor.Size = new System.Drawing.Size(336, 20);
            this.txb_Setor.TabIndex = 3;
            // 
            // txb_Obs
            // 
            this.txb_Obs.Location = new System.Drawing.Point(12, 221);
            this.txb_Obs.Multiline = true;
            this.txb_Obs.Name = "txb_Obs";
            this.txb_Obs.Size = new System.Drawing.Size(336, 70);
            this.txb_Obs.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observação";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(82, 336);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(215, 336);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_AdicionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 399);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txb_Obs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Setor);
            this.Controls.Add(this.txb_Profissao);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AdicionarCliente";
            this.Text = "Adicionar Cliente";
            this.Load += new System.EventHandler(this.frm_AdicionarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Profissao;
        private System.Windows.Forms.TextBox txb_Setor;
        private System.Windows.Forms.TextBox txb_Obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Limpar;
    }
}