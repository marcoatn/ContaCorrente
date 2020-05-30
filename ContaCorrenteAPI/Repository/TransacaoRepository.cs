using ContaCorrenteAPI.Dados;
using ContaCorrenteAPI.Modelos;
using ContaCorrenteAPI.Modelos.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Repository
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly ApplicationDbContext _db;

        public TransacaoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<Transacao> GetTransacoes()
        {
            return _db.Transacao.OrderBy(a => a.Descricao).ToList();
        }
    }
}
