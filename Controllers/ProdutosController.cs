using Microsoft.AspNetCore.Mvc;
using ProjetoTreino0702.Models;
using ProjetoTreino0702.Persistencia;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjetoTreino0702.Controllers
{
    public class ProdutosController : Controller
    {
        private ProjetoXContext _context;
        public ProdutosController(ProjetoXContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            List<Produto> produtos = _context.Produtos.ToList();
            return View(produtos);  
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges(); 
            TempData["cadSucess"] = $"Sucesso ao cadastrar: {produto.Nome}";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            Produto produto = _context.Produtos.Find(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            TempData["edit"] = $"Produto editado com sucesso!";
            return RedirectToAction("Editar");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            Produto produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            TempData["delet"] = $"Produto excluído com sucesso!";
            return RedirectToAction("Home");
        }


    }
}
