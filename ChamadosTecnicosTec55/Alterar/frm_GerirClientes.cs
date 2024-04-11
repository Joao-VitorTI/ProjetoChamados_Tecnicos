using ChamadosTecnicosTec55.Adicionar;
using Data;
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
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frm_GerirClientes()
        {
            InitializeComponent();
        }

        //Busca no DAO o Cliente
        private void ListarCliente() 
        {
            //Chama o Cliente DAO
            ClienteDao clientedao = new ClienteDao(_conexao);
            //Captura o valor digitado na barra texto TXB
            string busca = txb_Buscar.Text.ToString();

            //Chama o Metodo BuscarCliente do objeto
            DataSet ds = new DataSet();
            ds = clientedao.BuscaCliente(busca);

            // Defini o Datasource do DataGridView
            dgv_GerirClientes.DataSource = ds;

            //Defini o MEMBRO DO DATASET
            dgv_GerirClientes.DataMember = "Clientes";

        }

        private void frm_GerirClientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            var incluircliente = new frm_AdicionarCliente();
            //incluircliente.MdiParent = this;
            incluircliente.ShowDialog();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha está selecionada no DGV
            if (dgv_GerirClientes.SelectedRows.Count > 0) 
            {
                // obtém o código do cliente de linha selecionada
                int codigo = Convert.ToInt32(dgv_GerirClientes.CurrentRow.Cells[0].Value);

                var frmAlteraCliente = new frm_AlteraCliente(codigo);
                frmAlteraCliente.ShowDialog();

                // Apos a tela fechar listar os clientes cadastrados
                ListarCliente();
            }
            else
            {
                // Exibe uma mensagem de Aviso se nenhuma linha estiver selecionada
                MessageBox.Show("Selecione um registro para alteração","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(txb_Buscar.Text != string.Empty) 
            {
                ListarCliente();
                txb_Buscar.Text = string.Empty;
                txb_Buscar.Focus();
            }
            else 
            {
                MessageBox.Show("Digite algo para buscar!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }
    }
}
