using System;
using System.Collections.Generic;

namespace SuperList.Domain.DTO
{
    public class ListaDeCompraDoUsuarioDTO
    {
        public Guid Id { get; set; }

        public DateTime? DataCriacao { get; set; }

        public IList<SecaoDTO> Secoes { get; set; }
    }

    public class SecaoDTO
    {
        public string Descricao { get; set; }

        public IList<ItemDaListaDeCompraDTO> Itens { get; set; }

    }

    public class ItemDaListaDeCompraDTO
    {
        public string Descricao { get; set; }

        public decimal Quantidade { get; set; }
    }
}
