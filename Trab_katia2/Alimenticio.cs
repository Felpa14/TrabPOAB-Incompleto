using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_katia2
{
    internal class Alimenticio: Produto
    {

        public string Medida { get; set; }
        public string Tipo { get; set; }

        public Alimenticio(int codigo, string descricao, DateTime validade, double preco, int qtd, string medida, string tipo) : base(codigo, descricao, validade, preco, qtd)
        {
            this.Medida = medida;
            this.Tipo = tipo;
        }


    }
}
