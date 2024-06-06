using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace california.e.UI
{
    public partial class telaFuncionario : Form
    {
        public telaFuncionario()
        {
            InitializeComponent();
        }

        private void CadFun_Click(object sender, EventArgs e)
        {

        }

        private void lnkVoltarCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkVoltarFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }
    }
}
