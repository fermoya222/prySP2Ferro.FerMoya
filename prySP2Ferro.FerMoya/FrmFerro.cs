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
            string ComprueboDistancia=txtDistancia.Text.Trim();
            if (ComprueboDistancia.Length > 0)
            {
                int distancia = Convert.ToInt32(txtDistancia.Text);
                if (distancia > 0)
                {

                    if (Convert.ToInt32(nudDias.Value) >= 7 && distancia>=100) 
                    {
                        lblNumPrecio.Text = Convert.ToString(2.50 * distancia);
                        lblTotalNumero.Text = "$ 2,5";
                    }else
                    {
                        lblNumPrecio.Text = Convert.ToString(5 * distancia);
                        lblTotalNumero.Text = "$ 5";
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar distancia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void lblTotalNumero_Click(object sender, EventArgs e)
        {

        }
    }
}
