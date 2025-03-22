using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using MinhaLib;

namespace ConsultaDePesssoas
{
    internal class PessoaDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDPessoas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setErro("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inseriUmaPessoa(Pessoa umaPessoa)
        {
            String aux = "insert into TabPessoa(codigo,nome,sexo,idade) values ('" + umaPessoa.getCodigo() + "','" + umaPessoa.getNome() + "','" + umaPessoa.getSexo() + "','" + umaPessoa.getIdade() + "')";

            strSQL = new OleDbCommand(aux, conn);
            Erro.setErro(false);
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setErro("A inserção não foi possivel, chave duplicada");
            }
        }

        public static void consultaUmaPessoa(Pessoa umaPessoa)
        {
            String aux = "select * from TabPessoa where codigo ='" + umaPessoa.getCodigo() + "'";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
            Erro.setErro(false);

            if (result.Read())
            {
                umaPessoa.setNome(result.GetString(1));
                umaPessoa.setSexo(result.GetString(2));
                umaPessoa.setIdade(result.GetString(3));
            }
            else Erro.setErro("Livro não cadastrado.");
        }
    }
}
