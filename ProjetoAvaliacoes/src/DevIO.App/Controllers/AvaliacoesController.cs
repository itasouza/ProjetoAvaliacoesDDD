using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevIO.App.Data;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using AutoMapper;
using DevIO.Business.Models;

namespace DevIO.App.Controllers
{
    public class AvaliacoesController : Controller
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IProdutoRepository _produtoRepository;

        private readonly IMapper _mapper;

        public AvaliacoesController(IAvaliacaoRepository avaliacaoRepository,
                                    IProdutoRepository produtoRepository,
                                    IUsuarioRepository usuarioRepository,
                                    IMapper mapper)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _usuarioRepository = usuarioRepository;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }



        public async Task<IActionResult> Index()
        {
            var dados = _mapper.Map<IEnumerable<AvaliacaoViewModel>>(await _avaliacaoRepository.ObterAvaliacoesProdutoUsuario());
            return View(dados);
        }


        public async Task<IActionResult> Details(int id)
        {
            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterAvaliacoesProdutoUsuarioEspecifico(id));
            if (avaliacaoViewModel == null)
            {
                return NotFound();
            }

            return View(avaliacaoViewModel);
        }

        // GET: Avaliacoes/Create
        public async Task<IActionResult> Create()
        {

            ViewData["ProdutoId"] = new SelectList(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()), "Id", "NomeProduto");
            ViewData["UsuarioId"] = new SelectList(_mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodosUsuario()), "Id", "NomeUsuario");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( AvaliacaoViewModel avaliacaoViewModel)
        {
            if (!ModelState.IsValid) return View(avaliacaoViewModel);

            var dados = _mapper.Map<Avaliacao>(avaliacaoViewModel);
            await _avaliacaoRepository.Adicionar(dados);

            ViewData["ProdutoId"] = new SelectList(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()), "Id", "NomeProduto");
            ViewData["UsuarioId"] = new SelectList(_mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodosUsuario()), "Id", "NomeUsuario");

            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Edit(int id)
        {
            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterAvaliacoesProdutoUsuarioEspecifico(id));
            if (avaliacaoViewModel == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()), "Id", "NomeProduto");
            ViewData["UsuarioId"] = new SelectList(_mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodosUsuario()), "Id", "NomeUsuario");

            return View(avaliacaoViewModel);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AvaliacaoViewModel avaliacaoViewModel)
        {
            if (id != avaliacaoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(avaliacaoViewModel);

            var dados = _mapper.Map<Avaliacao>(avaliacaoViewModel);
            await _avaliacaoRepository.Atualizar(dados);

            ViewData["ProdutoId"] = new SelectList(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()), "Id", "NomeProduto");
            ViewData["UsuarioId"] = new SelectList(_mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodosUsuario()), "Id", "NomeUsuario");


            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Delete(int id)
        {
            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterAvaliacoesProdutoUsuarioEspecifico(id));
            if (avaliacaoViewModel == null)
            {
                return NotFound();
            }

            return View(avaliacaoViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterAvaliacoesProdutoUsuarioEspecifico(id));
            if (avaliacaoViewModel == null) return NotFound();
            await _avaliacaoRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

 
    }
}
