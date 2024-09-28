using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace Desafio_Suris.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        // GET: api/<ArticulosController>
        [HttpGet]
        public IList<Articulo> Get()
        {
            string jsonString = @"[
                                   {
                                     ""codigo"": ""K1020"",
                                     ""descripcion"": ""Colchon Telgo"",
                                     ""precio"": 10256.12,
                                     ""deposito"": 1,
                                   },
                                   {
                                     ""codigo"": ""K1022%%"",
                                     ""descripcion"": ""Colchon Seally"",
                                     ""precio"": 18256.12,
                                     ""deposito"": 4,
                                   },
                                   {
                                     ""codigo"": ""K1024"",
                                     ""descripcion"": ""Sommier Telgo"",
                                     ""precio"": 14256.12,
                                     ""deposito"": 1,
                                   },
                                   {
                                     ""codigo"": ""K1026"",
                                     ""descripcion"": ""Sommier Seally"",
                                     ""precio"": 13256.12,
                                     ""deposito"": 1,
                                   },
                                   {
                                     ""codigo"": ""F1026"",
                                     ""descripcion"": ""Almohada Seally"",
                                     ""precio"": 0,
                                     ""deposito"": 1,
                                   },
                                   {
                                     ""codigo"": ""F1026"",
                                     ""descripcion"": ""Almohada Seally"",
                                     ""precio"": 3250.12,
                                     ""deposito"": 4,
                                   },
                                      {
                                     ""codigo"": ""K1024"",
                                     ""descripcion"": ""Sommier Telgo"",
                                     ""precio"": 14256.12,
                                     ""deposito"": 4,
                                   },
                                   {
                                     ""codigo"": ""K1026"",
                                     ""descripcion"": ""Sommier Seally"",
                                     ""precio"": -13256.12,
                                     ""deposito"": 8,
                                   },
                                   {
                                     ""codigo"": ""K!°1026"",
                                     ""descripcion"": ""Sommier Seally"",
                                     ""precio"": -13256.12,
                                     ""deposito"": 8,
                                   }
                                  ]";
                var articulosJson = JsonConvert.DeserializeObject<List<Articulo>>(jsonString);
                JArray articulosArray = JArray.FromObject(articulosJson);
                IList<Articulo> articulos = articulosArray.Select(p => new Articulo
                {
                    codigo = (string)p["codigo"],
                    descripcion = (string)p["descripcion"],
                    precio = (float)p["precio"],
                    deposito = (int)p["deposito"]
                }).ToList();
                return articulos;
            }
        }
    }
