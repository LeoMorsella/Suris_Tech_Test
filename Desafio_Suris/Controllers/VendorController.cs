using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio_Suris.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IList<Vendedor> Get()
        {
            string jsonString = @"[
                                   {
                                      ""id"": 1,
                                      ""descripcion"": ""Hernan Garna""
                                    },
                                    {
                                      ""id"": 2,
                                      ""descripcion"": ""Lucas Lauriente""
                                    },
                                    {
                                      ""id"": 3,
                                      ""descripcion"": ""Martin Gomez""
                                    },
                                    {
                                      ""id"": 4,
                                      ""descripcion"": ""Alan Tellerio""
                                    },
                                    {
                                      ""id"": 5,
                                      ""descripcion"": ""Gonzalo Hernandez""
                                    },
                                    {
                                      ""id"": 6,
                                      ""descripcion"": ""Ezequiel Martinez""
                                    }
                                  ]";
            var vendedoresJson = JsonConvert.DeserializeObject<List<Vendedor>>(jsonString);
            JArray vendedoresArray = JArray.FromObject(vendedoresJson);
            IList<Vendedor> vendedores = vendedoresArray.Select(p => new Vendedor
            {
                id = (int)p["id"],
                descripcion = (string)p["descripcion"]
            }).ToList();
            return vendedores;
        }
    }
}
