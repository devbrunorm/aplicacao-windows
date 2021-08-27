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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try 
            {
                int numero = int.Parse(txtNumero.Text);
                numero += 100;

                if (numero > 1000)
                {
                    throw new ErroDeProposito("Erro de propósito");
                }

                MessageBox.Show("Olá " + nome + ", o valor do número mais 100 é de: " + numero);
            } 
            catch (FormatException errFormat)
            {
                MessageBox.Show("Formato inválido, tente novamente");
                txtNumero.Focus();
            }
            catch (ErroDeProposito err)
            {
                MessageBox.Show("Erro proposital");
            }
            finally
            {
                MessageBox.Show("Essas foram as exceções tratadas");
            }
        }
    }

    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro) : base(erro)
        {
        }
    }
}
