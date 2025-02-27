using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZsigmondABetyarController : ControllerBase
    {
        private static readonly string[] Aranykopesek = new[]
        {
            "A higany nem finom", "Nem akarok élni kb", "Aha igen köszi", "Jólvan akkor", "Bömbölj", "Túrjad a havat", "Blokkolnám"
        };

        private readonly ILogger<ZsigmondABetyarController> _logger;

        public ZsigmondABetyarController(ILogger<ZsigmondABetyarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ZsigaAranykopes")]
        public IEnumerable<ZsigmondABetyar> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ZsigmondABetyar
            {
                Aranykopes = Aranykopesek[Random.Shared.Next(Aranykopesek.Length)]
            })
            .ToArray();
        }
    }
}
