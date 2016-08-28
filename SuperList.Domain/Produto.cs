using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Domain
{
    class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Secao Secao { get; set; }

        public decimal PrecoMedio { get; set; }

        public UnidadeDeMedida UnidadeDeMedida { get; set; }

        public Produto(int id, string descricao, Secao secao, decimal preco, UnidadeDeMedida unidade) 
        {
            Id = id;
            Descricao = descricao;
            Secao = secao;
            PrecoMedio = preco;
            UnidadeDeMedida = unidade;
        }
    }
}
