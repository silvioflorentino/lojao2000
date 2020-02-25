using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojao2000
{
    public partial class menuLoja : Form
    {
        public menuLoja()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuarioLoja cadUsuarioLoja = new cadUsuarioLoja();
            cadUsuarioLoja.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLoja_Load(object sender, EventArgs e)
        {
            
            toolStripUsuario.Text = dados.Usuario;
            

        }
    }
}
