using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace juegoDeLaOca
{
    class Program
    {
        private static int maxPosicion = 100;
        private static int[] player;
       // private static int playerTwo = 0;
        private static int tirada = 0;
        static void Main(string[] args)
        {
            player = new int[2];
            Random rand = new Random();
            while((player[0] != maxPosicion) && (player[0] != maxPosicion))
            {
                tirar(0, (rand.Next(5) + 1));
                tirar(1, (rand.Next(5) + 1));

            }

            if(player[0] == maxPosicion)
            {
                Console.WriteLine("El jugador uno ha ganado");
            } else
            {
                Console.WriteLine("El jugador dos ha ganado");
            }
            Console.ReadLine();
        }

        static void tirar(int i, int x)
        {
            tirada = x;
            player[i] += tirada;


            if (player[i] > maxPosicion)
            {
                player[i] = maxPosicion - (player[i] - maxPosicion);
            }

            Console.Out.WriteLine("Es el turno del jugador " + (i + 1) );
            Console.WriteLine("El jugador " + (i + 1) + " ha sacado un " + tirada);
            if (player[i] % 13 == 0)
            {
                player[i] = 0;
                Console.Out.WriteLine("El jugador"+ (i+1) +" vuelve a la casilla de salida :(");
            }
            Console.Out.WriteLine("La posicion del jugador es " + player[i]);
            Thread.Sleep(1000);

        }

    }
}
