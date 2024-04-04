using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using Data;
using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;

namespace ChamadosTecnicosTec55
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MsgBox = MessageBox.Show("Quer mesmo fechar a Solução?", "Sistema Chamados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MsgBox == DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://sp.senac.br",
                UseShellExecute = true,
            });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcliente = new frm_AdicionarCliente();
            // Define o Formulário pai que no caso é o frm_Principal
            formcliente.MdiParent = this;
            formcliente.Show(); //usar só o show abre a tela com uma hierarquia, já o showdialog torna a tela que vai abrir a pricipal na hierarquia
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtecnico = new frm_AdicionarTecnico();
            formtecnico.MdiParent = this;
            formtecnico.Show();
        }

        private void gestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestorcliente = new frm_GerirClientes();
            gestorcliente.MdiParent = this;
            gestorcliente.Show();
        }
    }
}
