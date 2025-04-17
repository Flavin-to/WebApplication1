using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication1.Pages
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShutdownController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                // Exemplo: Comando para desligar o sistema (somente no ambiente de desenvolvimento)
                Process.Start("shutdown", "/s /f /t 0");

                // Retorna uma resposta de sucesso
                return Ok("Host desligado com sucesso.");
            }
            catch (Exception ex)
            {
                // Retorna erro se não for possível desligar o sistema
                return StatusCode(500, "Erro ao tentar desligar o host: " + ex.Message);
            }
        }
    }
}
