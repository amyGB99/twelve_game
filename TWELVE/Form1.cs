using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twelve_original;

namespace TWELVE
{

    public partial class Form1 : Form
    {
        static int cantidadcolumnas = 5;
        static int cantidadfilas = 5;
        Class1 Tablero;
        int filainicial = -1;
        int filafinal = -1;
        int columnainicial = -1;
        int columnafinal = -1;
        int click = 1;
        bool Modo;

        public Form1()
        {
            InitializeComponent();
            Tablero = new Class1(cantidadfilas, cantidadcolumnas);
            pbxtablero.Refresh();
        }

        private void pbxtablero_Paint(object sender, PaintEventArgs e)
        {
            Color colores = Color.Black;
            SolidBrush brochita = new SolidBrush(Color.Black);
            Graphics pintar = e.Graphics;
            Pen pincel = new Pen(Color.Black, 4);
            float anchocasilla = (float)pbxtablero.Width / cantidadcolumnas;
            float largocasilla = (float)pbxtablero.Height / cantidadfilas;
            for (int s = 0; s < cantidadcolumnas; s++)
            {
                for (int v = 0; v < cantidadfilas; v++)
                {
                    if (Tablero.tablero[v, s] != 0)
                    {
                        if (Tablero.tablero[v, s] == 1)
                            colores = Color.Aqua;
                        if (Tablero.tablero[v, s] == 2)
                            colores = Color.Red;
                        if (Tablero.tablero[v, s] == 3)
                            colores = Color.Gray;
                        if (Tablero.tablero[v, s] == 4)
                            colores = Color.Orange;
                        if (Tablero.tablero[v, s] == 5)
                            colores = Color.Chocolate;
                        if (Tablero.tablero[v, s] == 6)
                            colores = Color.Violet;
                        if (Tablero.tablero[v, s] == 7)
                            colores = Color.Brown;
                        if (Tablero.tablero[v, s] == 8)
                            colores = Color.Maroon;
                        if (Tablero.tablero[v, s] == 9)
                            colores = Color.Magenta;
                        if (Tablero.tablero[v, s] == 10)
                            colores = Color.Yellow;
                        if (Tablero.tablero[v, s] == 11)
                            colores = Color.White;
                        if (Tablero.tablero[v, s] == 12)
                            colores = Color.Pink;
                       SolidBrush rectangulo = new SolidBrush(colores);
                         pintar.FillRectangle(rectangulo, anchocasilla * s, largocasilla * v, anchocasilla, largocasilla);
                      
                    }
                }
            }

            for (int i = 0; i < cantidadcolumnas + 1; i++)
            {
                pintar.DrawLine(pincel, i * anchocasilla, 0, i * anchocasilla, pbxtablero.Height);
            }
            for (int j = 0; j < largocasilla + 1; j++)
            {
                pintar.DrawLine(pincel, 0, j * largocasilla, pbxtablero.Width, j * largocasilla);
            }
            for (int s = 0; s < cantidadcolumnas; s++)
                for (int m = 0; m < cantidadfilas; m++)
                {
                    if (Tablero.tablero[m, s] != 0)
                    {
                        int width = pbxtablero.Width / Tablero.tablero.GetLength(1);
                        int altura = pbxtablero.Height / Tablero.tablero.GetLength(0);
                        SizeF dimen = new SizeF(Width, altura);
                        PointF punto = new PointF(s * width, m * altura);
                        RectangleF rectangulito = new RectangleF(punto, dimen);
                        StringFormat numeros = new StringFormat();
                        numeros.Alignment = StringAlignment.Center;
                        numeros.LineAlignment = StringAlignment.Center;
                        Font fuente = new Font(Font.FontFamily, Width / 3);
                        pintar.DrawString($"{Tablero.tablero[m, s]}", new Font("", 30), brochita, (anchocasilla * s) + (anchocasilla / 2), (largocasilla * m) + (largocasilla / 2), numeros);
                    
                    }
                }

        }

