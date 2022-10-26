using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP2Ferro.FerMoya
{
    public partial class FrmFerroCalculo : Form
    {
        public FrmFerroCalculo()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            {
             
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
                // si NO es un dígito y NO es Backspace (para borrar)
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true; // borrar la tecla ingresada
                }
        }
    }
}
