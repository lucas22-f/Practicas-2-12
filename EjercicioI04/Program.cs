internal class Program
{
    private static void Main(string[] args)
    {

        //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo)
        //que son divisores del número.

        //El primer número perfecto es 6, ya que los divisores
        //de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

        //Escribir una aplicación que encuentre
        //los 4 primeros números perfectos.

    
        int contador = 0;
        int inicio = 2;
       

        while(contador < 4)
        {
            int sumaDivisores = 1;
            for (int i = 2 ; i <= inicio / 2; i++)
            {
                if(inicio % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            if(sumaDivisores == inicio)
            {
                Console.WriteLine("Numero perfecto : " + inicio);
                contador++;
            }

            inicio++;
            

        }


    }
}