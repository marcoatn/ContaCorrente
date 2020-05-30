using AutoMapper;
using ContaCorrenteAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContaCorrenteAPI.Modelos;
using ContaCorrenteAPI.Modelos.Dots;

namespace ContaCorrenteAPI.ContaCorrenteMapper
{
    public class ContaCorrenteMappings : Profile
    {
        public ContaCorrenteMappings()
        {
            CreateMap<Transacao, TransacaoDto>().ReverseMap();
        }
    }
}
