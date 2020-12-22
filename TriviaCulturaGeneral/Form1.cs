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

namespace TriviaCulturaGeneral
{
    public partial class Form1 : Form
    {
        private string respuesta = null;
        private int numPreg = 1;

        public Form1()
        {
            InitializeComponent();
        }

      

       
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSiguiente.Visible = false;
            chkListPreguntas.Visible = false;
            pctPreguntas.Visible = false;
        }

        private void CargarPregunta()
        {
            StreamReader Lectura;
            string Cadena;
            string[] preguntas;
            char[] separador = { ';' };

            try
            {
                Lectura = File.OpenText("C:\\Users\\Adrian y Natalia\\source\\repos\\TriviaCulturaGeneral\\TriviaCulturaGeneral\\txt\\Preguntas.txt");

                if (numPreg == 1)
                {
                    Cadena = Lectura.ReadLine();
                    preguntas = Cadena.Split(separador);
                    pctPreguntas.Image = Image.FromFile(preguntas[0]);
                    lblPregunta.Text = preguntas[1];
                    chkListPreguntas.Items.Add(preguntas[2], false);
                    chkListPreguntas.Items.Add(preguntas[3], false);
                    chkListPreguntas.Items.Add(preguntas[4], false);
                    chkListPreguntas.Items.Add(preguntas[5], false);
                    respuesta = preguntas[6];
                }
                else if (numPreg == 2)
                {
                    Lectura.ReadLine();
                    Cadena = Lectura.ReadLine();
                    preguntas = Cadena.Split(separador);
                    pctPreguntas.Image = Image.FromFile(preguntas[0]);
                    lblPregunta.Text = preguntas[1];
                    chkListPreguntas.Items.Add(preguntas[2], false);
                    chkListPreguntas.Items.Add(preguntas[3], false);
                    chkListPreguntas.Items.Add(preguntas[4], false);
                    chkListPreguntas.Items.Add(preguntas[5], false);
                    respuesta = preguntas[6];
                }
                else if (numPreg == 3)
                {
                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Cadena = Lectura.ReadLine();
                    preguntas = Cadena.Split(separador);
                    pctPreguntas.Image = Image.FromFile(preguntas[0]);
                    lblPregunta.Text = preguntas[1];
                    chkListPreguntas.Items.Add(preguntas[2], false);
                    chkListPreguntas.Items.Add(preguntas[3], false);
                    chkListPreguntas.Items.Add(preguntas[4], false);
                    chkListPreguntas.Items.Add(preguntas[5], false);
                    respuesta = preguntas[6];
                }
                else if (numPreg == 4)
                {

                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Cadena = Lectura.ReadLine();
                    preguntas = Cadena.Split(separador);
                    pctPreguntas.Image = Image.FromFile(preguntas[0]);
                    lblPregunta.Text = preguntas[1];
                    chkListPreguntas.Items.Add(preguntas[2], false);
                    chkListPreguntas.Items.Add(preguntas[3], false);
                    chkListPreguntas.Items.Add(preguntas[4], false);
                    chkListPreguntas.Items.Add(preguntas[5], false);
                    respuesta = preguntas[6];
                }
                else if (numPreg == 5)
                {
                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Lectura.ReadLine();
                    Cadena = Lectura.ReadLine();
                    preguntas = Cadena.Split(separador);
                    pctPreguntas.Image = Image.FromFile(preguntas[0]);
                    lblPregunta.Text = preguntas[1];
                    chkListPreguntas.Items.Add(preguntas[2], false);
                    chkListPreguntas.Items.Add(preguntas[3], false);
                    chkListPreguntas.Items.Add(preguntas[4], false);
                    chkListPreguntas.Items.Add(preguntas[5], false);
                    respuesta = preguntas[6];
                }
                else
                {
                    MessageBox.Show("Gracias por Participar en nuestra Trivia", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                
              
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            btnSiguiente.Visible = true;
            label2.Visible = true;
            chkListPreguntas.Visible = true;
            pctPreguntas.Visible = true;

            CargarPregunta();
 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (chkListPreguntas.SelectedItem.ToString() == respuesta)
            {
                MessageBox.Show("Respuesta Correcta", "Felicitaciones", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            chkListPreguntas.Items.Clear();
            numPreg = numPreg + 1;
            CargarPregunta();
            
        }
    }
}
