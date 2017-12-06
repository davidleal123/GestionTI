using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreria1;



namespace Metodos
{
    public class Metodos
    {
        public static void ValidaNumero(KeyPressEventArgs e, TextBox texto, ErrorProvider error)
        {
            error.SetError(texto, string.Empty);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                error.SetError(texto, "Ingrese Solo Números");
                return;
            }
        }
        public static void ValidaDouble(KeyPressEventArgs e, TextBox texto, ErrorProvider error)
        {
            error.SetError(texto, string.Empty);
            if (texto.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    error.SetError(texto, "Ya ingreso un Punto Decimal");
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    error.SetError(texto, "Ingrese Solo Números");
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
        static int punta = 1;
        public static void ValidaTexto(KeyPressEventArgs e, TextBox texto, ErrorProvider error)
        {
            error.SetError(texto, string.Empty);
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                if (char.IsSeparator(e.KeyChar))
                {
                    if (punta == 0)
                    {
                        e.Handled = true;
                        error.SetError(texto, "Solo se Permiten un Espacio entre palabras");
                        return;
                    }
                    e.Handled = false;
                    punta = 0;
                    return;
                }
                e.Handled = true;
                error.SetError(texto, "Solo se Permiten Letras");
                return;
            }
            punta = 1;
        }
        public static bool ValidaLongitudClave(string clave, int Longitud)
        {
            bool band = false;
            if (clave.Length > Longitud)
                band = true;
            return band;
        }
        public static bool Existe(string consulta)
        {
            bool band = false;
            string strCon = "Data Source=.\\SQLEXPRESSL;Initial Catalog=ClinicaMedica;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return true;
            }
            SqlDataReader lector = null;
            string strComandoSQL = consulta;
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Validación");
                conn.Close();
                return true;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    band = true;
                }
            }
            conn.Close();
            return band;
        }
        static int punta2 = 0;
        private void ValidaEspacios(KeyPressEventArgs e, TextBox texto, ErrorProvider error)
        {
            error.SetError(texto, string.Empty);
            if (char.IsSeparator(e.KeyChar))
            {
                if (punta2 == 0)
                {
                    e.Handled = true;
                    error.SetError(texto, "Solo se Permiten un Espacio entre palabras");
                    return;
                }
                e.Handled = false;
                punta2 = 0;
                return;
            }
            punta2 = 1;
        }
    }
}
