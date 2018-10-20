using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TesteApi.api.Models;

namespace TesteApi.api.Controllers
{
    [Route("Company/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {

        [HttpGet]
        public List<Empresas> Get()
        {
            var empresas = EmpresasContext.Listarempresas();
            return empresas;
        }

        [HttpPost]
        public void Post(string id)
        {
            EmpresasContext.Adicionarempresas(id);

        }
    }
}
