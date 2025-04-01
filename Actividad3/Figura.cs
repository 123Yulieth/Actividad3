using System;
using System.Drawing;

abstract class Figura
{
    public Color Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Figura(Color color, int x, int y)
    {
        Color = color;
        X = x;
        Y = y;
    }

    public abstract void Dibujar(Graphics g);
}
