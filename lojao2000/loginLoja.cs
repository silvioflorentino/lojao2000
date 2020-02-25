using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lojao2000
{
    public partial class loginLoja : Form
    {
        public loginLoja()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //this.Close(); // fecha janela
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            //string usuario = textBoxUsuario.Text;
            //string senha = textBoxSenha.Text;

            //if(usuario=="1" && senha == "1")
            //{
            //    menuLoja menuLoja = new menuLoja();
            //    this.Visible = false;
            //    menuLoja.ShowDialog(); // alguém deve fecha-lo -- Show o sistema fecha.

            //}
            //else // mbox aperta o tab
            //{
            //    MessageBox.Show("Usuario não cadastrado", "Lojão 2000");

            //}

            dados.Usuario = textBoxUsuario.Text;

            var cn = new SqlConnection(conexao.conector());
            var cmd = new SqlCommand("plogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@login", textBoxUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);
            cmd.Parameters.AddWithValue("@perfil", textBoxPerfil.Text);

            cn.Open();
            int i = (int)cmd.ExecuteScalar();
            if (i > 0)
            {
                // abrir tela

                menuLoja menuLoja = new menuLoja();
                 this.Visible = false;
                  menuLoja.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario não cadastrado");
            }

            cn.Close();


        }
    }
}
