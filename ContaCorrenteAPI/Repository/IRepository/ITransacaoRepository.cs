using ContaCorrenteAPI.Modelos;
using ContaCorrenteAPI.Modelos.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Repository
{
    public interface ITransacaoRepository
    {
        ICollection<Transacao> GetTransacoes(); 
    }
}
