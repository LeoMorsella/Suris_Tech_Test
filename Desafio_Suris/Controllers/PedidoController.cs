using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio_Suris.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        public Pedido Pedido()
        {
            var pedidoJson = JsonConvert.DeserializeObject<Pedido>(System.IO.File.ReadAllText("pedido.json"));
            return pedidoJson;
        }

        [HttpPost]
        public async Task<IActionResult> Post(List<Articulo> articulos)
        {
            System.IO.File.Delete("pedido.json");
            var pedido = new Pedido(articulos);
            string jsonData = System.Text.Json.JsonSerializer.Serialize(pedido);
            string filePath = "pedido.json";
            await System.IO.File.AppendAllTextAsync(filePath, jsonData + "\n");
            return Ok("Datos guardados exitosamente");
        }
    }
}
