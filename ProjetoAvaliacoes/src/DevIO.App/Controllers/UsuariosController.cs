using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevIO.App.Data;
using DevIO.App.ViewModels;
using AutoMapper;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;

namespace DevIO.App.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodosUsuario()));
        }


        public async Task<IActionResult> Details(int id)
        {
            var usuarioViewModel = _mapper.Map<UsuarioViewModel>(await _usuarioRepository.ObterUsuarioEspecifico(id));
            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid) return View(usuarioViewModel);

            var dados = _mapper.Map<Usuario>(usuarioViewModel);
            await _usuarioRepository.Adicionar(dados);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var usuarioViewModel = _mapper.Map<UsuarioViewModel>(await _usuarioRepository.ObterUsuarioEspecifico(id));
            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,UsuarioViewModel usuarioViewModel)
        {
            if (id != usuarioViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(usuarioViewModel);

            var dados = _mapper.Map<Usuario>(usuarioViewModel);
            await _usuarioRepository.Atualizar(dados);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var usuarioViewModel = _mapper.Map<UsuarioViewModel>(await _usuarioRepository.ObterUsuarioEspecifico(id));
            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioViewModel = _mapper.Map<UsuarioViewModel>(await _usuarioRepository.ObterUsuarioEspecifico(id));
            if (usuarioViewModel == null) return NotFound();
            await _usuarioRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
