using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Controllers
{
    public class ProdutosController : Controller
    {
        //TODO: Alteração do Layout
        //TODO: Melhora as opções de select usando filtros
        //TODO: Adicionar paginação e filtros
        //TODO: Adicionar Imagem do produto
        //TODO: Adicionar Componente de data
        //TODO: Adicionar texto
        //TODO: Melhorar o roteamento das páginas
        //TODO: Tratamento de erros

        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            return View (_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosComAvaliacao()));
        }


        public async Task<IActionResult> Details(int id)
        {

            var produtoViewModel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoEspecifico(id));
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);

            var dados = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Adicionar(dados);

            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var produtoViewModel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoEspecifico(id));
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdutoViewModel produtoViewModel)
        {

            if (id != produtoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(produtoViewModel);

            var dados = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Atualizar(dados);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var produtoViewModel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoEspecifico(id));
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoViewModel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoEspecifico(id));
            if (produtoViewModel == null) return NotFound();
            await _produtoRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
