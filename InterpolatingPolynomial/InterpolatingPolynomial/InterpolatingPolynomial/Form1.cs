using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpolatingPolynomial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int button_counter = 0;
        public double[] arr_X = new double[10];
        public double[] a0 = new double[10];
        public double[] a1 = new double[9];
        public double[] a2 = new double[8];
        public double[] a3 = new double[7];
        public double[] a4 = new double[6];
        public double[] a5 = new double[5];
        public double[] a6 = new double[4];
        public double[] a7 = new double[3];
        public double[] a8 = new double[2];
        public double[] a9 = new double[1];



        private void Form1_Load(object sender, EventArgs e)
        {

            label26.Visible = false; label29.Visible = false; label32.Visible = false; label35.Visible = false; label38.Visible = false;
            label27.Visible = false; label30.Visible = false; label33.Visible = false; label36.Visible = false; label39.Visible = false;
            label28.Visible = false; label31.Visible = false; label34.Visible = false; label37.Visible = false; label40.Visible = false;
            label41.Visible = false; label42.Visible = false; label43.Visible = false; label44.Visible = false; label45.Visible = false;

            label46.Visible = false; label47.Visible = false; label48.Visible = false;
            label49.Visible = false; label50.Visible = false; label51.Visible = false;
            label52.Visible = false; label53.Visible = false; label54.Visible = false;
            label67.Visible = false; label79.Visible = false;
            label55.Visible = false; label68.Visible = false; label80.Visible = false;
            label56.Visible = false; label69.Visible = false; label81.Visible = false;
            label57.Visible = false; label70.Visible = false; label82.Visible = false;
            label58.Visible = false; label71.Visible = false; label83.Visible = false;
            label59.Visible = false; label72.Visible = false; label84.Visible = false;
            label60.Visible = false; label73.Visible = false; label85.Visible = false;
            label61.Visible = false; label74.Visible = false; label86.Visible = false;
            label62.Visible = false; label75.Visible = false; label87.Visible = false;
            label63.Visible = false; label76.Visible = false; label88.Visible = false;
            label64.Visible = false; label77.Visible = false; label89.Visible = false;
            label65.Visible = false; label78.Visible = false; label90.Visible = false;
            label66.Visible = false;


            textBox1.Visible = false; textBox6.Visible = false; textBox11.Visible = false; textBox16.Visible = false;
            textBox2.Visible = false; textBox7.Visible = false; textBox12.Visible = false; textBox17.Visible = false;
            textBox3.Visible = false; textBox8.Visible = false; textBox13.Visible = false; textBox18.Visible = false;
            textBox4.Visible = false; textBox9.Visible = false; textBox14.Visible = false; textBox19.Visible = false;
            textBox5.Visible = false; textBox10.Visible = false; textBox15.Visible = false; textBox20.Visible = false;

            textBox1.Text = "-0"; textBox5.Text = "-0"; textBox9.Text = "-0"; textBox13.Text = "-0"; textBox17.Text = "-0";
            textBox2.Text = "-0"; textBox6.Text = "-0"; textBox10.Text = "-0"; textBox14.Text = "-0"; textBox18.Text = "-0";
            textBox3.Text = "-0"; textBox7.Text = "-0"; textBox11.Text = "-0"; textBox15.Text = "-0"; textBox19.Text = "-0";
            textBox4.Text = "-0"; textBox8.Text = "-0"; textBox12.Text = "-0"; textBox16.Text = "-0"; textBox20.Text = "-0";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_counter++;

            switch (button_counter % 9)
            {
                case 1:
                    {
                        textBox1.Visible = true;
                        textBox2.Visible = true;

                        textBox3.Visible = true;
                        textBox4.Visible = true;

                        textBox5.Visible = true;
                        textBox6.Visible = true;

                        label26.Visible = true; label27.Visible = true; label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true;

                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 2:
                    {
                        textBox7.Visible = true;
                        textBox8.Visible = true;

                        label36.Visible = true; label37.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 3:
                    {
                        textBox9.Visible = true;
                        textBox10.Visible = true;
                        label34.Visible = true; label35.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 4:
                    {
                        textBox11.Visible = true;
                        textBox12.Visible = true;
                        label32.Visible = true; label33.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 5:
                    {
                        textBox13.Visible = true;
                        textBox14.Visible = true;
                        label45.Visible = true; label44.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 6:
                    {
                        textBox15.Visible = true;
                        textBox16.Visible = true;
                        label43.Visible = true; label42.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 7:
                    {

                        textBox17.Visible = true;
                        textBox18.Visible = true;
                        label41.Visible = true; label40.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }
                case 8:
                    {

                        textBox19.Visible = true;
                        textBox20.Visible = true;
                        label39.Visible = true; label38.Visible = true;
                        button1.Text = "Data Length \n" + ((button_counter % 9) + 2);
                        break;
                    }

                case 0:
                    {

                        label26.Visible = false; label29.Visible = false; label32.Visible = false; label35.Visible = false; label38.Visible = false;
                        label27.Visible = false; label30.Visible = false; label33.Visible = false; label36.Visible = false; label39.Visible = false;
                        label28.Visible = false; label31.Visible = false; label34.Visible = false; label37.Visible = false; label40.Visible = false;
                        label41.Visible = false; label42.Visible = false; label43.Visible = false; label44.Visible = false; label45.Visible = false;


                        textBox1.Visible = false; textBox6.Visible = false; textBox11.Visible = false; textBox16.Visible = false;
                        textBox2.Visible = false; textBox7.Visible = false; textBox12.Visible = false; textBox17.Visible = false;
                        textBox3.Visible = false; textBox8.Visible = false; textBox13.Visible = false; textBox18.Visible = false;
                        textBox4.Visible = false; textBox9.Visible = false; textBox14.Visible = false; textBox19.Visible = false;
                        textBox5.Visible = false; textBox10.Visible = false; textBox15.Visible = false; textBox20.Visible = false;
                        button1.Text = "Data Length \n" + (button_counter % 9);
                        // button_counter = 0;
                        break;
                    }

            }


            label92.Text = button_counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xler yazdırılıyor
            label27.Text = textBox1.Text; label33.Text = textBox11.Text;
            label29.Text = textBox3.Text; label45.Text = textBox13.Text;
            label31.Text = textBox5.Text; label43.Text = textBox15.Text;
            label37.Text = textBox7.Text; label41.Text = textBox17.Text;
            label35.Text = textBox9.Text; label39.Text = textBox19.Text;

            //Yler yazıdırlıyodsuıada
            label26.Text = textBox2.Text; label32.Text = textBox12.Text;
            label28.Text = textBox4.Text; label44.Text = textBox14.Text;
            label30.Text = textBox6.Text; label42.Text = textBox16.Text;
            label36.Text = textBox8.Text; label40.Text = textBox18.Text;
            label34.Text = textBox10.Text; label38.Text = textBox20.Text;


            arr_X[0] = Convert.ToDouble(textBox1.Text); arr_X[5] = Convert.ToDouble(textBox11.Text);
            arr_X[1] = Convert.ToDouble(textBox3.Text); arr_X[6] = Convert.ToDouble(textBox13.Text);
            arr_X[2] = Convert.ToDouble(textBox5.Text); arr_X[7] = Convert.ToDouble(textBox15.Text);
            arr_X[3] = Convert.ToDouble(textBox7.Text); arr_X[8] = Convert.ToDouble(textBox17.Text);
            arr_X[4] = Convert.ToDouble(textBox9.Text); arr_X[9] = Convert.ToDouble(textBox19.Text);

            a0[0] = Convert.ToDouble(textBox2.Text); a0[5] = Convert.ToDouble(textBox12.Text);
            a0[1] = Convert.ToDouble(textBox4.Text); a0[6] = Convert.ToDouble(textBox14.Text);
            a0[2] = Convert.ToDouble(textBox6.Text); a0[7] = Convert.ToDouble(textBox16.Text);
            a0[3] = Convert.ToDouble(textBox8.Text); a0[8] = Convert.ToDouble(textBox18.Text);
            a0[4] = Convert.ToDouble(textBox10.Text); a0[9] = Convert.ToDouble(textBox20.Text);

            hesapla(arr_X, a0);
        }

        public void hesapla(double[] x, double[] y)
        {
            double a0;


            a0 = y[0];  // a0 değeri y dizisinin ilk elemanı. en tepedeki yani...

            double[] a1ler = new double[9];
            double[] a2ler = new double[8];
            double[] a3ler = new double[7];
            double[] a4ler = new double[6];
            double[] a5ler = new double[5];
            double[] a6lar = new double[4];
            double[] a7ler = new double[3];
            double[] a8ler = new double[2];
            double[] a9lar = new double[1];


            switch (button_counter % 9)
            {
                case 1:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");

                        label54.Visible = true; label53.Visible = true;



                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        label62.Text = a2ler[0].ToString("N2");
                        label62.Visible = true;

                        break;
                    }
                case 2:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label62.Visible = true; label61.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        label69.Text = a3ler[0].ToString("N2");
                        label69.Visible = true;
                        break;
                    }
                case 3:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label69.Visible = true; label68.Visible = true;

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        label75.Text = a4ler[0].ToString("N2");
                        label75.Visible = true;
                        break;
                    }
                case 4:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        a1ler[4] = (y[5] - y[4]) / (x[5] - x[4]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label50.Text = a1ler[4].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true; label50.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        a2ler[3] = (a1ler[4] - a1ler[3]) / (x[5] - x[3]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label59.Text = a2ler[3].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true; label59.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        a3ler[2] = (a2ler[3] - a2ler[2]) / (x[5] - x[2]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label67.Text = a3ler[2].ToString("N2");
                        label69.Visible = true; label68.Visible = true; label67.Visible = true;

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        a4ler[1] = (a3ler[2] - a3ler[1]) / (x[5] - x[1]);
                        label75.Text = a4ler[0].ToString("N2");
                        label74.Text = a4ler[1].ToString("N2");
                        label75.Visible = true; label74.Visible = true;

                        a5ler[0] = (a4ler[1] - a4ler[0]) / (x[5] - x[0]);
                        label80.Text = a5ler[0].ToString("N2");
                        label80.Visible = true;
                        break;
                    }
                case 5:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        a1ler[4] = (y[5] - y[4]) / (x[5] - x[4]);
                        a1ler[5] = (y[6] - y[5]) / (x[6] - x[5]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label50.Text = a1ler[4].ToString("N2");
                        label49.Text = a1ler[5].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true; label50.Visible = true;
                        label49.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        a2ler[3] = (a1ler[4] - a1ler[3]) / (x[5] - x[3]);
                        a2ler[4] = (a1ler[5] - a1ler[4]) / (x[6] - x[4]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label59.Text = a2ler[3].ToString("N2");
                        label58.Text = a2ler[4].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true; label59.Visible = true;
                        label58.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        a3ler[2] = (a2ler[3] - a2ler[2]) / (x[5] - x[2]);
                        a3ler[3] = (a2ler[4] - a2ler[3]) / (x[6] - x[3]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label67.Text = a3ler[2].ToString("N2");
                        label66.Text = a3ler[3].ToString("N2");
                        label69.Visible = true; label68.Visible = true; label67.Visible = true; label66.Visible = true;

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        a4ler[1] = (a3ler[2] - a3ler[1]) / (x[5] - x[1]);
                        a4ler[2] = (a3ler[3] - a3ler[2]) / (x[6] - x[2]);
                        label75.Text = a4ler[0].ToString("N2");
                        label74.Text = a4ler[1].ToString("N2");
                        label73.Text = a4ler[2].ToString("N2");
                        label75.Visible = true; label74.Visible = true; label73.Visible = true;

                        a5ler[0] = (a4ler[1] - a4ler[0]) / (x[5] - x[0]);
                        a5ler[1] = (a4ler[2] - a4ler[1]) / (x[6] - x[1]);
                        label80.Text = a5ler[0].ToString("N2");
                        label79.Text = a5ler[1].ToString("N2");
                        label80.Visible = true; label79.Visible = true;

                        a6lar[0] = (a5ler[1] - a5ler[0]) / (x[6] - x[0]);
                        label84.Text = a6lar[0].ToString("N2");
                        label84.Visible = true;
                        break;
                    }
                case 6:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        a1ler[4] = (y[5] - y[4]) / (x[5] - x[4]);
                        a1ler[5] = (y[6] - y[5]) / (x[6] - x[5]);
                        a1ler[6] = (y[7] - y[6]) / (x[7] - x[6]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label50.Text = a1ler[4].ToString("N2");
                        label49.Text = a1ler[5].ToString("N2");
                        label48.Text = a1ler[6].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true;
                        label50.Visible = true; label49.Visible = true; label48.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        a2ler[3] = (a1ler[4] - a1ler[3]) / (x[5] - x[3]);
                        a2ler[4] = (a1ler[5] - a1ler[4]) / (x[6] - x[4]);
                        a2ler[5] = (a1ler[6] - a1ler[5]) / (x[7] - x[5]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label59.Text = a2ler[3].ToString("N2");
                        label58.Text = a2ler[4].ToString("N2");
                        label57.Text = a2ler[5].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true; label59.Visible = true;
                        label58.Visible = true; label57.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        a3ler[2] = (a2ler[3] - a2ler[2]) / (x[5] - x[2]);
                        a3ler[3] = (a2ler[4] - a2ler[3]) / (x[6] - x[3]);
                        a3ler[4] = (a2ler[5] - a2ler[4]) / (x[7] - x[4]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label67.Text = a3ler[2].ToString("N2");
                        label66.Text = a3ler[3].ToString("N2");
                        label65.Text = a3ler[4].ToString("N2");
                        label69.Visible = true; label68.Visible = true; label67.Visible = true; label66.Visible = true; label65.Visible = true;

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        a4ler[1] = (a3ler[2] - a3ler[1]) / (x[5] - x[1]);
                        a4ler[2] = (a3ler[3] - a3ler[2]) / (x[6] - x[2]);
                        a4ler[3] = (a3ler[4] - a3ler[3]) / (x[7] - x[3]);
                        label75.Text = a4ler[0].ToString("N2");
                        label74.Text = a4ler[1].ToString("N2");
                        label73.Text = a4ler[2].ToString("N2");
                        label72.Text = a4ler[3].ToString("N2");
                        label75.Visible = true; label74.Visible = true; label73.Visible = true; label72.Visible = true;

                        a5ler[0] = (a4ler[1] - a4ler[0]) / (x[5] - x[0]);
                        a5ler[1] = (a4ler[2] - a4ler[1]) / (x[6] - x[1]);
                        a5ler[2] = (a4ler[3] - a4ler[2]) / (x[7] - x[2]);
                        label80.Text = a5ler[0].ToString("N2");
                        label79.Text = a5ler[1].ToString("N2");
                        label78.Text = a5ler[2].ToString("N2");
                        label80.Visible = true; label79.Visible = true; label78.Visible = true;

                        a6lar[0] = (a5ler[1] - a5ler[0]) / (x[6] - x[0]);
                        a6lar[1] = (a5ler[2] - a5ler[1]) / (x[7] - x[1]);
                        label84.Text = a6lar[0].ToString("N2");
                        label83.Text = a6lar[1].ToString("N2");
                        label84.Visible = true; label83.Visible = true;

                        a7ler[0] = (a6lar[1] - a6lar[0]) / (x[7] - x[0]);
                        label87.Text = a7ler[0].ToString("N2");
                        label87.Visible = true;
                        break;
                    }
                case 7:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        a1ler[4] = (y[5] - y[4]) / (x[5] - x[4]);
                        a1ler[5] = (y[6] - y[5]) / (x[6] - x[5]);
                        a1ler[6] = (y[7] - y[6]) / (x[7] - x[6]);
                        a1ler[7] = (y[8] - y[7]) / (x[8] - x[7]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label50.Text = a1ler[4].ToString("N2");
                        label49.Text = a1ler[5].ToString("N2");
                        label48.Text = a1ler[6].ToString("N2");
                        label47.Text = a1ler[7].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true;
                        label50.Visible = true; label49.Visible = true; label48.Visible = true; label47.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        a2ler[3] = (a1ler[4] - a1ler[3]) / (x[5] - x[3]);
                        a2ler[4] = (a1ler[5] - a1ler[4]) / (x[6] - x[4]);
                        a2ler[5] = (a1ler[6] - a1ler[5]) / (x[7] - x[5]);
                        a2ler[6] = (a1ler[7] - a1ler[6]) / (x[8] - x[6]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label59.Text = a2ler[3].ToString("N2");
                        label58.Text = a2ler[4].ToString("N2");
                        label57.Text = a2ler[5].ToString("N2");
                        label56.Text = a2ler[6].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true; label59.Visible = true;
                        label58.Visible = true; label57.Visible = true; label56.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        a3ler[2] = (a2ler[3] - a2ler[2]) / (x[5] - x[2]);
                        a3ler[3] = (a2ler[4] - a2ler[3]) / (x[6] - x[3]);
                        a3ler[4] = (a2ler[5] - a2ler[4]) / (x[7] - x[4]);
                        a3ler[5] = (a2ler[6] - a2ler[5]) / (x[8] - x[5]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label67.Text = a3ler[2].ToString("N2");
                        label66.Text = a3ler[3].ToString("N2");
                        label65.Text = a3ler[4].ToString("N2");
                        label64.Text = a3ler[5].ToString("N2");
                        label69.Visible = true; label68.Visible = true; label67.Visible = true; label66.Visible = true;
                        label65.Visible = true; label64.Visible = true;
                        //  label63.Text = a3ler[6].ToString("N2");

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        a4ler[1] = (a3ler[2] - a3ler[1]) / (x[5] - x[1]);
                        a4ler[2] = (a3ler[3] - a3ler[2]) / (x[6] - x[2]);
                        a4ler[3] = (a3ler[4] - a3ler[3]) / (x[7] - x[3]);
                        a4ler[4] = (a3ler[5] - a3ler[4]) / (x[8] - x[4]);
                        label75.Text = a4ler[0].ToString("N2");
                        label74.Text = a4ler[1].ToString("N2");
                        label73.Text = a4ler[2].ToString("N2");
                        label72.Text = a4ler[3].ToString("N2");
                        label71.Text = a4ler[4].ToString("N2");
                        label75.Visible = true; label74.Visible = true; label73.Visible = true; label72.Visible = true;
                        label71.Visible = true;
                        // label70.Text = a4ler[5].ToString("N2");

                        a5ler[0] = (a4ler[1] - a4ler[0]) / (x[5] - x[0]);
                        a5ler[1] = (a4ler[2] - a4ler[1]) / (x[6] - x[1]);
                        a5ler[2] = (a4ler[3] - a4ler[2]) / (x[7] - x[2]);
                        a5ler[3] = (a4ler[4] - a4ler[3]) / (x[8] - x[3]);
                        label80.Text = a5ler[0].ToString("N2");
                        label79.Text = a5ler[1].ToString("N2");
                        label78.Text = a5ler[2].ToString("N2");
                        label77.Text = a5ler[3].ToString("N2");
                        label80.Visible = true; label79.Visible = true; label78.Visible = true; label77.Visible = true;
                        //  label76.Text = a5ler[4].ToString("N2");

                        a6lar[0] = (a5ler[1] - a5ler[0]) / (x[6] - x[0]);
                        a6lar[1] = (a5ler[2] - a5ler[1]) / (x[7] - x[1]);
                        a6lar[2] = (a5ler[3] - a5ler[2]) / (x[8] - x[2]);
                        label84.Text = a6lar[0].ToString("N2");
                        label83.Text = a6lar[1].ToString("N2");
                        label82.Text = a6lar[2].ToString("N2");
                        label84.Visible = true; label83.Visible = true; label82.Visible = true;
                        // label81.Text = a6lar[3].ToString("N2");

                        a7ler[0] = (a6lar[1] - a6lar[0]) / (x[7] - x[0]);
                        a7ler[1] = (a6lar[2] - a6lar[1]) / (x[8] - x[1]);
                        label87.Text = a7ler[0].ToString("N2");
                        label86.Text = a7ler[1].ToString("N2");
                        label87.Visible = true; label86.Visible = true;
                        // label85.Text = a7ler[2].ToString("N2");

                        a8ler[0] = (a7ler[1] - a7ler[0]) / (x[8] - x[0]);
                        label89.Text = a8ler[0].ToString("N2");
                        label89.Visible = true;
                        //  label88.Text = a8ler[1].ToString("N2");

                        break;
                    }
                case 8:
                    {
                        a1ler[0] = (y[1] - y[0]) / (x[1] - x[0]);
                        a1ler[1] = (y[2] - y[1]) / (x[2] - x[1]);
                        a1ler[2] = (y[3] - y[2]) / (x[3] - x[2]);
                        a1ler[3] = (y[4] - y[3]) / (x[4] - x[3]);
                        a1ler[4] = (y[5] - y[4]) / (x[5] - x[4]);
                        a1ler[5] = (y[6] - y[5]) / (x[6] - x[5]);
                        a1ler[6] = (y[7] - y[6]) / (x[7] - x[6]);
                        a1ler[7] = (y[8] - y[7]) / (x[8] - x[7]);
                        a1ler[8] = (y[9] - y[8]) / (x[9] - x[8]);
                        label54.Text = a1ler[0].ToString("N2");
                        label53.Text = a1ler[1].ToString("N2");
                        label52.Text = a1ler[2].ToString("N2");
                        label51.Text = a1ler[3].ToString("N2");
                        label50.Text = a1ler[4].ToString("N2");
                        label49.Text = a1ler[5].ToString("N2");
                        label48.Text = a1ler[6].ToString("N2");
                        label47.Text = a1ler[7].ToString("N2");
                        label46.Text = a1ler[8].ToString("N2");
                        label54.Visible = true; label53.Visible = true; label52.Visible = true; label51.Visible = true;
                        label50.Visible = true; label49.Visible = true; label48.Visible = true; label47.Visible = true;
                        label46.Visible = true;

                        a2ler[0] = (a1ler[1] - a1ler[0]) / (x[2] - x[0]);
                        a2ler[1] = (a1ler[2] - a1ler[1]) / (x[3] - x[1]);
                        a2ler[2] = (a1ler[3] - a1ler[2]) / (x[4] - x[2]);
                        a2ler[3] = (a1ler[4] - a1ler[3]) / (x[5] - x[3]);
                        a2ler[4] = (a1ler[5] - a1ler[4]) / (x[6] - x[4]);
                        a2ler[5] = (a1ler[6] - a1ler[5]) / (x[7] - x[5]);
                        a2ler[6] = (a1ler[7] - a1ler[6]) / (x[8] - x[6]);
                        a2ler[7] = (a1ler[8] - a1ler[7]) / (x[9] - x[7]);
                        label62.Text = a2ler[0].ToString("N2");
                        label61.Text = a2ler[1].ToString("N2");
                        label60.Text = a2ler[2].ToString("N2");
                        label59.Text = a2ler[3].ToString("N2");
                        label58.Text = a2ler[4].ToString("N2");
                        label57.Text = a2ler[5].ToString("N2");
                        label56.Text = a2ler[6].ToString("N2");
                        label55.Text = a2ler[7].ToString("N2");
                        label62.Visible = true; label61.Visible = true; label60.Visible = true; label59.Visible = true;
                        label58.Visible = true; label57.Visible = true; label56.Visible = true; label55.Visible = true;

                        a3ler[0] = (a2ler[1] - a2ler[0]) / (x[3] - x[0]);
                        a3ler[1] = (a2ler[2] - a2ler[1]) / (x[4] - x[1]);
                        a3ler[2] = (a2ler[3] - a2ler[2]) / (x[5] - x[2]);
                        a3ler[3] = (a2ler[4] - a2ler[3]) / (x[6] - x[3]);
                        a3ler[4] = (a2ler[5] - a2ler[4]) / (x[7] - x[4]);
                        a3ler[5] = (a2ler[6] - a2ler[5]) / (x[8] - x[5]);
                        a3ler[6] = (a2ler[7] - a2ler[6]) / (x[9] - x[6]);
                        label69.Text = a3ler[0].ToString("N2");
                        label68.Text = a3ler[1].ToString("N2");
                        label67.Text = a3ler[2].ToString("N2");
                        label66.Text = a3ler[3].ToString("N2");
                        label65.Text = a3ler[4].ToString("N2");
                        label64.Text = a3ler[5].ToString("N2");
                        label63.Text = a3ler[6].ToString("N2");
                        label69.Visible = true; label68.Visible = true; label67.Visible = true; label66.Visible = true;
                        label65.Visible = true; label64.Visible = true; label63.Visible = true;

                        a4ler[0] = (a3ler[1] - a3ler[0]) / (x[4] - x[0]);
                        a4ler[1] = (a3ler[2] - a3ler[1]) / (x[5] - x[1]);
                        a4ler[2] = (a3ler[3] - a3ler[2]) / (x[6] - x[2]);
                        a4ler[3] = (a3ler[4] - a3ler[3]) / (x[7] - x[3]);
                        a4ler[4] = (a3ler[5] - a3ler[4]) / (x[8] - x[4]);
                        a4ler[5] = (a3ler[6] - a3ler[5]) / (x[9] - x[5]);
                        label75.Text = a4ler[0].ToString("N2");
                        label74.Text = a4ler[1].ToString("N2");
                        label73.Text = a4ler[2].ToString("N2");
                        label72.Text = a4ler[3].ToString("N2");
                        label71.Text = a4ler[4].ToString("N2");
                        label70.Text = a4ler[5].ToString("N2");
                        label75.Visible = true; label74.Visible = true; label73.Visible = true; label72.Visible = true;
                        label71.Visible = true; label70.Visible = true;

                        a5ler[0] = (a4ler[1] - a4ler[0]) / (x[5] - x[0]);
                        a5ler[1] = (a4ler[2] - a4ler[1]) / (x[6] - x[1]);
                        a5ler[2] = (a4ler[3] - a4ler[2]) / (x[7] - x[2]);
                        a5ler[3] = (a4ler[4] - a4ler[3]) / (x[8] - x[3]);
                        a5ler[4] = (a4ler[5] - a4ler[4]) / (x[9] - x[4]);
                        label80.Text = a5ler[0].ToString("N2");
                        label79.Text = a5ler[1].ToString("N2");
                        label78.Text = a5ler[2].ToString("N2");
                        label77.Text = a5ler[3].ToString("N2");
                        label76.Text = a5ler[4].ToString("N2");
                        label80.Visible = true; label79.Visible = true; label78.Visible = true; label77.Visible = true;
                        label76.Visible = true;

                        a6lar[0] = (a5ler[1] - a5ler[0]) / (x[6] - x[0]);
                        a6lar[1] = (a5ler[2] - a5ler[1]) / (x[7] - x[1]);
                        a6lar[2] = (a5ler[3] - a5ler[2]) / (x[8] - x[2]);
                        a6lar[3] = (a5ler[4] - a5ler[3]) / (x[9] - x[3]);
                        label84.Text = a6lar[0].ToString("N2");
                        label83.Text = a6lar[1].ToString("N2");
                        label82.Text = a6lar[2].ToString("N2");
                        label81.Text = a6lar[3].ToString("N2");
                        label84.Visible = true; label83.Visible = true; label82.Visible = true; label81.Visible = true;


                        a7ler[0] = (a6lar[1] - a6lar[0]) / (x[7] - x[0]);
                        a7ler[1] = (a6lar[2] - a6lar[1]) / (x[8] - x[1]);
                        a7ler[2] = (a6lar[3] - a6lar[2]) / (x[9] - x[2]);
                        label87.Text = a7ler[0].ToString("N2");
                        label86.Text = a7ler[1].ToString("N2");
                        label85.Text = a7ler[2].ToString("N2");
                        label87.Visible = true; label86.Visible = true; label85.Visible = true;

                        a8ler[0] = (a7ler[1] - a7ler[0]) / (x[8] - x[0]);
                        a8ler[1] = (a7ler[2] - a7ler[1]) / (x[9] - x[1]);
                        label89.Text = a8ler[0].ToString("N2");
                        label88.Text = a8ler[1].ToString("N2");
                        label89.Visible = true; label88.Visible = true;

                        a9lar[0] = (a8ler[1] - a8ler[0]) / (x[9] - x[0]);
                        label90.Text = a9lar[0].ToString("N2");
                        label90.Visible = true;
                        break;
                    }

            }

            label13.Text = a0.ToString();
            label14.Text = a1ler[0].ToString("N2");
            label15.Text = a2ler[0].ToString("N2");
            label16.Text = a3ler[0].ToString("N2");
            label17.Text = a4ler[0].ToString("N2");
            label18.Text = a5ler[0].ToString("N2");
            label19.Text = a6lar[0].ToString("N2");
            label20.Text = a7ler[0].ToString("N2");
            label21.Text = a8ler[0].ToString("N2");
            label22.Text = a9lar[0].ToString("N2");

            if (label46.Text == "-0" || label46.Text == "NaN") label46.Visible = false; if (label47.Text == "-0" || label47.Text == "NaN") label47.Visible = false; if (label48.Text == "-0" || label48.Text == "NaN") label48.Visible = false;
            if (label49.Text == "-0" || label49.Text == "NaN") label49.Visible = false; if (label50.Text == "-0" || label50.Text == "NaN") label50.Visible = false; if (label51.Text == "-0" || label51.Text == "NaN") label51.Visible = false;
            if (label52.Text == "-0" || label52.Text == "NaN") label52.Visible = false; if (label53.Text == "-0" || label53.Text == "NaN") label53.Visible = false;
            if (label54.Text == "-0" || label54.Text == "NaN") label54.Visible = false; if (label67.Text == "-0" || label67.Text == "NaN") label67.Visible = false; if (label79.Text == "-0" || label79.Text == "NaN") label79.Visible = false;
            if (label55.Text == "-0" || label55.Text == "NaN") label55.Visible = false; if (label68.Text == "-0" || label68.Text == "NaN") label68.Visible = false; if (label80.Text == "-0" || label80.Text == "NaN") label80.Visible = false;
            if (label56.Text == "-0" || label56.Text == "NaN") label56.Visible = false; if (label69.Text == "-0" || label69.Text == "NaN") label69.Visible = false; if (label81.Text == "-0" || label81.Text == "NaN") label81.Visible = false;
            if (label57.Text == "-0" || label57.Text == "NaN") label57.Visible = false; if (label70.Text == "-0" || label70.Text == "NaN") label70.Visible = false; if (label82.Text == "-0" || label82.Text == "NaN") label82.Visible = false;
            if (label58.Text == "-0" || label58.Text == "NaN") label58.Visible = false; if (label71.Text == "-0" || label71.Text == "NaN") label71.Visible = false; if (label83.Text == "-0" || label83.Text == "NaN") label83.Visible = false;
            if (label59.Text == "-0" || label59.Text == "NaN") label59.Visible = false; if (label72.Text == "-0" || label72.Text == "NaN") label72.Visible = false; if (label84.Text == "-0" || label84.Text == "NaN") label84.Visible = false;
            if (label60.Text == "-0" || label60.Text == "NaN") label60.Visible = false; if (label73.Text == "-0" || label73.Text == "NaN") label73.Visible = false; if (label85.Text == "-0" || label85.Text == "NaN") label85.Visible = false;
            if (label61.Text == "-0" || label61.Text == "NaN") label61.Visible = false; if (label74.Text == "-0" || label74.Text == "NaN") label74.Visible = false; if (label86.Text == "-0" || label86.Text == "NaN") label86.Visible = false;
            if (label62.Text == "-0" || label62.Text == "NaN") label62.Visible = false; if (label75.Text == "-0" || label75.Text == "NaN") label75.Visible = false; if (label87.Text == "-0" || label87.Text == "NaN") label87.Visible = false;
            if (label63.Text == "-0" || label63.Text == "NaN") label63.Visible = false; if (label76.Text == "-0" || label76.Text == "NaN") label76.Visible = false; if (label88.Text == "-0" || label88.Text == "NaN") label88.Visible = false;
            if (label64.Text == "-0" || label64.Text == "NaN") label64.Visible = false; if (label77.Text == "-0" || label77.Text == "NaN") label77.Visible = false; if (label89.Text == "-0" || label89.Text == "NaN") label89.Visible = false;
            if (label65.Text == "-0" || label65.Text == "NaN") label65.Visible = false; if (label78.Text == "-0" || label78.Text == "NaN") label78.Visible = false; if (label90.Text == "-0" || label90.Text == "NaN") label90.Visible = false;
            if (label66.Text == "-0" || label66.Text == "NaN") label66.Visible = false;








        }




    }
}
