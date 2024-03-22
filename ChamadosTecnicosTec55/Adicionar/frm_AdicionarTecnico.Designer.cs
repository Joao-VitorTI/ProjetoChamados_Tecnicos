namespace ChamadosTecnicosTec55.Adicionar
{
    partial class frm_AdicionarTecnico
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
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Especialidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Obs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Técnico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(31, 90);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(329, 20);
            this.txb_Nome.TabIndex = 2;
            // 
            // txb_Especialidade
            // 
            this.txb_Especialidade.Location = new System.Drawing.Point(31, 134);
            this.txb_Especialidade.Name = "txb_Especialidade";
            this.txb_Especialidade.Size = new System.Drawing.Size(329, 20);
            this.txb_Especialidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especialidade";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(31, 179);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(329, 20);
            this.txb_Email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(31, 227);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.PasswordChar = '+';
            this.txb_Senha.Size = new System.Drawing.Size(329, 20);
            this.txb_Senha.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // txb_Obs
            // 
            this.txb_Obs.Location = new System.Drawing.Point(31, 276);
            this.txb_Obs.Multiline = true;
            this.txb_Obs.Name = "txb_Obs";
            this.txb_Obs.Size = new System.Drawing.Size(329, 80);
            this.txb_Obs.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Obs";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(68, 393);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 11;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(245, 393);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 12;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_AdicionarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 451);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txb_Obs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Especialidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AdicionarTecnico";
            this.Text = "frm_AdicionarTecnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Especialidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Obs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Limpar;
    }
}