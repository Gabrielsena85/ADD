using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADD
{
    public partial class FormCompra : Form
    {
        public string Produto { get { return this.comboBoxNomedoProduto.Text; } }
        public string Fornecedor { get { return this.comboBoxFonecedorP.Text; } }
        public decimal quantidade { get { return this.numericUpDownQuantidadeP.Value; } }
        public decimal desconto { get { return this.numericUpDownDescontoP.Value; } }
        public string precoUT { get { return this.textBoxPrecoU.Text; } }
        public string PrecoT { get { return this.textBoxValorT.Text; } }
        public string TotalCD { get { return this.textBoxTotalD.Text; } }

        public FormCompra()
        {
            InitializeComponent();
        }

        private void button0OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button0Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
