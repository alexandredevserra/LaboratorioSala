using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioAlexandre.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public PlanoSaude ObjPlanoSaudo { get; set; }
        public Cidade ObjCidade { get; set; }
        public TipoConveniado EnumTipoConveniado { get; set; }

    }
}