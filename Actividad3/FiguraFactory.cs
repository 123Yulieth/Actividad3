using System;
using System.Drawing;

class FiguraFactory
{
    public static Figura CrearFigura(string tipo, Color color, int x, int y)
    {
        if (tipo == "Rectangulo")
            return new Rectangulo(color, x, y);

        throw new ArgumentException("Tipo de figura no reconocido.");
    }
}

