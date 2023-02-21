using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01,"Arthur A.Ferreira","857.032.950-41","arthur.ferreira@sp.senai.br","Madruga");
        Cliente cliente2 = new Cliente(02,"Maria da Silva","045.789.123.99","maria.marya@sp.senai.br","Betove");
        Cliente cliente3 = new Cliente(03,"Vinicius Alessandro","123.321.213-31","vinialess@sp.senai.br","Spike");
        Cliente cliente4 = new Cliente(04,"Bastiao Ferreira de Oliveira","456.654.546.46","bastiao.oliveira123@sp.senai.br","Ted");
        Cliente cliente5 = new Cliente(05,"Margarida Alicia","789.987.897-79","alicia.margaridaa@sp.senai.br","Jack");
        //Criar lista para guardar clientes
        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        //Bolsa que vai levar os dados para algum lugar que será a view
        ViewBag.listaCliente = listaCliente;



        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A","14.182.102/0001-01","c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02,"Ctrl Alt Dog","15.836.698/0001-57","ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC","40.810.224/0001-83","boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04,"Tik Tok Dogs","87.945.350/0001-89","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever","18.760.614/0001-37","contato@bff.us");
        //Criar lista para guardar Fornecedores
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;

        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
