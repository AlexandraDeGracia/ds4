// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Programa para que calcule la resta de un rectangulo

// variable hechas
int ladoA, ladoB, resultado;

//le preguntamos al usuario el lado A y  el lado B del rectangulo
Console.WriteLine("Calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());
if (ladoA < 0 || ladoB < 0)
{
    Console.WriteLine("Los datos no pueden ser negativos");
}
else
{
    //Operador de decremento
    ladoA--;
    ladoB--;
    //Salida para el area de un rectangulo:
    resultado = ladoA * ladoB;
    Console.WriteLine("si el lado A es: " + ladoA + " y el lado B es:" + ladoB + " entonces el resultado de el area del rectangulo es: " + resultado);
}
// variables claras e ocultas
var lA = 0d;
var lB = 0d;
var Res = 0d;

Console.WriteLine();
//Le preguntamos al usuario el lado A y lado B del rectangulo
Console.WriteLine("Calcula el area de un rectangulo con decimales o enteros");
Console.WriteLine("Ingrese el valor del lado A");
lA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor del lado B");
lB = Convert.ToDouble(Console.ReadLine());

//salidas de incremento
lB++;
lA++;

//formula para el area de un rectangulo:
Res = lA * lB;
Console.WriteLine("si el lado A es:" + lA + " y el lado B es:" + lB + " entonces el resultado de el area del rectangulo es: " + Res);

}



