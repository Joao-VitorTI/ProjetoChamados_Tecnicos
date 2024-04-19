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
    }
}
