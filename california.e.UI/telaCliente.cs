using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using california.e.BO;

namespace california.e.UI
{
    public partial class telaCliente : Form
    {
        public telaCliente()
        {
            InitializeComponent();
        }

        private void CadCli_Click(object sender, EventArgs e)
        {
            if(nometxt.Text == "" || cpftxt.Text == "" || telefonetxt.Text == "" || endtxt.Text == "" )
            {
                MessageBox.Show("Acesso Negado");
            }
            else
            {
                MessageBox.Show("Acesso Liberado");
                telaMenu telaMenu = new telaMenu();
                telaMenu.Show();
                this.Hide();
            }
        }

        private void telaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
