using ContaCorrenteAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Modelos.Dots
{
    public class TransacaoDto
    {
        
        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public DateTime DataHora { get; set; }

        public int IdConta { get; set; }
    }
}
