using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ValidacionXMLyXSD.UTILITARIOS
{
    public class UtlVarios
    {
        //Valida que no se pueda hacer nada sobre una caja de texto o contro que ingrese texto
        public static void txtValidaNingunIngreso(KeyPressEventArgs caracter)
        {
            try
            {
                if (char.IsLetter(caracter.KeyChar))
                {
                    caracter.Handled = true;
                }
                else if (char.IsNumber(caracter.KeyChar))
                {
                    caracter.Handled = true;
                }
                else if (char.IsControl(caracter.KeyChar))
                {
                    caracter.Handled = true;
                }
                else if (char.IsSeparator(caracter.KeyChar))
                {
                    caracter.Handled = true;
                }
                else
                {
                    caracter.Handled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se permite Escritura", e.Message); 
            }
        }
    }
}
