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
    public partial class frm_AlteraCliente : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frm_AlteraCliente(int codigo)
        {
            InitializeComponent();

            // Verifica se codigo é maior que zero
            if(codigo > 0)
            {
                // Cria uma instância do objeto Cliente
                Cliente cliente = new Cliente();
                ClienteDao clientedao = new ClienteDao(_conexao);

                cliente = clientedao.ObtemCliente(codigo);

                // Se o cliente não foi encontrado
                if( cliente == null )
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }
                txb_AltCodigo.Text = cliente.CodigoCliente.ToString();
                txb_AltNome.Text = cliente.Nome;
                txb_AltProfissao.Text = cliente.Profissao;
                txb_AltSetor.Text = cliente.Setor;
                txb_AltObs.Text = cliente.Obs;

            }
        }
    }
}
