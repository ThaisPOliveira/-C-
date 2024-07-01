using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_csharp
{
    public partial class form_principal : Form
    {
        public form_principal(String nome, String nivel)
        {
            InitializeComponent();
            lbl_nome.Text = "Bem vindo " + nome + "!";
            lbl_nivel.Text = "Você possui o nivel de acesso: " + nivel;
            guardanivel.Text = nivel;


        }

        private void form_principal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formproduto telaprod = new formproduto(lbl_nome.Text, guardanivel.Text);
            telaprod.Show();
        }
    }
}
