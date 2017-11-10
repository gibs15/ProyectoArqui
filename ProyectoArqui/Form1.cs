using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArqui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text != "")
            {
                try
                {
                    int ValorQuantum = Convert.ToInt32(txtQuantum.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show("El valor ingresado no fue un numero entero.");
                    txtQuantum.Text = String.Empty;
                }
            }
            else {
                MessageBox.Show("Debe ingresar un valor para el Quantum.");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(openFileDialog1.InitialDirectory + openFileDialog1.FileName);

            try
            {
                using (StreamReader reader = File.OpenText(directoryPath))
                {
                    string s = "";
                    while ((s = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
