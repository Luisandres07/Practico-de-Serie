﻿using System;
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
        int NumeroEjercicio = 0;
        int NumeroPractico = 0;
        public Form1()
        {
            InitializeComponent();
            limpiar();
            dato1.Visible = false;Resultado.Visible = false;
           dato2.Visible = false; dato3.Visible = false; dato4.Visible = false; dato5.Visible = false; dato6.Visible = false; dato7.Visible = false;
            lbtitulo.Text = "";
            lbcampo01.Visible = false;lbcampo02.Visible = false;lbcampo03.Visible = false;
            lbcampo04.Visible = false;lbcampo05.Visible = false;lbcampo06.Visible = false;lbcampo07.Visible = false;button2.Visible = false;button3.Visible = false;

        }
        void limpiar()
        {
            dato1.Text = "0"; dato2.Text = "0"; dato3.Text = "0";
            dato4.Text = "0"; dato5.Text = "0"; dato6.Text = "0"; dato7.Text = "0";
            Resultado.Text = "";
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
            string s = "";
            for (i =1; i <= n; i++)
            {
                s = s + (div * i).ToString() + "/" + div.ToString() + "=" + ((div * i) / div).ToString() + "\r\n";
            }
            return s;
        }
        // Ejercicio 5 del practico 1 
        public string Serie5(int vi,int r,int n)
        {
            int i, aux;
            string s;
            s = "";
            for (i = 1; i <= n; i++)
                for (aux = 1; aux <= 2; aux++)
                {
                    s = s + (vi + (i - i) * r).ToString() + "";
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
        // Ejercicio 5 
        public string Ejerci5(int num, int den,int n)
        {
            int paso = 1;
            int contador = 0;
            String s = "F=";
            while(contador<n&&num >= 1)
            {
                s = s + $"√({num}/{ den})";
                contador++;
                paso++;
                num -= paso;
                den += paso;
                if (contador < n && num >= 1)
                {
                    s += " + ";
                }
            }
            return s;
        }
        // Ejercicio 6
        public double Factorial(int n)
        {
            double fac;
            int i;
            if (n != 0)
            {
                fac = 1;
                for (i = Math.Abs(n); i >= 1; i--)
                {
                    fac = fac * i;
                    if (n < 0)
                        fac = -fac;
                }
            }
            else
            {
                fac = 1;
            }
            return fac;
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Text = "Suma:";lbcampo01.Visible = true;lbcampo02.Visible = true;lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 01";
            NumeroEjercicio = 1;
            NumeroPractico = 1;
            dato1.Visible = true;dato2.Visible = true;Resultado.Visible = true;button2.Visible = true;button3.Visible = true;
            Resultado.Text = tSuma(int.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Text = "Resta:"; lbcampo01.Visible = true; lbcampo02.Visible = true; lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 02";
            NumeroEjercicio = 2;
            NumeroPractico = 1;
            dato1.Visible = true; dato2.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Tresta(int.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Text = "Multiplicar:"; lbcampo01.Visible = true; lbcampo02.Visible = true; lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 03";
            NumeroEjercicio = 3;
            NumeroPractico = 1;
            dato1.Visible = true; dato2.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = TMulti(int.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Text = "Divisor:"; lbcampo01.Visible = true; lbcampo02.Visible = true; lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 04";
            NumeroEjercicio = 4;
            NumeroPractico = 1;
            dato1.Visible = true; dato2.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Tdivisor(int.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true;lbcampo02.Visible = true;lbcampo03.Visible = true;
            lbcampo01.Text = "Vi:";lbcampo02.Text = "r:";lbcampo03.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 05";
            NumeroEjercicio = 5;
            NumeroPractico = 1;
            dato1.Visible = true; dato2.Visible = true;dato3.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie5(int.Parse(dato1.Text), int.Parse(dato2.Text), int.Parse(dato3.Text));
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo02.Visible = true;
            lbcampo01.Text = "Vi:";lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 06";
            NumeroEjercicio = 6;
            NumeroPractico = 1;
            dato1.Visible = true; dato2.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie6(double.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true;lbcampo01.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 07";
            NumeroEjercicio = 7;
            NumeroPractico = 1;
            dato1.Visible = true;Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie7(int.Parse(dato1.Text));
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo01.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 08";
            NumeroEjercicio = 8;
            NumeroPractico = 1;
            dato1.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie8(int.Parse(dato1.Text));
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo01.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 09";
            NumeroEjercicio = 9;
            NumeroPractico = 1;
            dato1.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie9(int.Parse(dato1.Text));
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo01.Text = "n terminos:";
            lbtitulo.Text = "Practico #01 Ejercicio 10";
            NumeroEjercicio = 10;
            NumeroPractico = 1;
            dato1.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Serie10(int.Parse(dato1.Text));
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo01.Text = "n terminos:";
            lbtitulo.Text = "Practico #02 Ejercicio 01";
            NumeroEjercicio = 1;
            NumeroPractico = 2;
            dato1.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Ejerci1(int.Parse(dato1.Text));
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo02.Visible = true;
            lbcampo01.Text = "Vi:"; lbcampo02.Text = "n terminos:";
            lbtitulo.Text = "Practico #02 Ejercicio 02";
            NumeroEjercicio = 2;
            NumeroPractico = 2;
            dato1.Visible = true; dato2.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Ejerci2(double.Parse(dato1.Text), int.Parse(dato2.Text));
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true;lbcampo02.Visible = true;lbcampo03.Visible = true;lbcampo04.Visible = true;lbcampo05.Visible = true;
            lbcampo01.Text = "Valor inicial:";lbcampo02.Text = "r:";lbcampo03.Text = "Vi multi:";lbcampo04.Text = "multi:";lbcampo05.Text = "n terminos:";
            lbtitulo.Text = "Practico #02 Ejercicio 03";
            NumeroEjercicio = 3;
            NumeroPractico = 2;
            dato1.Visible = true;dato2.Visible = true;dato3.Visible = true;dato4.Visible = true;dato5.Visible = true;Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Ejerci3(double.Parse(dato1.Text), double.Parse(dato2.Text), double.Parse(dato3.Text), double.Parse(dato4.Text), int.Parse(dato5.Text));
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true; lbcampo02.Visible = true; lbcampo03.Visible = true; lbcampo04.Visible = true; lbcampo05.Visible = true;lbcampo06.Visible = true;lbcampo07.Visible = true;
            lbcampo01.Text = "Vi multi:";lbcampo02.Text = "multi:";lbcampo03.Text = "Numerador:";lbcampo04.Text = "r numerdador:";lbcampo05.Text = "Denominador:";lbcampo06.Text = "r denominador:";lbcampo07.Text = "n terminos:";
            lbtitulo.Text = "Practico #02 Ejercicio 04";
            NumeroEjercicio = 04;
            NumeroPractico = 2;
            dato1.Visible = true;dato2.Visible = true;dato3.Visible = true;dato4.Visible = true;dato5.Visible = true;dato6.Visible = true;dato7.Visible = true;Resultado.Visible = true;
            button2.Visible = true; button3.Visible = true;
            Resultado.Text = Ejerci4(double.Parse(dato1.Text), double.Parse(dato2.Text), int.Parse(dato3.Text), int.Parse(dato4.Text), double.Parse(dato5.Text), double.Parse(dato6.Text), int.Parse(dato7.Text));
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbcampo01.Visible = true;lbcampo02.Visible = true;lbcampo03.Visible = true;
            lbcampo01.Text = "Numerador:";lbcampo02.Text = "Denominador:";lbcampo03.Text = "n terminos:";
            lbtitulo.Text = "Practico #02 Ejercicio 05";
            NumeroEjercicio = 05;
            NumeroPractico = 2;
            dato1.Visible = true; dato2.Visible = true; dato3.Visible = true; Resultado.Visible = true; button2.Visible = true; button3.Visible = true;
            Resultado.Text = Ejerci5(int.Parse(dato1.Text), int.Parse(dato2.Text), int.Parse(dato3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (NumeroPractico == 1){
              

                switch (NumeroEjercicio)
                {
                    case 1:
                        Resultado.Text = tSuma(int.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 2:
                        Resultado.Text = Tresta(int.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 3:
                        Resultado.Text = TMulti(int.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 4:
                        Resultado.Text = Tdivisor(int.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 5:
                        Resultado.Text = Serie5(int.Parse(dato1.Text), int.Parse(dato2.Text), int.Parse(dato3.Text));
                        break;

                    case 6:
                        Resultado.Text = Serie6(double.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 7:
                        Resultado.Text = Serie7(int.Parse(dato1.Text));
                        break;

                    case 8:
                        Resultado.Text = Serie8(int.Parse(dato1.Text));
                        break;

                    case 9:
                        Resultado.Text = Serie9(int.Parse(dato1.Text));
                        break;

                    case 10:
                        Resultado.Text = Serie10(int.Parse(dato1.Text));
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            }
            if (NumeroPractico == 2)
            {


                switch (NumeroEjercicio)
                {
                    case 1:
                        Resultado.Text = Ejerci1(int.Parse(dato1.Text));
                        break;

                    case 2:
                        Resultado.Text = Ejerci2(double.Parse(dato1.Text), int.Parse(dato2.Text));
                        break;

                    case 3:
                        Resultado.Text = Ejerci3(double.Parse(dato1.Text), double.Parse(dato2.Text), double.Parse(dato3.Text), double.Parse(dato4.Text), int.Parse(dato5.Text));
                        break;

                    case 4:
                        Resultado.Text = Ejerci4(double.Parse(dato1.Text), double.Parse(dato2.Text), int.Parse(dato3.Text), int.Parse(dato4.Text), double.Parse(dato5.Text), double.Parse(dato6.Text), int.Parse(dato7.Text));
                        break;

                    case 5:
                        Resultado.Text = Ejerci5(int.Parse(dato1.Text), int.Parse(dato2.Text), int.Parse(dato3.Text));
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            }


        }

        private void pRACTICO2SeriresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dato1.Visible = false; Resultado.Visible = false;
            dato2.Visible = false; dato3.Visible = false; dato4.Visible = false; dato5.Visible = false; dato6.Visible = false; dato7.Visible = false;
            lbtitulo.Text = "Practico #02 de Series";
            lbcampo01.Visible = false; lbcampo02.Visible = false; lbcampo03.Visible = false;
            lbcampo04.Visible = false; lbcampo05.Visible = false; lbcampo06.Visible = false; lbcampo07.Visible = false; button2.Visible = false; button3.Visible = false;
        }

        private void pRACTICO1SeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dato1.Visible = false; Resultado.Visible = false;
            dato2.Visible = false; dato3.Visible = false; dato4.Visible = false; dato5.Visible = false; dato6.Visible = false; dato7.Visible = false;
            lbtitulo.Text = "Practico #01 de Series";
            lbcampo01.Visible = false; lbcampo02.Visible = false; lbcampo03.Visible = false;
            lbcampo04.Visible = false; lbcampo05.Visible = false; lbcampo06.Visible = false; lbcampo07.Visible = false; button2.Visible = false; button3.Visible = false;
        }

        private void lbcampo06_Click(object sender, EventArgs e)
        {
            //000
        }
    }
}
