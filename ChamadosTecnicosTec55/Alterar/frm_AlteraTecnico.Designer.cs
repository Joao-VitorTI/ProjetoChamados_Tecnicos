namespace ChamadosTecnicosTec55.Alterar
{
    partial class frm_AlteraTecnico
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.txb_AltCodigo = new System.Windows.Forms.TextBox();
            this.txb_AltObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_AltEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_AltEspecialidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_AltNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_AltSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(34, 432);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(82, 28);
            this.btn_Ok.TabIndex = 21;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // txb_AltCodigo
            // 
            this.txb_AltCodigo.Location = new System.Drawing.Point(34, 84);
            this.txb_AltCodigo.Name = "txb_AltCodigo";
            this.txb_AltCodigo.ReadOnly = true;
            this.txb_AltCodigo.Size = new System.Drawing.Size(68, 20);
            this.txb_AltCodigo.TabIndex = 20;
            // 
            // txb_AltObs
            // 
            this.txb_AltObs.Location = new System.Drawing.Point(34, 335);
            this.txb_AltObs.Multiline = true;
            this.txb_AltObs.Name = "txb_AltObs";
            this.txb_AltObs.Size = new System.Drawing.Size(287, 78);
            this.txb_AltObs.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Obs";
            // 
            // txb_AltEmail
            // 
            this.txb_AltEmail.Location = new System.Drawing.Point(34, 241);
            this.txb_AltEmail.Name = "txb_AltEmail";
            this.txb_AltEmail.Size = new System.Drawing.Size(287, 20);
            this.txb_AltEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // txb_AltEspecialidade
            // 
            this.txb_AltEspecialidade.Location = new System.Drawing.Point(34, 195);
            this.txb_AltEspecialidade.Name = "txb_AltEspecialidade";
            this.txb_AltEspecialidade.Size = new System.Drawing.Size(287, 20);
            this.txb_AltEspecialidade.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Especialidade";
            // 
            // txb_AltNome
            // 
            this.txb_AltNome.Location = new System.Drawing.Point(34, 149);
            this.txb_AltNome.Name = "txb_AltNome";
            this.txb_AltNome.Size = new System.Drawing.Size(287, 20);
            this.txb_AltNome.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alterar Técnico";
            // 
            // txb_AltSenha
            // 
            this.txb_AltSenha.Location = new System.Drawing.Point(34, 287);
            this.txb_AltSenha.Name = "txb_AltSenha";
            this.txb_AltSenha.PasswordChar = '*';
            this.txb_AltSenha.Size = new System.Drawing.Size(287, 20);
            this.txb_AltSenha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Senha";
            // 
            // frm_AlteraTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 478);
            this.Controls.Add(this.txb_AltSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txb_AltCodigo);
            this.Controls.Add(this.txb_AltObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_AltEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_AltEspecialidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_AltNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AlteraTecnico";
            this.Text = "frm_AlteraTecnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox txb_AltCodigo;
        private System.Windows.Forms.TextBox txb_AltObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_AltEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_AltEspecialidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_AltNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_AltSenha;
        private System.Windows.Forms.Label label6;
    }
}