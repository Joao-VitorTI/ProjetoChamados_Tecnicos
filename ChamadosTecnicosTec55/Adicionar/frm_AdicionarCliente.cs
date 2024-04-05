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

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frm_AdicionarCliente : Form
    {
        // Chama a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frm_AdicionarCliente()
        {
            InitializeComponent();
        }

        private void frm_AdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Nome.Clear();
            txb_Obs.Clear();
            txb_Profissao.Clear();
            txb_Setor.Clear();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Chama o objeto Cliente
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao(_conexao);

            if (string.IsNullOrWhiteSpace(txb_Nome.Text) || string.IsNullOrWhiteSpace(txb_Obs.Text) || string.IsNullOrWhiteSpace(txb_Profissao.Text) || string.IsNullOrWhiteSpace(txb_Setor.Text)) 
            {
                MessageBox.Show("CADE OS DADOS?", "Cliente");
            }
            else 
            {
                // Toda vez que mexer com BD usar try
                try 
                {
                    //preenche o Objeto Cliente
                    cliente.Nome = txb_Nome.Text;
                    cliente.Profissao = txb_Profissao.Text;
                    cliente.Obs = txb_Obs.Text;
                    cliente.Setor = txb_Setor.Text;

                    // Chama o DAO para incluir o cliente
                    clientedao.IncluiCliente(cliente);

                    MessageBox.Show("Cadastrado com Sucesso!", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Erro ao Cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
