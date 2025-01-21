using System.Drawing;
namespace Shape
{
    public class MyClass
    {
        static void Main(String[] args)
        {
            Figura triangulo = new Triangulo(5.2, 7.6);
            Figura rectangulo = new Rectangulo(6.9, 3.1);
            Figura circulo = new Circulo(8, 3);
            Figura[] figurasDiferentes = new Figura[3];

            figurasDiferentes[0] = triangulo;
            figurasDiferentes[1] = rectangulo;
            figurasDiferentes[2] = circulo;

            double[] FigurasAreas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                FigurasAreas[i] = FigurasDiferentes[i].CalculateSurface();
                Console.WriteLine("Se añadio el valor: " + i);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("El area de la figura " + i + " es de: " + FigurasAreas[i]);
            }

        }
    }
}