// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//tipos de operadores lógicos: &&, ||, !, ^

bool valor1 = true;
bool valor2 = false;
bool valor3 = true;

/*El valor && sirve para comprara dos o mas valores y funciona cuando se cumplren todas las condiciones*/
bool res = valor1 && valor2;

Console.WriteLine(res);

/*el valor || sirve para comparar dos valores o mas y funciona cuando se 
cumple una u otra condición */
bool res1 = valor1 || valor2;

Console.WriteLine(res1);

bool res2 = (valor1 && valor2) || valor3;
Console.WriteLine(res2);

// el valor not sirv poniendo la respuesta al reves al resto de la opreacion
bool res3 = !valor1;
Console.WriteLine(res3);

//Sirve para consultar si los argumentos son diferentes
bool res4 = valor1 ^ valor2;
Console.WriteLine(res4);