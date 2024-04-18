namespace ChamadosTecnicosTec55.Alterar
{
    partial class frm_AlteraCliente
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
            this.txb_AltNome = new System.Windows.Forms.TextBox();
            this.txb_AltProfissao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_AltSetor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_AltObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_AltCodigo = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txb_AltNome
            // 
            this.txb_AltNome.Location = new System.Drawing.Point(37, 153);
            this.txb_AltNome.Name = "txb_AltNome";
            this.txb_AltNome.Size = new System.Drawing.Size(287, 20);
            this.txb_AltNome.TabIndex = 2;
            // 
            // txb_AltProfissao
            // 
            this.txb_AltProfissao.Location = new System.Drawing.Point(37, 199);
            this.txb_AltProfissao.Name = "txb_AltProfissao";
            this.txb_AltProfissao.Size = new System.Drawing.Size(287, 20);
            this.txb_AltProfissao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Profissão";
            // 
            // txb_AltSetor
            // 
            this.txb_AltSetor.Location = new System.Drawing.Point(37, 245);
            this.txb_AltSetor.Name = "txb_AltSetor";
            this.txb_AltSetor.Size = new System.Drawing.Size(287, 20);
            this.txb_AltSetor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Setor";
            // 
            // txb_AltObs
            // 
            this.txb_AltObs.Location = new System.Drawing.Point(37, 293);
            this.txb_AltObs.Multiline = true;
            this.txb_AltObs.Name = "txb_AltObs";
            this.txb_AltObs.Size = new System.Drawing.Size(287, 78);
            this.txb_AltObs.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Obs";
            // 
            // txb_AltCodigo
            // 
            this.txb_AltCodigo.Location = new System.Drawing.Point(37, 88);
            this.txb_AltCodigo.Name = "txb_AltCodigo";
            this.txb_AltCodigo.ReadOnly = true;
            this.txb_AltCodigo.Size = new System.Drawing.Size(68, 20);
            this.txb_AltCodigo.TabIndex = 9;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(37, 390);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(82, 28);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // frm_AlteraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 449);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txb_AltCodigo);
            this.Controls.Add(this.txb_AltObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_AltSetor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_AltProfissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_AltNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AlteraCliente";
            this.Text = "frm_AlteraCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_AltNome;
        private System.Windows.Forms.TextBox txb_AltProfissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_AltSetor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_AltObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_AltCodigo;
        private System.Windows.Forms.Button btn_Ok;
    }
}