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
    public partial class frm_AlteraTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frm_AlteraTecnico(int codigo)
        {
            InitializeComponent();

            if(codigo > 0)
            {
                Tecnico tecnico = new Tecnico();
                TecnicoDao tecnicodao = new TecnicoDao(_conexao);

                tecnico = tecnicodao.ObtemTecnico(codigo);

                if(tecnico == null)
                {
                    MessageBox.Show("Técnico não encontrado");
                    this.Close();
                }
                txb_AltCodigo.Text = tecnico.CodigoTecnico.ToString();
                txb_AltNome.Text = tecnico.Nome;
                txb_AltEspecialidade.Text = tecnico.Especialidade;
                txb_AltEmail.Text = tecnico.Email;
                txb_AltSenha.Text = tecnico.Senha;
                txb_AltObs.Text = tecnico.Obs;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            try
            {
                tecnico.Nome = txb_AltNome.Text;
                tecnico.Especialidade = txb_AltEspecialidade.Text;
                tecnico.Email = txb_AltEmail.Text;
                tecnico.Senha = txb_AltSenha.Text;
                tecnico.Obs = txb_AltObs.Text;

                int codigo = Convert.ToInt32(txb_AltCodigo.Text);
                tecnico.CodigoTecnico = codigo;

                tecnicodao.AlterarTecnico(tecnico);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
