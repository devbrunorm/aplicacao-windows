using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoForms
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Inicializando o Formulário");
        }
    }
}
