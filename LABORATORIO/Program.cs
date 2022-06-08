using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{
    class Program
    {
        static void Main(string[] args)
        {

            string menu = "\nMenu LAB 01\n" +
                "1. Suma especial\n" +
                "2. Ordenar Arreglos\n" +
                "3. Triangulo de Pascal\n"+
                "4. Serie de Fibbonacci\n" +
                "5.Salir\n" +
                "Seleccione una opción: ";
            bool salir = false;
            Funciones ope = new Funciones();

            while (!salir)
            {
                Console.Clear();
                Console.Write(menu);
                int op = Int32.Parse(Console.ReadLine());
                switch (op)    
                {
                    case 1:

                        
                        Console.WriteLine("No lo pude hacer profe. Lo siento :C ");

                        break;

                    case 2:

                        Console.WriteLine("Ordernando Arreglo. ");
                        int[] arregloNumeros = new int[] { 1, 4, 2, 7, 55, 9, 7, 10, 99, 3 };


                        int[] arreglo = arregloNumeros;
                        for (int indice = 0; indice < arreglo.Length; indice++)
                        {
                            int elemento = arreglo[indice];
                            Console.Write(elemento);
                            // Imprimir también una coma
                            Console.Write(", ");
                        }

                        Array.Sort(arregloNumeros);
                        Console.WriteLine(string.Join(", ",arregloNumeros));
                        break;

                    case 3:

                        int N = 0;
                        string cadena;
                        Console.Write("Cuantas Filas: ");
                        cadena = Console.ReadLine();
                        N = int.Parse(cadena);
                        int res = ope.TrianguloPascal(N);
                        Console.WriteLine(res);

                        break;

                    case 4:

                        int limite = 0;
                        Console.WriteLine("Ingrese el número de numeros de Fibbonacci que desea mostrar: ");
                        limite = int.Parse(Console.ReadLine());
                        int res1 = ope.SerieFibbonaci(limite);
                        Console.WriteLine(res1);
                        break;

                    case 5:

                        Console.WriteLine("Salir");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción Inválida");
                        break;
                }

                Console.ReadKey();





            }
        }
    }
}