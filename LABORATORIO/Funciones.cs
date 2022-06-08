using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{
    class Funciones
    {
        internal int TrianguloPascal(int N)

        {
            int F = 0;
            int C = 0;
            int COL = 0;
            int FI = 0;

            int[,] MAT = new int[N + 1, N + 1];
            // PROCESO
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    if (((C == 1) | (F == C)))
                    {
                        MAT[F, C] = 1;
                    }
                    else
                    {
                        MAT[F, C] = MAT[F - 1, C] + MAT[F - 1, C - 1];
                    }
                }
            }
            // SALIDA
            FI = 2;
            for (F = 1; F <= N; F++)
            {
                COL = 40 - (F * 2);
                for (C = 1; C <= N; C++)
                {
                    if ((MAT[F, C] != 0))
                    {
                        Console.SetCursorPosition(COL, FI);
                        Console.Write(MAT[F, C]);
                        COL = COL + 4;
                    }
                }
                FI = FI + 1;
                Console.WriteLine();
            }



            return FI;
        }



        internal int SerieFibbonaci(int limite)
        {
            int a, b, i, auxiliar;

            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            return b;
        }
    }
}