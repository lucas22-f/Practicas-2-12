internal class Program
{
    private static void Main(string[] args)
    {
        //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se
        //debe validar que el número sea mayor que cero, caso contrario,
        //mostrar el mensaje: "ERROR. ¡Reingresar número!".

        Console.WriteLine("ingrese un numero");
        int numero = int.Parse(Console.ReadLine());
        int cuadrado = 0;
        double cubo = 0;
        if (numero > 0){

            cuadrado = (int)Math.Pow(numero, 2);
            cubo = Math.Pow(numero , 3);
        }
        else
        {
            Console.WriteLine("ERROR , reingresar numero");
        }

        Console.WriteLine("cuadrado :" + cuadrado);
        Console.WriteLine("cubo :" + cubo);


    }
}