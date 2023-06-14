using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppAvaliacoes
{
    class SqlCommands
    {
        private const string stringConexao = "server=SNCCHLAB01F119\\TEW_SQLEXPRESS;" +
                            "database=appAvaliacao;" +
                             "trusted_connection=true;" +
                             "trustServerCertificate=true;";
        private string comando;

        SqlConnection sqlCon = new SqlConnection(stringConexao);
        SqlCommand sqlComando;
        SqlDataReader dr;

        private void abrirConexao()
        {
            sqlCon.Open();

            if (sqlCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("deu ruim!");
            }
        }


        public int checaUsuarios(string email, string senha)
        {
            abrirConexao();

            comando = $"SELECT * FROM Usuarios WHERE email_usuario = @email AND senha_hash = @password";

            sqlComando = new SqlCommand(comando, sqlCon);
            sqlComando.Parameters.AddWithValue("@email", email);
            sqlComando.Parameters.AddWithValue("@password", senha);

            dr = sqlComando.ExecuteReader();

            if(dr.HasRows)
            {
                return (int)dr[0];
            } else { return 0; }

        }
    }
}
