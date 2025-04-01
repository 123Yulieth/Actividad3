using System;
using System.Drawing;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        private Color colorSeleccionado = Color.Black;
        private int contadorRectangulos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionarColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    pictureBoxColor.BackColor = colorSeleccionado;
                }
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtPosX.Text);
                int y = int.Parse(txtPosY.Text);

                // Usar la fábrica para crear el rectángulo
                Figura rectangulo = FiguraFactory.CrearFigura("Rectangulo", colorSeleccionado, x, y);
                DibujarFigura(rectangulo);

                // Incrementar el contador
                contadorRectangulos++;
                txtContador.Text = contadorRectangulos.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos para las coordenadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarFigura(Figura figura)
        {
            using (Graphics g = panelDibujo.CreateGraphics())
            {
                figura.Dibujar(g);
            }
        }
    }

    // --------------------------------------
    // 🔷 Clase abstracta Figura
    public abstract class Figura
    {
        protected Color color;
        protected int x, y;

        public Figura(Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public abstract void Dibujar(Graphics g);
    }

    // --------------------------------------
    // 🔷 Clase concreta Rectángulo
    public class Rectangulo : Figura
    {
        public Rectangulo(Color color, int x, int y) : base(color, x, y) { }

        public override void Dibujar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, x, y, 50, 30);
            }
        }
    }

    // --------------------------------------
    // 🔷 Clase Factory para crear figuras
    // --------------------------------------
    // 🔷 Clase Factory para crear figuras
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, int x, int y)
        {
            if (tipo == "Rectangulo")
            {
                return new Rectangulo(color, x, y);
            }
            else
            {
                throw new ArgumentException("Tipo de figura no válido");
            }
        }
    }

}
