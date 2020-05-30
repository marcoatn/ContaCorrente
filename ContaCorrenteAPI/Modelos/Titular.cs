using ContaCorrenteAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Modelos
{
    public class Titular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        //public ICollection<Conta> Contas { get; set; }
    }
}
