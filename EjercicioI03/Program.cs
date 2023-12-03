using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola
        // Validar que el dato ingresado por el usuario sea un número
        // Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir
        // Si ingresa "salir", cerrar la consola
        // Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.


        int numero = 0;
        Console.WriteLine("ingresar un numero para calcular los numeros primos");
        string ingreso  = Console.ReadLine();
       
        if(int.TryParse(ingreso, out numero))
        {
            
            for (int i = 1; i <= numero; i++)
            {
                if (i >= 2)
                {
                    bool divisible = false;

                    for(int  j = 2; j < i; j++)
                    {
                        if(i%j == 0)
                        {
                            divisible = true;
                            break;
                        }
                    }

                    if (!divisible)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
        else
        {
            Console.WriteLine("Error");
        }



    }
}