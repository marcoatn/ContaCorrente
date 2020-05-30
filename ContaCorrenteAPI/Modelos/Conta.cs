using ContaCorrenteAPI.Modelos;
using ContaCorrenteAPI.Modelos.Dots;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Saldo { get; set; }
        [ForeignKey("Titular")]
        public int IdTitular { get; set; }
        public virtual Titular Titular { get; set; }
        public ICollection<Transacao> Transacoes { get; set; }
    }
}
