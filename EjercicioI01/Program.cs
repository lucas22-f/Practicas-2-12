internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        int maximo = int.MinValue;
        int minimo = int.MaxValue;
        int promedio = 0;
        for (int i = 0; i < 5; i++) {

            Console.WriteLine("ingrese numeros ");
            numero = int.Parse(Console.ReadLine());

            if(numero < minimo)
            {
                minimo = numero;
            }
            else
            {
                maximo = numero;
            }

            promedio += numero;
        }

        promedio = promedio / 5;
        Console.WriteLine("promedio : " + promedio);
        Console.WriteLine("maximo : " + maximo);
        Console.WriteLine("minimo : " + minimo);



    }
}