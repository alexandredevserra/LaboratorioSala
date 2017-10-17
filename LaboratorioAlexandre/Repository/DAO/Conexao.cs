using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LaboratorioAlexandre.Repository.DAO
{
    public class Conexao
    {
        private static SqlConnection Conectar()
        {
            //Para poder ter acesso ao BD
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoAtendimentoHospitalar"].ConnectionString;
            //Conectar o BD
            SqlConnection conexao = new SqlConnection(stringConexao);
            //Abrir o BD
            conexao.Open();

            return conexao;
        }

        public static int ExecutarCrud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            int id = Convert.ToInt32(comando.ExecuteScalar());
            con.Close();

            return id;
        }

        public static SqlDataReader ExecutarSelect(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
            //É com o SqlDataReader que vamos fazer o select no banco para podermos fazer uma busca
        }
    }
}