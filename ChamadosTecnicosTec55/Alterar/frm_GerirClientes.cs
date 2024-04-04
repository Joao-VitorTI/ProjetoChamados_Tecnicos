using ChamadosTecnicosTec55.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frm_GerirClientes : Form
    {
        public frm_GerirClientes()
        {
            InitializeComponent();
        }

        private void frm_GerirClientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            var incluircliente = new frm_AdicionarCliente();
            //incluircliente.MdiParent = this;
            incluircliente.ShowDialog();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
