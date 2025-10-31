namespace quiz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion:(suma, resta, multiplicacion, division,): ");
            string operacion = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = Calcular(numero1, numero2, operacion);

            Console.WriteLine("\nEl resultado es: " + resultado);
        }
            static double Calcular(double numero1, double numero2, string operacion)
            {
                if (operacion == "suma")
                    return numero1 + numero2;
                else if (operacion == "resta")
                    return numero1 - numero2;
                else if (operacion == "multiplicacion")
                    return numero1 * numero2;
                else if (operacion == "division")
                    return numero1 / numero2;
                else
                    return 0;
        }
    }
}
