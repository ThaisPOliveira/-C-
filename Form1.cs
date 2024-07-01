using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_csharp
{
    public partial class Form1 : Form
    {
        public string strConn;
        public MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            strConn = ("DATABASE=banco2ds;Data Source=localhost; user Id=root; password=''; Port=3308");
        }

        public MySqlConnection Conectar_banco()
        {
            MySqlConnection conexao1 = new MySqlConnection(strConn);
            try
            {
                conexao1.Open();
                return conexao1;
            }

            catch
            {
                MessageBox.Show("Impossível estabalecer!");
                Application.ExitThread();
            }
            return conexao1;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_senha.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            conn = Conectar_banco();
            string sql = "select * from tbusuario where (login='" + txt_login.Text + "' and senha ='" + txt_senha.Text + "')";
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader resul = comd.ExecuteReader();

            if (resul.HasRows)
            {
                MessageBox.Show("Você está liberado para entrar no sistema de controle!");

                 while (resul.Read())
                {
                    var_guardanome.Text = Convert.ToString(resul["nome"]);
                    var_guardanivel.Text = Convert.ToString(resul["nivel"]);
                 }

                form_principal novaform = new form_principal(var_guardanome.Text,var_guardanivel.Text);
                novaform.Show();

                

            }
            else
            {
                
                MessageBox.Show("Login ou senha errada. Liberação Bloqueada!");
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ckb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_senha.PasswordChar == '*')
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }
    }
}
