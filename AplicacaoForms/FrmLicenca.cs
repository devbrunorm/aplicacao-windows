using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoForms
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

        private void btnObterLicenca_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.torneseumprogramador.com.br");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa registrado com sucesso!");
        }
    }
}
