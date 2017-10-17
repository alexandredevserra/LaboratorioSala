using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaboratorioAlexandre.Repository.DAO;
using System.ComponentModel.DataAnnotations;

namespace LaboratorioAlexandre.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Estado EnumEstado { get; set; }

        public IList<Cidade> GetAll()
        {
            return new CidadeRepository().SelecionaTodos();
        }
    }
}