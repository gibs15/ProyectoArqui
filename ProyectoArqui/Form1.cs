using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                catch (Exception) {
                    MessageBox.Show("El valor ingresado no fue un numero entero.");
                    txtQuantum.Text = String.Empty;
                }
            }
            else {
                MessageBox.Show("Debe ingresar un valor para el Quantum.");
            }
        }

       /* private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(openFileDialog1.InitialDirectory + openFileDialog1.FileName);

            
        }*/

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            openFileDialog1.ShowDialog();
          

            try
            {
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                int cont = 1;
                foreach (String file in openFileDialog1.FileNames)
                {
                    txtArchivo.AppendText("Archivo " + cont +"\n");
                    string[] lines = System.IO.File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        txtArchivo.AppendText(line+"\n");
                    }
                   
                    cont++;




                }
                //    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                //{
                //    // Read the first line from the file and write it the textbox.
                //    txtArchivo.Text = reader.ReadLine();
                //}
                fileStream.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
