using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioAlexandre.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Status { get; set; }
        public double ValorAPagar { get; set; }
        public Paciente ObjPaciente { get; set; }
        public IList<ExamesDoAtendimento> ObjListExamesDoAtendimento { get; set; }

    }
}