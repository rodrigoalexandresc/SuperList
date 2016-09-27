using SuperList.Domain;
using SuperList.Domain.Commands;
using SuperList.Domain.DTO;
using SuperList.Domain.Repositories;
using SuperList.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SuperList.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ListaDeCompraController : ApiController
    {
        readonly IListaDeCompraService listaDeCompraService;

        public ListaDeCompraController(IListaDeCompraService listaDeCompraService)
        {
            this.listaDeCompraService = listaDeCompraService;
        }

        [HttpPost]
        public void CriarLista(CriarListaDeCompraCommand command)
        {
            listaDeCompraService.CriarListaDeCompra(command);
        }

        [HttpPost]
        public void CriarItemLista(IncluirItemListaDeCompraCommand command)
        {
            listaDeCompraService.IncluirItem(command);
        }

        //[HttpGet]
        //public ListaDeCompraDoUsuarioDTO ObterListaPadrao()
        //{

        //}

        [HttpGet]
        public ListaDeCompraDoUsuarioDTO ObterListaPadraoFake()
        {
            var lista = new ListaDeCompraDoUsuarioDTO();

            lista.Secoes = new List<SecaoDTO>();
            lista.Secoes.Add(new SecaoDTO
            {
                Descricao = "Açougue",
                Itens = new List<ItemDaListaDeCompraDTO>
                {
                    new ItemDaListaDeCompraDTO { Descricao = "Acém", Quantidade = 3m },
                    new ItemDaListaDeCompraDTO { Descricao = "Filé frango", Quantidade = 1m },
                    new ItemDaListaDeCompraDTO { Descricao = "Contrafilé", Quantidade = 1m }
                }
            });
            lista.Secoes.Add(new SecaoDTO
            {
                Descricao = "Hortifruti",
                Itens = new List<ItemDaListaDeCompraDTO>
                {
                    new ItemDaListaDeCompraDTO { Descricao = "Pera", Quantidade = 1m },
                    new ItemDaListaDeCompraDTO { Descricao = "Uva", Quantidade = 1m },
                }
            });
            lista.Secoes.Add(new SecaoDTO
            {
                Descricao = "Higiene pessoal"
            });

            return lista;
        }
    }
}
