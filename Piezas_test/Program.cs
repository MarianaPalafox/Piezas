using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Piezas_test
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ///tablero
            int[][] tablero = new int[5][] {
                new int [9] { 0, 100, 0, 100, 0, 100, 0, 100, 0 },
                new int [9] { 100, 0, 100, 0, 100, 0, 100, 0, 100 },
                new int [9] { 0, 100, 0, 100, 0, 100, 0, 100, 0 },
                new int [9] { 100, 0, 100, 0, 100, 0, 100, 0, 100 },
                new int [9] { 0, 100, 0, 100, 0, 100, 0, 100, 0 },
            };
            ///
            ///pieza verde
            /// array [row] [columns]
            int[][] p_v1 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v2 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 0, 0, 0 }
            };
            int[][] p_v3 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v4 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v6 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }
            };
            int[][] p_v7 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v8 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v9 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v10 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }
            };
            int[][] p_v11 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 1 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v12 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_v13= new int[5][] {
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            ///pieza verde
            ///
            ///pieza amarilla
            int[][] p_am1 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am2 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }
            };
            int[][] p_am3 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 1 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am4= new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am5 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am6 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 1, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am7 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am8= new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am9 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }
            };
            int[][] p_am10 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am11 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 1, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am12 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[][] p_am13 = new int[5][] {
                new int [9] { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 1, 0, 1, 0, 0, 0 },
                new int [9] { 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int [9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            ///pieza amarilla

            List<int[][]> allTransoformations = new List<int[][]>();
            allTransoformations.Add(p_v1);
            int[][][] arr = new int[1] [][]{
                new int [5] [] {
                    new int [9] { 0,0,0,0,0,0,0,0,0 },
                    new int [9],
                    new int [9],
                    new int [9],
                    new int [9]
                }
            };
            // Iteramos las posiciones en el tablero todas
            for (int i = 0; i < arr.GetLength(0); i++) 
                // Iteramos la fila para esa posicion
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i][j][k]);
                    }
                    
           
      

            Console.ReadKey();
        }
    }
}
