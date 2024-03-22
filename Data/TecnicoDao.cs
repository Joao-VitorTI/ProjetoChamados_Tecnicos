using System;
using System.Collections.Generic;
using System.Data.SqlClient; // ADO para SQL Server
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //ADO.NET

namespace Data
{
    public class TecnicoDao
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexão
        public TecnicoDao(string conexao) 
        {
            // TOME CONEXÃO
            _conexao = conexao;
        }

        //INSERE TECNICO
        public void IncluiTecnico(Tecnico tecnico) 
        {
            using(SqlConnection conexaoBd = new SqlConnection(_conexao)) 
            {
                string sql = "insert into Tecnicos (nome, especialidade, email, senha, obs) values (@nome, @especialidade, @email, @senha, @obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd)) 
                {
                    comando.Parameters.AddWithValue("@nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnico.Email);
                    comando.Parameters.AddWithValue("@senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@obs", tecnico.Obs);

                    try 
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex) 
                    {
                        throw new Exception("Erro ao incluir Tecnico"+ex.Message);
                    }
                }
            }
        }

    }
}
