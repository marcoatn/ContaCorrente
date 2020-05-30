using ContaCorrenteAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Modelos
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public double Valor { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [ForeignKey("Conta")]
        public int IdConta { get; set; }
        public  Conta Conta { get; set; }
    }
}
