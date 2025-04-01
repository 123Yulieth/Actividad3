using System.Drawing;

class Rectangulo : Figura
{
    private int Ancho = 50;
    private int Alto = 30;

    public Rectangulo(Color color, int x, int y) : base(color, x, y) { }

    public override void Dibujar(Graphics g)
    {
        using (SolidBrush brush = new SolidBrush(Color))
        {
            g.FillRectangle(brush, X, Y, Ancho, Alto);
        }
    }
}

