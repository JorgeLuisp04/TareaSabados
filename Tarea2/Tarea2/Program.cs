namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa en el cual se ingresen cuatro números, 
            calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.*/
            int v1, v2, v3, v4;
            Console.WriteLine("Favor ingrese los cuatros digitos.");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma del primer valor y el segundo es: {v1+v2}");
            Console.WriteLine($"El producto del tercer valor y el cuarto es: {v3*v4}");



        }
    }
}