using CadastroPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroPessoas.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult Lista(Pessoa pessoa)
        {
            pessoa = new Pessoa()

            {
                PessoaId = 1,
                Nome = "Lucas André Lescano Cruz",
                DataDeNascimento = "08-03-1999",
                RG = "2332761-0"
            };
        
            return View(pessoa);
        }

    }
}