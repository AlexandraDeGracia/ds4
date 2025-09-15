// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

int totaljugador = 25;
int totaldealer = 15;
string mensaje = "";
String swichcont = "miau";
// El codigo compara el puntaje del jugador con el del dealer y asigna un mensaje indicando si gano o perdio

switch(swichcont)
{
    case "menu":
        Console.WriteLine("Bienvenido al se fue mi quincena");
        Console.WriteLine("Escribe'21 para jugar al 21");
        swichcont = Console.ReadLine();
        break;
    case "21":
        if (totaljugador > totaldealer && totaljugador < 22)
{
    mensaje = "Vencisite al dealer, felicidades";
}
else if (totaljugador > 22)
{
    mensaje = "perdiste vs el dealer, sorry te pasaste de 21";
}
else if (totaljugador <= totaldealer)
{
    mensaje = "perdiste vs el dealer, sorry";
}
else
{
    mensaje = "condicion no valida";
}
// Ejecuta los resultados
Console.WriteLine(mensaje);
        break;
    default:
        Console.WriteLine("Valor ingresa no valido en el se fue mi quincena ");
        break;
}