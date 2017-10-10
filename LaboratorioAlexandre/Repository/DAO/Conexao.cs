﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace LaboratorioAlexandre.Repository.DAO
{
    public class Conexao
    {
        private SqlConnection Conectar()
        {
            //Para poder ter acesso ao BD
            string stringConexao = "Data Source = LAB04-08 ; Initial Catalog = BD_Laboratorio6; User Id = sa ; Password = uniron$2017";
            //Conectar o BD
            SqlConnection conexao = new SqlConnection(stringConexao);
            //Abrir o BD
            conexao.Open();

            return conexao;
        }

        public int ExecutarCrud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            int id = Convert.ToInt32(comando.ExecuteScalar());
            con.Close();

            return id;
        }

        public SqlDataReader ExecutarSelect(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
            //É com o SqlDataReader que vamos fazer o select no banco para podermos fazer uma busca
        }
    }
}