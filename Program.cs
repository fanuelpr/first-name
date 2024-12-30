
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static int MaxValue(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    // BUSCA EL MAXIMO VALOR DE UN ARRAY
    static int MaxValueFromArray(int[] numeros)
    {
        int aux = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > aux)
                aux = numeros[i];
        }

        return aux;

    }

    //UNA FUNCION QUE DEVUELVA EL MENOR VALOR DE UN ARRAY DE ENTEROS
    static int MinValueFromArray(int[] numeros)
    {
        int aux = numeros[1];
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < aux)
                aux = numeros[i];
        }
        return aux;
    }



    //UNA FUNCION QUE DEVUELVA UN ARRAY CON TODOS LOS NUMEROS PARES DE UN ARRAY
    static int[] ParValueFromArray(int[] numeros)
    {
        int[] auxArray = new int[numeros.Length];
        int j = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                auxArray[j] = numeros[i];
                j++;
            }
        }
        return auxArray;
    }


    static int[] ParValueFromArray2(int[] numeros)
    {
        // Creamos una lista para almacenar los números pares
        List<int> auxList = new List<int>();

        // Bucle único para recorrer el array y agregar los números pares a la lista
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                auxList.Add(numeros[i]);
            }
        }

        // Convertimos la lista a un array y lo devolvemos
        return auxList.ToArray();

    }






    //UNA FUNCION QUE DEVUELVA UN ARRAY CON TODOS LOS NUMEROS IMPARES DE UN ARRAY
    static int[] ImparValueFromArray(int[] numeros)
    {
        int[] auxArray = new int[numeros.Length];
        int j = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 != 0)
            {
                auxArray[j] = numeros[i];
                j++;
            }
        }
        return auxArray;
    }


    //UNA FUNCION QUE SUME TODAS LAS POSICIONES DE UN ARRAY Y DEVUELVA UN ENTERO CON EL VALOR TOTAL
    static int SumaValueFromAarray(int[] numeros)
    {
        int aux = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            aux += numeros[i];
        }
        return aux;
    }



    //UNA FUNCION QUE SUME TODAS LAS POSICIONES DE UN ARRAY Y DEVUELVA SI ES PAR O NO.
    static int[] SumayValidacionValueFromAarray(int[] numeros)
    {
        int aux = 0;
        int[] auxArray = new int[numeros.Length];
        for (int i = 0; i < numeros.Length; i++)
        {
            aux += numeros[i];
        }
        auxArray = ParValueFromArray(numeros);

        return auxArray;
    }

    //UNA FUNCION QUE SUME TODOS LOS VALORES PARES DE UN ARRAY
    static int SumaParesValueFromAarray(int[] numeros)
    {
        int aux = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {

                aux += numeros[i];

            }
        }

        return aux;
    }



            
    

        static string ConvertirNumeroALetras(int numero)
        {
            string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] diez_a_diecinueve = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };

            if (numero < 10)
            {
                return unidades[numero];
            }
            else if (numero >= 10 && numero < 20)
            {
                return diez_a_diecinueve[numero - 10];
            }
            else
            {
                int unidad = numero % 10;
                int decena = numero / 10;

                if (unidad == 0)
                {
                    return decenas[decena];
                }
                else
                {
                    return $"{decenas[decena]} y {unidades[unidad]}";
                }
            }
        }
    






    static void Main(string[] args)
    {

        int[] numeros = { 5, 100, 15, 2 };
        int[] auxArray;
        int ValorTotal;
        DateTime ahora = DateTime.Now;

        // Mostrar la fecha y hora en la consola
        Console.WriteLine("Fecha y Hora actuales: " + ahora);

        // Mostrar solo la hora
        Console.WriteLine("Hora actual: " + ahora.ToString("HH:mm:ss"));
        Console.WriteLine("HOLAAA");

        bool salir = false;
            
        while (!salir) 
        { 
            Console.Clear();
            Console.WriteLine("Menú de Funciones");
            Console.WriteLine("1. Max Value From Array");
            Console.WriteLine("2. Min Value From Array");
            Console.WriteLine("3. Suma Value From Array");
            Console.WriteLine("4. Suma Pares Value From Array");
            Console.WriteLine("5. Numeros a Letras");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
                switch (Console.ReadLine()) 
                { 
                    case "1":
                        Console.WriteLine("El mayor numero del array es: "+ MaxValueFromArray(numeros));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("El menor numero del array es: "+ MinValueFromArray(numeros));
                        Console.ReadKey();
                        break;
                    case "3":
                        ValorTotal= SumaValueFromAarray(numeros);
                        Console.WriteLine("La suma de los valores es: " + ValorTotal);
                        Console.ReadKey();
                        break;
                    case "4":
                        ValorTotal=SumaParesValueFromAarray(numeros);
                        Console.WriteLine(" Los numeros pares luego de sumarlos son:" + ValorTotal);
                        Console.ReadKey();
                        break;
                    case "5":
                            Console.Write("Ingrese un número (0-99): ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out int numero) && numero >= 0 && numero <= 99)
                            {
                                Console.WriteLine($"El número {numero} en letras es: {ConvertirNumeroALetras(numero)}");
                            }
                            else
                            {
                                Console.WriteLine("Número inválido. Por favor ingrese un número entre 0 y 99.");
                            }
                            Console.ReadKey();
                        break;
                    case "6":
                        salir = true;
                        break;
                
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
        }

           



        //     Console.WriteLine("El mayor numero del array es: "+ MaxValueFromArray(numeros));
        //     Console.WriteLine("El menor numero del array es: "+ MinValueFromArray(numeros));
        //     Console.WriteLine("Los numeros impares son: ");
        //    ValorTotal= SumaValueFromAarray(numeros); 
        //    Console.WriteLine("La suma de los valores es: " + ValorTotal);
        //     Console.WriteLine(" Los numeros pares luego de sumarlos son:");
        //     ValorTotal=SumaParesValueFromAarray(numeros);
        //     for (int i = 0; i < numeros.Length; i++)
        //     {
        //         Console.WriteLine(numeros[i]);
        //     }
        // // ValorTotal = SumaValueFromAarray(numeros);
        //     Console.WriteLine("La suma de los valores es: " + ValorTotal);

        //   for (int i = 0; i < auxArray.Length; i++)
        //   {
        //       Console.WriteLine(auxArray[i]);
        //   }
        //Array.Sort(numeros);

        // Console.WriteLine("El mayor numero del array es: ");
        // foreach (var numero in numeros)
        // {
        //     Console.WriteLine(numero);
        // }

        // Console.WriteLine("El mayor numero del array es: "+ MaxValueFromArray(numeros));

    }
}