        private void botonreiniciar_Click(object sender, EventArgs e)
        {
            //cantidadcolumnas = Tablero.totalcolumnas;
          //  cantidadfilas = Tablero.totalfilas;
            cantidadcolumnas = Convert.ToInt32(numericUpDowncolumnas.Value);
            cantidadfilas = Convert.ToInt32(numericUpDownfilas.Value);
            if(Tablero.Modo)
            {
                Tablero = new Class1(cantidadfilas, cantidadcolumnas);
                Tablero.Modo = Modo;
                Tablero.Movimientos = 0;
                Tablero.puntuacion = 0;
                lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
                progressBar1.Show();
                progressBar1.Value = Tablero.Movimientos;
       
            }
            else
            {
                Tablero = new Class1(cantidadfilas, cantidadcolumnas);
                progressBar1.Hide();
                Tablero.puntuacion = 0;
                lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
            }
            click = 1;
            pbxtablero.Refresh();            
        }

        private void pbxtablero_MouseClick(object sender, MouseEventArgs e)
        {
            int fila = (e.Y * cantidadfilas) / pbxtablero.Height;
            int columna = (e.X * cantidadcolumnas) / pbxtablero.Width;
            if (click == 1)
            {
                if (Tablero.tablero[fila, columna] != 0)
                {
                    filainicial = fila;
                    columnainicial = columna;
                    click++;
                }
                else
                    click = 1;
            }
            else if (click == 2)
            {
                filafinal = fila;
                columnafinal = columna;
                if ((filainicial == filafinal && columnainicial == columnafinal))
                    click--;
                else
                {
                    click--;
                    Tablero.Mover(filainicial, filafinal, columnainicial, columnafinal);
                    lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
                    progressBar1.Value = Tablero.Movimientos;
                    pbxtablero.Refresh();
                    if (Tablero.JugadaPerdida())
                    {
                        MessageBox.Show("Perdiste, inténtalo de nuevo");
                        Tablero.InicializarTablero();
                        if (Tablero.Modo)
                         progressBar1.Value = 0;
                        Tablero.puntuacion = 0;
                        lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
                        pbxtablero.Refresh();
                    }
                    if (Tablero.Movimientos == 18)
                    {
                        Tablero.Movimientos = 0;
                        Tablero.Mezclar();
                        progressBar1.Value = 0;
                        pbxtablero.Refresh();
                    }

                }
            }


        }

        private void modoNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Tablero.Modo = false;
            Modo = false;
            Tablero.puntuacion = 0;
            lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
            progressBar1.Hide();
            Tablero.InicializarTablero();
            click = 1;
            lblpuntuaciones.Refresh();
            pbxtablero.Refresh();
           
        }

        private void pbxtablero_Click(object sender, EventArgs e)
        {

        }

        private void modoAgresivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modo = true;
            Tablero.Modo = true;
            Tablero.puntuacion = 0;
            lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
            lblpuntuaciones.Refresh();
            progressBar1.Show();
            Tablero.InicializarTablero();
            progressBar1.Value = Tablero.Movimientos;
            click = 1;
            pbxtablero.Refresh();
        }

        private void guardarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            click = 1;
            Tablero.Salvar(Tablero);
        }

        private void cargarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tablero = new Class1(cantidadfilas, cantidadcolumnas);
            Tablero = Tablero.Cargar();
            click = 1;
            cantidadcolumnas = Tablero.totalcolumnas;
            cantidadfilas = Tablero.totalfilas;
            pbxtablero.Refresh();
           
            if (Tablero.Modo)
            {
                progressBar1.Show();

            }
            else
                progressBar1.Hide();
            lblpuntuaciones.Text = "Puntuacion: " + Tablero.puntuacion.ToString();
            lblpuntuaciones.Refresh();
            pbxtablero.Refresh();
        }
    }
}
