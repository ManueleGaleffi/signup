using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nuova_cartella.Models;

namespace Nuova_cartella.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static List<Prodotto> Prodotti = new List<Prodotto>();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        
    }

    public IActionResult Index()
{
    //HttpContext.Session.SetString("NomeUtente", "Lorenzo Bologna");
    return View();
}


    public IActionResult Privacy()
    {
        string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
        if (string.IsNullOrEmpty(nomeUtente))
        return Redirect("\\home\\SignUp");
        return View ();
    }
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Conferma(Prenotazione p){
    
        HttpContext.Session.SetString("NomeUtente", p.Nome);
        return View(p);
    }
        public IActionResult Purchase()
    {
        return View();
    }
        public IActionResult Cart(Prodotto p)
    {
        dbContext db = new dbContext();
        db.Prodotti.Add(p);
        db.SaveChanges();
        
        return View( db.Prodotti.ToList() );
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
