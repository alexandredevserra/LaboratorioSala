using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioAlexandre.Models
{
    public class ExamesDoAtendimento
    {
        public ExamesDoAtendimento(Atendimento objAtendimento)
        {
            ObjAtendimento = objAtendimento;
        }
        public int Id { get; set; }
        public DateTime DataExame { get; set; }
        public string Status { get; set; }
        public Exame ObjExame { get; set; }
        public Atendimento ObjAtendimento { get; set; }

    }
}