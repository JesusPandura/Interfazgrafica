using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uno = textBox1.Text;
            string dos = textBox2.Text;
            string tres = textBox3.Text;
            
            MessageBox.Show("Datos guardados");
            MessageBox.Show("Nombre: " + uno +". " + "Numero: "+ dos + ". "+ "Direccion:"+" "+ tres+ ". ");
            if (radioButton1.Checked)
            {
                MessageBox.Show("Procesador: AMD Ryzen 5 3400G ");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Procesador: AMD Ryzen 5 2600 ");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Procesador: AMD Ryzen 7 3700X  ");
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Intel Core i9-9900K ");
            }

            if (checkBox1.Checked)
            {
                MessageBox.Show(" Memoria ram de 2g ");
            }

            if (checkBox2.Checked)
            {
                MessageBox.Show(" Memoria ram de 4g ");
            }


            if (checkBox3.Checked)
            {
                MessageBox.Show(" Memoria ram de 8g ");
            }

            if (checkBox4.Checked)
            {
                MessageBox.Show(" Memoria ram de 16g ");
            }
            string yog = comboBox1.Text;

            MessageBox.Show(" Sistema operativo: "+ yog);

            if (checkBox5.Checked)
            {
                MessageBox.Show(" Disco duro SSD ");
            }

            if (checkBox6.Checked)
            {
                MessageBox.Show(" Disco duro HDD ");
            }
            
            if (checkBox7.Checked)
            {
                MessageBox.Show("Dispositivos adicionales: Monitor");
            }
            if (checkBox8.Checked)
            {
                MessageBox.Show("Dispositivos adicionales: Mouse gamer ");
            }
            if (checkBox9.Checked)
            {
                MessageBox.Show("Dispositivos adicionales: Audifonos");
            }
            if (checkBox10.Checked)
            {
                MessageBox.Show("Dispositivos adicionales: Targeta Grafica");
            }
        }
    }
}
