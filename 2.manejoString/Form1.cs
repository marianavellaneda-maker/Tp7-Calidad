using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace _2.manejoString
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede quedar vacío o eliminarse si no lo usás
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este evento también puede dejarse vacío si no hace falta reaccionar al cambio de texto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                string vsaludo = $"¡Hola {nombre}!";
                label1.Text = vsaludo;
                Console.WriteLine(vsaludo); // Solo visible si configurás la consola
            }
            else
            {
                label1.Text = "Por favor, ingresa tu nombre.";
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox2.Text;
            string cadena = textBox3.Text;
            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrEmpty(cadena))
            {
                label4.Text = "Ambos campos deben estr completos.";
                return;
            }
            int posicion = texto.IndexOf(cadena);
            if (posicion >= 0)
            {
                label4.Text = $"Cadena encontrada en la posicion {posicion}.\n" + $"Longitud del texto: {texto.Length} caracteres.";
                Console.WriteLine("Cadena encontrada.");
            }
            else
            {
                label4.Text = "la cadena no fue encontrada en el texto.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = textBox4.Text;
            string caracterIngresado = textBox5.Text;

            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrEmpty(caracterIngresado))
            {
                label7.Text = "Ambos campos deben estar completos.";
                return;
            }
            if (caracterIngresado.Length != 1)
            {
                label7.Text = "Debe ingresar solo un caracter.";
                return;
            }
            char caracter = caracterIngresado[0];
            int contador = texto.Count(c => c == caracter);

            label7.Text = $"el caracter `{caracter}` aparece {contador} veces.";
            Console.WriteLine($"`{caracter}` aparece {contador} veces.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string textoOriginal = textBox6.Text;

            if
        (string.IsNullOrEmpty(textoOriginal))
            {
                label9.Text = "ingrese un texto.";
                return;
            }

            string textoSinEspacios = textoOriginal.Trim();

            label9.Text = $"Resultado:`{textoSinEspacios}`";
            Console.WriteLine($"Texto original: `{textBox6}`");
            Console.WriteLine($"texto sin espacios: `{textoSinEspacios}`");
        }

        private void btnEliminar5_Click(object sender, EventArgs e)
        {
            string texto = txtTexto5.Text;
            string caracteresAEliminar = textEliminar.Text;

            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(caracteresAEliminar))
            {


                lblResultado5.Text = "Ambos campos deben estar completos.";
                return;
            }

            // Eliminamos todos los caracteres contenidos en caracteresAEliminar
            foreach (char c in caracteresAEliminar)
            {
                texto = texto.Replace(c.ToString(), "");
            }

            lblResultado5.Text = $"Resultado: '{texto}'";
            Console.WriteLine($"Texto resultante: '{texto}'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string texto = textBox7.Text;
            string caracterX = textBox8.Text;
            string caracterY = textBox9.Text;

            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrEmpty(caracterX) ||
                string.IsNullOrEmpty(caracterY))
            {
                label15.Text = "Todos los campos deben estar completos.";
                return;
            }

            if (caracterX.Length != 1 || caracterY.Length != 1)
            {
                label15.Text = "Debe ingresar solo un carácter en cada campo.";
                return;
            }

            string textoReemplazado = texto.Replace(caracterX, caracterY);

            label15.Text = $"Resultado: '{textoReemplazado}'";
            Console.WriteLine($"Texto reemplazado: '{textoReemplazado}'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string texto = textBox10.Text;

            if (string.IsNullOrEmpty(texto))
            {
                ; label17.Text = "Ingrese un texto.";
                return;

            }

            int cantidadDigitos = texto.Count(c => char.IsDigit(c));
            label17.Text = $"cantidad de caracteres numericos: {cantidadDigitos}";
            Console.WriteLine($"Numeros encontrados: {cantidadDigitos}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string texto = textBox11.Text;
            if (string.IsNullOrEmpty(texto))
            {
                label19.Text = "Ingrese un texto.";
                return;
            }
            string invertido = new string(texto.Select(c => char.IsLetter(c) ?
                (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

            label19.Text = $"Resultado:`{invertido}`)";
            Console.WriteLine($"Texto invertido:`{invertido}`");
        }

        private void btnMayus9_Click(object sender, EventArgs e)
        {

            {
                string texto = txtTexto9.Text;

                if (string.IsNullOrEmpty(texto))
                {
                    lblResultado9.Text = "Ingrese un texto.";
                    return;
                }

                string mayusculas = texto.ToUpper();
                lblResultado9.Text = $"En mayúsculas: '{mayusculas}'";
                Console.WriteLine($"Mayúsculas: '{mayusculas}'");
            }

        }

        private void btnMinus9_Click(object sender, EventArgs e)
        {

            {
                string texto = txtTexto9.Text;

                if (string.IsNullOrEmpty(texto))
                {
                    lblResultado9.Text = "Ingrese un texto.";
                    return;
                }

                string minusculas = texto.ToLower();
                lblResultado9.Text = $"En minúsculas: '{minusculas}'";
                Console.WriteLine($"Minúsculas: '{minusculas}'");
            }

        }
    }
}













