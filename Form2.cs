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
    public partial class formproduto : Form
    {
        public string strConn;
        public MySqlConnection conn;

        public formproduto(string nome, string nivel)
        {
            InitializeComponent();

            strConn = ("DATABASE=banco2ds;Data Source=localhost; user Id=root; password=''; Port=3308");

            if(nivel == "adm")
            {
                MessageBox.Show("Bem vindo Administrador, você pode adicionar e deletar produtos do banco de dados!");
            }
            else
            {
                btn_add.Visible = false;
                btn_alt.Visible = false;
                btn_del.Visible = false;
                txt_cod.Enabled = false;
                txt_prod.Enabled = false;
                txt_desc.Enabled = false;
                nmc_quant.Enabled = false;
                txt_preco.Enabled = false;

            }

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

        public void Limpar_campos()
        {
            txt_cod.Text = "";
            txt_desc.Text = "";
            txt_preco.Text = "";
            txt_prod.Text = "";
            nmc_quant.Value = 0;
        }

        private void formproduto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txt_cod.Text == "")
            {
                MessageBox.Show("Você precisa Ter um produto Selecionado!");
            }
            else
            {
                conn = Conectar_banco();

                string delete = "delete from tbproduto where idprod = '"+txt_cod.Text+"'";
                MySqlCommand comd = new MySqlCommand(delete, conn);
                MySqlDataReader resul = comd.ExecuteReader();
                Limpar_campos();
                MessageBox.Show("Produto deletado com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "")
            {
                MessageBox.Show("Você precisa Ter um produto Selecionado!");
            }
            else
            {
                conn = Conectar_banco();

                string alterar = "update tbproduto set produto = '"+txt_prod.Text+ "', descr = '" + txt_desc.Text + "', quant = '" + nmc_quant.Value + "', preco = '" + txt_preco.Text + "' where idprod = '" + txt_cod.Text + "'";
                MySqlCommand comd = new MySqlCommand(alterar, conn);
                MySqlDataReader resul = comd.ExecuteReader();
                Limpar_campos();
                MessageBox.Show("Produto alterado com sucesso!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = Conectar_banco();

            string sql = "insert into tbproduto(produto,descr,quant,preco) values ('"+txt_prod.Text+ "','" + txt_desc.Text + "','" + nmc_quant.Value + "','" + txt_preco.Text + "')";
            MySqlCommand comd = new MySqlCommand(sql, conn);
            comd.ExecuteNonQuery();
            comd.Connection.Close();
            MessageBox.Show("cadastro realizado com sucesso!");
            Limpar_campos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {

            if (txt_busca.Text == "")
            {
                MessageBox.Show("Você Precisa digitar algum valor!");
            }
            else
            {
                conn = Conectar_banco();

                string sqlbusca = "select * from tbproduto where idprod ='" + txt_busca.Text + "'";

                MySqlCommand comd = new MySqlCommand(sqlbusca, conn);
                MySqlDataReader resul = comd.ExecuteReader();

                if (resul.HasRows)
                {
                    MessageBox.Show("Busca efetuada!");

                    while (resul.Read())
                    {
                        txt_cod.Text = Convert.ToString(resul["idprod"]);
                        txt_prod.Text = Convert.ToString(resul["produto"]);
                        txt_desc.Text = Convert.ToString(resul["descr"]);
                        nmc_quant.Value = Convert.ToInt16(resul["quant"]);
                        txt_preco.Text = Convert.ToString(resul["preco"]);

                    }

                }
                else
                {
                    Limpar_campos();
                    MessageBox.Show("Nenhum Resultado Encontrado!");
                }
            }
        }
    }
}
