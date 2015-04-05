namespace Core
{
    public class Triangulo
    {
        public string Validar(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Triangulo Inválido";
            }

            if ((a > b + c || b > a + c || c > a + b))
            {
                return "Triangulo Inválido";
            }

            if (a == b && b == c)
            {
                return "Triangulo Equilátero";
            }

            if (a == b || b == c || a == c)
            {
                return "Triangulo Isósceles";
            }

            return "Triangulo  Escaleno";
        }
    }
}
