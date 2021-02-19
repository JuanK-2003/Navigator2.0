using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VentanaGoogle.Navigate("https://www.google.com/");
          //  leer_datos_busqueda();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            VentanaGoogle.GoBack();
        }

        private void botonAdelante_Click(object sender, EventArgs e)
        {
            VentanaGoogle.GoForward();
        }

        void guardar_busqueda (string fileName, string texto)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }

       void leer_datos_busqueda ()
        {
            FileStream stream = new FileStream("Busquedas.txt", FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(stream);
            while (lector.Peek() > -1)
           
            {
                comboBox1.Items.Add(lector.ReadLine());
            }
          lector.Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        { 
                Regex isSearch = new Regex("^¿?([\\wáéíóú]+\\s?)+\\??$");
                if (isSearch.IsMatch(comboBox1.Text))
                {
                    VentanaGoogle.Navigate($" http://www.google.com/search?q={comboBox1.Text}");
                guardar_busqueda("Busquedas.txt", comboBox1.Text);
                }
                else
                {
                    comboBox1.Text = normalizarURL.NormalizeUrl(comboBox1.Text);
                    VentanaGoogle.Navigate(comboBox1.Text);
                guardar_busqueda("Busquedas.txt", comboBox1.Text);
            }
            leer_datos_busqueda();
        }
    }
}
