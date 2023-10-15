namespace tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.*/
            int v1, v2, v3, v4;
            int sumas;
            float promedio;


            Console.WriteLine("Favor ingresar el primer valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingresar el segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingresar el tercer valor: ");
            v3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingresar el cuarto valor: ");
            v4 = int.Parse(Console.ReadLine());

            Console.WriteLine(sumas = v1+v2+v3+v4);

            promedio = sumas / 4;

            Console.WriteLine("La suma de los valores es: " + sumas);
            Console.WriteLine("El promedio de los valores es: " + promedio);
        }
    }
}