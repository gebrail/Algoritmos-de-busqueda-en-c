using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Algoritmos
{

    public partial class Form1 : Form
    {

        public static String tiempo="";
        public static String tiempob = "";
        public static String tiempoc = "";

        public static int longitud;
        public static int[] vector;


        public static int xd;
        public static int[] vectorA;
        public static int[] vectorB;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ordenados = "";

            int[] iArray = new int[] { 22, 15, 3, 16, 30, 45, 9, 27, 7, 12, 44, 85, 24, 47, 33, 67, 55, 1, 93, 16 };

            MessageBox.Show("Ordenando Array ....");

            Operaciones.ShellSorter sh = new Operaciones.ShellSorter();

            sh.Sort(iArray);

            for (int i = 0; i <19; i++)
            {

                ordenados = ordenados + " "+ iArray[i];
                    
            }

            txt_ordenado.Text = ordenados;

            txt_tiempo.Text = tiempo;

        }

        private void txt_tiempo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            longitud = int.Parse(txt_longitud.Text);

            vector = new int[longitud];

            btn_agregar_elemento.Enabled = true;

            btn_crear_vector.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < longitud; i++)
            {

                String tx_valor = Interaction.InputBox(null, "Ingrese el valor para la posición: "+i);

                vector[i] = int.Parse(tx_valor);
            }


            String elementos = "";

            for (int i = 0; i < longitud; i++)
            {
                elementos += " " + vector[i];
            }

            elementos_agregados.Text = elementos;


            btn_agregar_elemento.Enabled = false;

            btn_ordenar.Enabled = true;

        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            Operaciones.Quiqsort quiq = new Operaciones.Quiqsort();

            quiq.quicksortxd(vector,0,longitud-1);

            String elementos_ordenados = "";

            for (int i = 0; i < longitud; i++)
            {
                elementos_ordenados +=" "+vector[i];
            }

            txt_vector.Text = elementos_ordenados;

            txt_time_2.Text = tiempob;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            xd = int.Parse(tx_tam.Text);

            vectorA = new int[xd];

            vectorB = new int[xd];

            for (int i = 0; i < xd; i++)
            {
                String tx_valorx = Interaction.InputBox(null, "Ingrese el valor para la posición: " + i);

                vectorA[i] = int.Parse(tx_valorx);
            }


            String elementos = "";

            for (int i = 0; i < xd; i++)
            {
                elementos += " " + vectorA[i];
            }

            elementos_normales.Text = elementos;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Operaciones.Mergesort merg = new Operaciones.Mergesort();

            merg.merge_sort(0,xd-1,vectorA,vectorB);

            String elementos = "";

            for (int i = 0; i < xd; i++)
            {
                elementos += " " + vectorA[i];
            }

            elementos_ordenados.Text = elementos;
            txt_time_3.Text = tiempoc;
        }
    }
}
