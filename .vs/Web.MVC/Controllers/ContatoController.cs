﻿using Microsoft.AspNetCore.Mvc;

namespace Web.MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        { 
            return View();
        }
        public IActionResult Apagar()
        {   
            return View();
        }
    }
}
