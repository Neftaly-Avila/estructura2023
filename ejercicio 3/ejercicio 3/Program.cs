
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RomboApp
{
    public partial class Form1 : Form
    {
        private int sideLength; // Longitud del lado del rombo

        public Form1()
        {
            object value = InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pide al usuario la longitud del lado del rombo
            Console.Write("Ingresa la longitud del lado del rombo: ");
            sideLength = Convert.ToInt32(Console.ReadLine());

            // Calcula las coordenadas de los vértices del rombo
            Point topVertex = new Point(ClientSize.Width / 2, ClientSize.Height / 2 - sideLength / 2);
            Point bottomVertex = new Point(ClientSize.Width / 2, ClientSize.Height / 2 + sideLength / 2);
            Point leftVertex = new Point(ClientSize.Width / 2 - sideLength / 2, ClientSize.Height / 2);
            Point rightVertex = new Point(ClientSize.Width / 2 + sideLength / 2, ClientSize.Height / 2);

            // Crea un objeto Graphics para dibujar en la ventana
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black);

            // Dibuja las líneas del rombo
            g.DrawLine(pen, topVertex, rightVertex);
            g.DrawLine(pen, rightVertex, bottomVertex);
            g.DrawLine(pen, bottomVertex, leftVertex);
            g.DrawLine(pen, leftVertex, topVertex);
        }
    }
}

