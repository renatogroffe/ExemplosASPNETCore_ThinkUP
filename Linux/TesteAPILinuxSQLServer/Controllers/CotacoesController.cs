using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICotacoes.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        // GET api/values
        [HttpGet("{id}")]
        public Cotacao Get(
            [FromServices]CotacoesDAO DAO,
            string id)
        {
            return DAO.Obter(id);
        }
    }
}