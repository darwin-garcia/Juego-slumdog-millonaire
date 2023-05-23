using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMillonario
{
    public partial class Ronda6 : Form
    {
        public Ronda6()
        {
            InitializeComponent();
        }
        int Respuesta = 0;
        public void Correcto()
        {
            if (Respuesta == 2)
            {
                MessageBox.Show("respuesta correcta");
                Ronda7 r = new Ronda7();
                r.Show();
                this.Hide();//ocultar pntalla y llevarme  a otra
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. fin del juego");
                Form1 regresar = new Form1();//me lleva a la 1 ventana
                regresar.Show();//devuelva pantalla principl
                this.Hide(); //ocultar ronda 1
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Respuesta = 1;
            }
            if (checkBox2.Checked == true)
            {
                Respuesta = 2;
            }
            if (checkBox3.Checked == true)
            {
                Respuesta = 3;
            }
            if (checkBox4.Checked == true)
            {
                Respuesta = 4;
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                Respuesta = 0;
                MessageBox.Show("Selecciona solo una opcion");
            }
            else
            {
                if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    Respuesta = 0;
                    MessageBox.Show("Selecciona solo una opcion");
                }
                else
                {
                    if (checkBox3.Checked == true && checkBox4.Checked == true)
                    {
                        Respuesta = 0;
                        MessageBox.Show("Selecciona solo una opcion");
                    }
                }
            }
            Correcto();
        }
    }
}
