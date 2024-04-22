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
    public partial class frm_GerirTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frm_GerirTecnico()
        {
            InitializeComponent();
        }

        // Busca no DAO o Tecnico
        private void ListarTecnico()
        {
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);
            string busca = txb_Buscar.Text.ToString();
            DataSet ds = new DataSet();
            ds = tecnicodao.BuscaTecnico(busca);

            dgv_GerirTecnicos.DataSource = ds;
            dgv_GerirTecnicos.DataMember = "Tecnicos";
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            var incluirtecnico = new frm_AdicionarTecnico();
            incluirtecnico.ShowDialog();
        }

        private void frm_GerirTecnico_Load(object sender, EventArgs e)
        {
            ListarTecnico();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if(dgv_GerirTecnicos.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgv_GerirTecnicos.CurrentRow.Cells[0].Value);

                var frmAlteraTecnico = new frm_AlteraTecnico(codigo);
                frmAlteraTecnico.ShowDialog();

                ListarTecnico();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alteração", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if(dgv_GerirTecnicos.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgv_GerirTecnicos.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(resultado == DialogResult.Yes)
                {
                    TecnicoDao tecnicodao = new TecnicoDao(_conexao);
                    tecnicodao.ExcluiTecnico(codigo);
                    ListarTecnico();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(txb_Buscar.Text != string.Empty)
            {
                ListarTecnico();
                txb_Buscar.Text = string.Empty;
                txb_Buscar.Focus();
            }
            else
            {
                MessageBox.Show("Digite algo para buscar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            ListarTecnico();
        }
    }
}
