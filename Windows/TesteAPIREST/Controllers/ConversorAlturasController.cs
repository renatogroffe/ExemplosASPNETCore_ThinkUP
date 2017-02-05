using System;
using Microsoft.AspNetCore.Mvc;

namespace TesteAPIREST.Controllers
{
    [Route("api/[controller]")]
    public class ConversorAlturasController : Controller
    {
        /// <summary>
        /// Transforma uma altura em p�s para o equivalente em metros
        /// </summary>
        /// <param name="alturaPes">Altura em p�s</param>
        /// <returns>Objeto contendo a altura em p�s e metros</returns>
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