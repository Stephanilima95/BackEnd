using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

       private static List<Frutas> frutas = new List<Frutas>()
        {
            new Frutas(){ Id=1, Nome="Maçã", Cor="Vermelho", Categoria="Cítrica"},
            new Frutas(){ Id=2, Nome="Banana", Cor="Amarelo", Categoria="Tropical"},
            new Frutas(){ Id=3, Nome="Uva", Cor="Roxa", Categoria="Tropical"},
            new Frutas(){ Id=2, Nome="Limão", Cor="Verde", Categoria="Cítrica"},
            new Frutas(){ Id=3, Nome="Abacaxi", Cor="Amarelo", Categoria="Cítrica"},
        };

        public IActionResult Index()
        {
            return View(frutas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Frutas fruta)
        {
            fruta.Id = frutas.Max(f => f.Id) + 1;
            frutas.Add(fruta);
            return RedirectToAction("Index");
        }
        public IActionResult FrutasCitricas()
        {
            return View();
        }
        public IActionResult FrutasTropicais()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}