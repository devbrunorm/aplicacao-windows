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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //MessageBox.Show("Inicializando o Formulário pelo Construtor");
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Danilo. Este é o seu primeiro programa! " +  cboEstados.Text;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void atualizaHora()
        {
            lblHoraAtual.Text = "Dia e Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir Cadastro", abrirCadastro_Click));
            notifyIcon1.ContextMenu = contextMenu;
            
            atualizaHora();

            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            //Maneira Simples de Utilizar
            //dataGridView.DataSource = Estado.Lista();
            //cboEstados.Items.Clear();
            //foreach (Estado estado in Estado.Lista())
            //{
            //    cboEstados.Items.Add(estado);
            //}

            // Maneira complexa
            //dataGridView.ColumnCount = 2;
            //dataGridView.Columns[0].Name = "Id";
            //dataGridView.Columns[1].Name = "Nome";
            //var rows = new List<string[]>();
            //foreach (Estado estado in Estado.Lista())
            //{
            //    string[] row1 = new string[] { estado.id.ToString(), estado.Nome };
            //    rows.Add(row1);
            //}
            //foreach (string[] rowArray in rows)
            //{
            //    dataGridView.Rows.Add(rowArray);
            //}

            // Utilizando o Link - Maneira Intermediária
            var data = from estado in Estado.Lista()
                       //where estado.id == 1 || estado.id == 2
                       orderby estado.Nome
                       select new
                       {
                           id = estado.id,
                           Nome = estado.Nome
                       };
            dataGridView.DataSource = data.ToList();
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no ícone");
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei 2x no ícone");
        }
    }

}
