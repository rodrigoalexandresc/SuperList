using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Domain.Commands
{
    public class CriarListaDeCompraCommand
    {
        public Guid UsuarioId { get; set; }
    }

    public class IncluirItemListaDeCompraCommand
    {
        public Guid ListaDeCompraId { get; set; }

        public Guid ProdutoId { get; set; }

        public decimal Quantidade { get; set; }
    }
}
