using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ContaCorrenteAPI.Modelos.Dots;
using ContaCorrenteAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContaCorrenteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly ITransacaoRepository _npRepo;
        private readonly IMapper _mapper;

        public ContaCorrenteController(ITransacaoRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTransacoes()//definir datas posteriormente
        {
            var objList = _npRepo.GetTransacoes();

            var objDto = new List<TransacaoDto>();

            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<TransacaoDto>(obj));
            }

            return Ok(objDto);
        }
    }
}