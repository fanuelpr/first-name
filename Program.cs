
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
    static int MaxValueFromArray(int[] numeros){
        int aux = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] > aux)
                aux = numeros[i];
        }

        return aux;

    }

//UNA FUNCION QUE DEVUELVA EL MENOR VALOR DE UN ARRAY DE ENTEROS
        static int MinValueFromArray(int[] numeros){
        int aux = numeros[1];
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] < aux)
                aux = numeros[i];
        }
        return aux;
    }



 //UNA FUNCION QUE DEVUELVA UN ARRAY CON TODOS LOS NUMEROS PARES DE UN ARRAY
        static int[] ParValueFromArray  (int[] numeros){
            int[] auxArray= new int[numeros.Length] ;
            int j=0;
            for(int i=0; i < numeros.Length; i++)
            {
                if( numeros[i] % 2 == 0 )
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
        static int[] ImparValueFromArray  (int[] numeros){
            int[] auxArray= new int[numeros.Length] ;
            int j=0;
            for(int i=0; i < numeros.Length; i++)
            {
                if( numeros[i] % 2 != 0 )
                {
                    auxArray[j] = numeros[i];
                    j++;
                }
            }
            return auxArray;
        }


//UNA FUNCION QUE SUME TODAS LAS POSICIONES DE UN ARRAY Y DEVUELVA UN ENTERO CON EL VALOR TOTAL
        static int SumaValueFromAarray (int[] numeros){
            int aux = 0;
            for (int i = 0; i < numeros.Length; i++ ){
                aux += numeros[i];
            }          
              return aux;  
        }
          


//UNA FUNCION QUE SUME TODAS LAS POSICIONES DE UN ARRAY Y DEVUELVA SI ES PAR O NO.
        static int[] SumayValidacionValueFromAarray (int[] numeros){
            int aux = 0;
            int[] auxArray = new int [numeros.Length];
            for (int i = 0; i < numeros.Length; i++ ){
                aux += numeros[i];
            }          
                auxArray=ParValueFromArray(numeros);
            
            return auxArray;
        }
          
//UNA FUNCION QUE SUME TODOS LOS VALORES PARES DE UN ARRAY
        static int SumaParesValueFromAarray (int[] numeros){
            int aux = 0;

            for (int i = 0; i < numeros.Length; i++ ){
                if (numeros[i] % 2 == 0)
                {
                    
                    aux += numeros[i];
                
                }          
            }
            
            return aux;
        }





    static void Main(string[] args)
    {
        
        int[] numeros = { 5, 100, 15, 2 };
        int[] auxArray;
        int ValorTotal;
        DateTime ahora = DateTime.Now ;

        // Mostrar la fecha y hora en la consola
        Console.WriteLine("Fecha y Hora actuales: " + ahora);

        // Mostrar solo la hora
        Console.WriteLine("Hora actual: " + ahora.ToString("HH:mm:ss"));
        Console.WriteLine("HOLAAA");
        

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


       
