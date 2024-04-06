using System.Net;

public class Program
{
    private static void Main(string[] args)
    {
        do
        {
            bool validador;
            int opcion, salir;
            Console.WriteLine("Hola ¿eres capaz de adivinar el número que estoy pensando?\n");
            Console.WriteLine("Cuantos van a jugar\n");
            Console.WriteLine("|Digita 1 para dos jugadores   |");
            Console.WriteLine("|Digita 2 para tres jugadores  |");
            Console.WriteLine("|Digita 3 para cuatro jugadores|");
            Console.WriteLine("Digita 1 par volver a jugar o 0 para terminar");
            salir = int.Parse(Console.ReadLine());
            if (salir == 0)
            {
                validador = false ;


            }else validador = true ;

        } while (validador == true);


}   }