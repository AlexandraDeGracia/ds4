// See https://aka.ms/new-console-template for more information



int totaljugador = 25;
int totaldealer = 15;
string mensaje = "";
// El codigo compara el puntaje del jugador con el del dealer y asigna un mensaje indicando si gano o perdio
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