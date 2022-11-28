using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab_katia2
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();

            TelaFornecedor telaFornecedor = new TelaFornecedor();
            telaFornecedor.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();

            TelaProduto telaProduto = new TelaProduto();
            telaProduto.Show();
        }
    }
}
