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

        //este es un push de prueba hecho por jose valverde

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
            List<List<String>> listaHilillos = new List<List<String>>();

            /*char[] delimiters = new char[] { '\r', '\n' };
            string[] parts = value.Split(delimiters,
                             StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(":::SPLIT, CHAR ARRAY:::");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }*/

            try
            {
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                int cont = 1;
                foreach (String file in openFileDialog1.FileNames)
                {
                    //para enviarlo al controlador de hilillos.
                    List<string> lista = new List<string>();
                    string lineasTodoElArchivo = String.Empty;

                    //para mostrar en pantalla.
                    txtArchivo.AppendText("Archivo " + cont +"\n");
                    string[] lines = System.IO.File.ReadAllLines(file);
                    string[] parts; 
                    foreach (string line in lines)
                    {
                        char[] delimiters = new char[] {' '};
                        parts = line.Split(delimiters,
                                         StringSplitOptions.RemoveEmptyEntries);

                    
                    for (int i = 0; i <= parts.Count()-1; i++) { 
                        //txtArchivo.AppendText(parts[i]+"\n");
                        lista.Add(parts[i]);
                        }
                  

                        txtArchivo.AppendText(line+"\n");
                        //lineasTodoElArchivo = lineasTodoElArchivo + "" + line;
                    }
                    listaHilillos.Add(lista);
                    cont++;

                }
                fileStream.Close();

                int cont2 = 1;
                foreach (List<string> listaDatosArchivos in listaHilillos){
                    txtVerLista.AppendText("Archivo "+ cont2+"\n");
                    for (int i =0; i <= listaDatosArchivos.Count()-1; i++){
                        txtVerLista.AppendText(listaDatosArchivos[i]+" ");
                     

                    }
                    txtVerLista.AppendText("\n");
                    cont2++;
                }
                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                txtArchivo.AppendText(Ex.ToString());

            }
        }
    }
}
