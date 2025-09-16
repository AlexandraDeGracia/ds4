// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Reflection;

int dinero = 0;
string control = "menu";
string mensaje;

int num;

System.Random random = new System.Random();
while (true)
{
    Console.WriteLine("Bienvenido al casino");
    Console.WriteLine("Cuantas vese deseas jugar\n" +
        "Nesecito que ingrese solo numeros enteros");

    dinero = int.Parse(Console.ReadLine());
    for (int i = 0; i < dinero; i++)
    {
        int jugador = 0;
        int delar = 21;
        switch (control)
        {
            case "menu":

                Console.WriteLine("Escriba 21 para jugar");
                control = Console.ReadLine();
                i = i - 1;
                break;
            case "21":
                do
                {
                    num = random.Next(1, 12);
                    jugador = jugador + num;
                    Console.WriteLine("desea una carta");
                    Console.WriteLine("esta fue su carta " + num);
                    Console.WriteLine("Desea otra carta si o no");
                } while (Console.ReadLine() == "si");

                Console.WriteLine("Ingresa el numero de cartas jugador");
                jugador = Convert.ToInt32(Console.ReadLine());
                if (jugador > delar || jugador > 50)
                {
                    mensaje = ("Vencion al delar");
                }
                else if (jugador < delar)
                {
                    mensaje = ("Perdio contra el delar");
                }
                else
                {
                    mensaje = ("Mensaje no valido");
                }

                Console.WriteLine(mensaje);
                break;
        }
    }

}