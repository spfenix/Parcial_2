﻿using System.Net;

public class Program
{
    private static void Main(string[] args)
    {
        bool validador;
        do
        {
            int salir;
            Console.WriteLine("Hola ¿eres capaz de adivinar el número que estoy pensando?\n");
            Console.WriteLine("Cuantos van a jugar\n");
            Console.WriteLine("|Digita 1 para dos jugadores   |");
            Console.WriteLine("|Digita 2 para tres jugadores  |");
            Console.WriteLine("|Digita 3 para cuatro jugadores|");
            int opcion;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    int aleatorio;
                  Random generador = new Random();
                    aleatorio = generador.Next();
                    do
                    {
                        int num;
                        for (int i = 1; i <= 2; i++) ;
                        Console.WriteLine("Digita el número");
                        num = int.Parse(Console.ReadLine());

                    } while (true);
            }
              
















                    Console.WriteLine("Digita 1 par volver a jugar o 0 para terminar");
                    salir = int.Parse(Console.ReadLine());
                    if (salir == 0)
                    {

                        validador = false;

                    }
                    else validador = true;

        }while (validador == true) ;
    }   
}