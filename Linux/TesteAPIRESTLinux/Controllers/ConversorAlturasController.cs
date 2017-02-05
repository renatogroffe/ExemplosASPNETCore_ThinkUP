using System;
using Microsoft.AspNetCore.Mvc;

namespace TesteAPIRESTLinux.Controllers
{
    [Route("api/[controller]")]
    public class ConversorAlturasController : Controller
    {
        [HttpGet("PesMetros/{alturaPes}")]
        public object Get(double alturaPes)
        {
            return new
            {
                AlturaPes = alturaPes,
                AlturaMetros = Math.Round(alturaPes * 0.3048, 4)
            };
        }
    }
}