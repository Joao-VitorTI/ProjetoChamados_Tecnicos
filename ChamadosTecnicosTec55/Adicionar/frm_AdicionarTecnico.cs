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
    public partial class frm_AdicionarTecnico : Form
    {
        //CHAMA A CONEXAO
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frm_AdicionarTecnico()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Nome.Clear();
            txb_Especialidade.Clear();
            txb_Email.Clear();
            txb_Senha.Clear();
            txb_Obs.Clear();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //CHAMA O OBJETO TECNICO
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            if (string.IsNullOrWhiteSpace(txb_Nome.Text) || string.IsNullOrWhiteSpace(txb_Especialidade.Text) || string.IsNullOrWhiteSpace(txb_Email.Text) || string.IsNullOrWhiteSpace(txb_Senha.Text) || string.IsNullOrWhiteSpace(txb_Obs.Text)) 
            {
                MessageBox.Show("CADE OS DADOS!! PREENCHA TODOS OS CAMPOS", "Atenção");
            }
            else 
            {
                // TODA VEZ QUE MEXER COM BD USAR TRY

                try 
                {
                    // PREENCHE O OBJETO TECNICO
                    tecnico.Nome = txb_Nome.Text;
                    tecnico.Especialidade = txb_Especialidade.Text;
                    tecnico.Email = txb_Email.Text;
                    tecnico.Senha = txb_Senha.Text;
                    tecnico.Obs = txb_Obs.Text;

                    //CHAMA O DAO PARA INCLUIR O CLIENTE
                    tecnicodao.IncluiTecnico(tecnico);

                    MessageBox.Show("Técnico cadastrado com sucesso!!", "Técnico");

                    this.Close();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erro ao Cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
