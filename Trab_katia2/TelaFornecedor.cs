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
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }
        string fornecedor;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }

        private void TelaFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
