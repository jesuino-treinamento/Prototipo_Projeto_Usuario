using ProjetoUsuario.Models.Dtos;
using ProjetoUsuario.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoUsuario.WebApp.Areas.Painel.Models;

namespace ProjetoUsuarios.Areas.Painel.Controllers
{
    [Area("Painel")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioBusiness _usuarioBusiness;

        public UsuarioController(IUsuarioBusiness usuarioBusiness)
        {
            this._usuarioBusiness = usuarioBusiness;
            ViewData["Registro"] = false;
        }

        [Authorize]
        public IActionResult Consultar()
        {
            var usuarios = _usuarioBusiness.Filtrar();

            return View(usuarios);
        }

        [Authorize]
        public IActionResult Novo()
        {
            ViewData["Title"] = "Novo Usuário";
            return View("Salvar", new UsuarioDto());            
        }

        [Authorize]
        public IActionResult Editar(int id)
        {
            var usuario = _usuarioBusiness.Selecionar(id);
            ViewData["Title"] = "Editar Usuário";
            return View("Salvar", usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SalvarRegistro(UsuarioDto usuarioDto)
        {
            var resultado = _usuarioBusiness.Salvar(usuarioDto);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Id = resultado.Id,
                Url = ""
            });     
        }

        [HttpPost]
        [Authorize]
        public IActionResult Salvar(UsuarioDto usuarioDto)
        {
            if (ModelState.IsValid)
            {
                var resultado = _usuarioBusiness.Salvar(usuarioDto);
                return Json(new ResultadoViewModel
                {
                    Sucesso = resultado.Sucesso,
                    Id = resultado.Id,
                    Url = Url.Action("Consultar")
                });
            }

            return Json(new ResultadoViewModel
            {
                Sucesso = false,
                Id = -1,
                Url = Url.Action("Salvar")
            });
        }

        [Authorize]
        public IActionResult Excluir(int id)
        {
            var resultado = _usuarioBusiness.Excluir(id);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Url = Url.Action("Consultar")
            });
        }
    }
}