using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_katia2
{
    internal class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public DateTime validade { get; set; }
        public double preco { get; set; }
        public int qtd { get; set; }

        public Produto (int codigo, string descricao, DateTime validade, double preco, int qtd)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.validade = validade;
            this.preco = preco;
            this.qtd = qtd;

        }
    }
}
