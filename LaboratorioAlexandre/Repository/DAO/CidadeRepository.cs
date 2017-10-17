using System;
using System.Collections.Generic;
using LaboratorioAlexandre.Models;
using System.Data.SqlClient;
using System.Data;

namespace LaboratorioAlexandre.Repository.DAO
{
    public class CidadeRepository
    {
        public IList<Cidade> SelecionaTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Cidades";

            SqlDataReader dr = Conexao.ExecutarSelect(comando);
            IList<Cidade> cidades = new List<Cidade>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cidade c = new Cidade();
                    c.Id = (int)dr["cidadeId"];
                    c.Nome = (string)dr["nome"];
                    c.EnumEstado = (Estado) Enum.Parse(typeof(Estado), (string)dr["estado"]);
                    cidades.Add(c);
                }

                return cidades;
            }
            else
            {
                return null;
            }
            
            
        }
    }
}