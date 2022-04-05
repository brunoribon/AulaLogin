using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            Random rand = new Random();
            List<UsuariosModel> model = new List<UsuariosModel>();
            for (int i = 0; i < rand.Next(20, 99); i++)
            {
                UsuariosModel user = new UsuariosModel();
                user.Login = "Login - " + i;
                user.Id = i;
                user.Nome = "Nome " + i;
                user.Senha = rand.Next(18458, 548157) + "" + rand.Next(18458, 999999) + "" + rand.Next(55555, 874521);
                model.Add(user);
            }
            return View(model);
        }
    }
}
