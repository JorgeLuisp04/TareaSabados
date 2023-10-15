namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la longitud del lado del cuadrado: ");
            int lado = Convert.ToInt32(Console.ReadLine());
            int perimetro = 4 * lado;
            Console.WriteLine(lado);
            Console.WriteLine($"El perímetro del cuadrado con lado es {perimetro}");
        }
    }
}