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
            string procesador = "";
           
            if (radioButton1.Checked)
            {
                procesador =("Procesador: AMD Ryzen 5 3400G ");
            }
            else if(radioButton2.Checked)
            {
                procesador = ("Procesador: AMD Ryzen 5 2600 ");
            }
             else if(radioButton3.Checked)
            {
                procesador = ("Procesador: AMD Ryzen 7 3700X  ");
            }
            else if (radioButton4.Checked)
            {
               procesador = ("Intel Core i9-9900K ");
            }

            String chek = "";
            String chek1 = "";
            String chek2 = "";
            String chek3 = "";





            if (checkBox1.Checked)
            {
                chek = ("  2g ");
            }

            if (checkBox2.Checked)
            {
                chek1 = ("  4g ");
            }


            if (checkBox3.Checked)
            {
                chek2 = ("  8g ");
            }

            if (checkBox4.Checked)
            {
                 chek3 =  ("  16g ");
            }
           
            
           
            

            string yog = comboBox1.Text;
            string sistema = "";
            sistema = ("Sistema operativo: "+ yog);
            string chek4 = "";
           string chek5 = "";
            string chek6 = "";
           string chek7 = "";
            string chek8 = "";
            string chek9 = "";

            if (checkBox5.Checked)
            {
                chek4 = ("Disco duro SSD ");
            }

            if (checkBox6.Checked)
            {
                chek5 = ("Disco duro HDD ");
            }
            
            if (checkBox7.Checked)
            {
                chek6 = ("Monitor ");
            }
            if (checkBox8.Checked)
            {
                chek7 = ("Mouse gamer ");
            }
            if (checkBox9.Checked)
            {
                chek8 = ("Audifonos ");
            }
            if (checkBox10.Checked)
            {
                chek9 = ("Targeta Grafica ");
            }

            MessageBox.Show("Nombre del cliente: " + uno + " su numero de telefono es " + dos + " Dirrecion: " + tres + "\n" + "Datos de compra: " + procesador + "\n" + "Memoria ram: " + chek+chek1+chek2+ chek3 + "\n" +
                sistema + "\n" + chek4+ chek5 + "\n" + "Dispositivos adicionales: " +chek6+chek7+chek8+chek9);







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
