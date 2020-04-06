using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class FrmEstudoSwitch : Form
    {
        public FrmEstudoSwitch()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32( txbVerificar.Text);
            switch (valor)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Numero Medio");
                    break;
                default:
                    MessageBox.Show("Numero Alto");
                    break;
            }
        }
    }
}
