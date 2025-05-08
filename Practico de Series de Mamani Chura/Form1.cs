using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_de_Series_de_Mamani_Chura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Tabla de Suma del practico 1//
        public string tSuma(int sm, int n)
        {
            int i;
            double t;
            string s;
            s = "";
            for (i = 4; i <= n; i++)
            {
                t = i + sm;
                s = s + sm + "+" + i + "=" + t + "\x000d" + "\x000a";
            }
            return s;
        }

        // tabla de la Resta del practico 1
        public string Tresta(int re, int n)
        {
            int i;
            double t;
            string s;
            s = "";
            for (i = 4; i <= n; i++)
            {
                t = i - re;
                s = s + i + "-" + re + "=" + t + "\x000d" + "\x000a";
            }
            return s;
        }
        // Tabla de multicacion del practico 1
        public string TMulti(int mul, int n)
        {
            int i;
            double t;
            string s;
            s = "";
            for (i = 4; i <= n; i++)
            {
                t = i * mul;
                s = s + mul + "*" + i + "=" + t + "\x000d" + "\x000a";
            }
            return s;
        }
        // Tabla de divicion del practico 1
        public string Tdivisor(int div, int n)
        {
            int i;
            double t;
            string s;
            s = "";
            for (i = 12; i >= n; i--)
            {
                t = i / div;
                s = s + i + "/" + div + "=" + t + "\x000d" + "\x000a";
            }
            return s;
        }
        // Ejercicio 5 del practico 1 
        public string Serie5(double vi, double r, int n)
        {
            int i;
            double t;
            string s;
            s = "";
            for (i = 1; i <= n; i++)
            {
                t = vi + (i - 1) * r;
                s = s + t + "\x0009";
            }
            return s;
        }
        // Ejercicio 6 del practico 1 
        public string Serie6(double vi, int n)
        {
            int i;
            string s;
            s = "";
            for (i = 1 - 1; 1 <= n; i++)
            {
                vi = vi + i;
                s = s + vi + ",\t";
            }
            return s;
        }
        // Ejercicio 7 del practico 1
        public string Serie7(int n)
        {
            double a, b, c;
            int i;
            string s;
            a = -1; b = 1; s = "";
            for (i = 1; i <= n; i++)
            {
                c = a + b;
                s = s + c + "\x0009";
                a = b; b = c;
            }
            return s;
        }
        // Ejercicio 8 del practico 1
        public string Serie8(int n)
        {
            int c = 0;
            int na = n + 1;
            bool b1 = true;
            string acum = "";
            for (int i = 1; 1 <= n; i++)
            {
                if (b1 == true)
                {
                    na = na - 1;
                    acum = acum + na + " , ";
                }
                else
                {
                    c = c + 1;
                    acum = acum + c + " , ";
                }
                b1 = !b1;
            }
            return acum;
        }
        // Ejercicio 9 del practico 1
        public string Serie9(int n)
        {
            string acum = "";
            string serie = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                acum = acum + i + " , ";
                serie = serie + acum;
            }
            return serie;
        }
        // Ejercicio 10 del practico 1
        public string Serie10(int n)
        {
            string acum = "";
            string serie = "";
            int i;
            for (i = 1; i >= n; i--)
            {
                acum = acum + i + " , ";
                serie = serie + acum;
            }
            return serie;
        }
        //PRACTICO 2 DE SERIES 
        // ejercicio 1 
        public string Ejerci1(int n)
        {
            double a, b, c;
            int i, x;
            string f;
            f = ""; a = 1; b = 1; x = 1;
            for (i = 1; i <= n; i++)
            {
                c = a + b;
                f = f + x + "/" + c + "!" + " + ";
                a = b; b = c;
            }
            return f;
        }
        //Ejercicio 2 
        public string Ejerci2(double vi, int n)
        {
            double a, b, c;
            int i;
            string f, t;
            f = ""; a = -1; b = 1; t = "";
            for (i = 1; i <= n; i++)
            {
                vi = vi - b;
                c = a + b;
                vi = vi + c;
                t = t + vi + "+";
                f = "F=" + t;
                a = b; b = c;
            }
            return f;
        }
        // ejercicio 3
        public string Ejerci3(double vi, double r, double vim, double m, int n)
        {
            int i;
            double t, am, a;
            string f;
            f = "F="; am = vim / m;
            for (i = 1; i <= n; i++)
            {
                am = am * m; a = vi + (i - 1) * r;
                t = Math.Pow(am / a, 1 / a);
                f = f + t;
            }
            return f;
        }
        // Ejercicio 4
        public string Ejerci4(double vim, double m, int vi, int r, double vi1,double r1, int n)
        {
            int i;
            double a, b, am;
            string t, f;am = vim / m;f = "F=";t = "";
            for (i = 1; i <= n; i++)
            {
                am = am * m;a = vi + (i - 1) * r;b = vi1 + (i - 1) * r1;
                t = t + "ln(" + am +")+" + a + "/" + b + "+";
             

            }
            f = t;
            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "F= " + Ejerci4(10, 10, 2, 2, 1.7, 0.2, 5);
        }
        // Ejercicio 5
        //Avance Ejercicio05
    }
}
