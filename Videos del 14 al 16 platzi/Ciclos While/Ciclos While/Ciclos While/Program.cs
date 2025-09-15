// See https://aka.ms/new-console-template for more information

int totaljugador = 0;
int totaldealer = 0;
int num = 0;
string mensaje = "";
String swichcont = "menu";
String Controlotracarta = "";
// inicializar Random.Next y que exista en todo el programa
System.Random r = new System.Random();
// El codigo compara el puntaje del jugador con el del dealer y asigna un mensaje indicando si gano o perdio
while (true){
     totaljugador = 0;
     totaldealer = 0;

    switch (swichcont)
    {
        case "menu":
            Console.WriteLine("$$$$$$ Bienvenido al se fue mi quincena $$$$$$");
            Console.WriteLine("$$$$$$ Escribe'Carta' para jugar al a las Cartas $$$$$$");
            swichcont = Console.ReadLine();
            break;
        case "Carta":

            do
            {

                num = r.Next(1, 12);
                totaljugador = totaljugador + num;
                Console.WriteLine("Toma tu primera carta jugador");
                // manera para colocar numero que salio
                Console.WriteLine($"te salio el numero :{num}");
                Console.WriteLine("Deseas otra carta jugador?");
                Controlotracarta = Console.ReadLine();
                // se inicializo esta variable para no escribir repedidas veses Console.ReadLine()
            } while (Controlotracarta == "Si" || Controlotracarta == "si" || Controlotracarta == "yes");


            totaldealer = r.Next(14, 23);
            Console.WriteLine("El delel tiene{ totaldealer}");
            if (totaljugador > totaldealer && totaljugador < 22)
            {
                mensaje = "Vencisite al dealer, felicidades";
                swichcont = "menu";
            }
            else if (totaljugador >= 22)
            {
                mensaje = "perdiste vs el dealer, sorry te pasaste de 21";
                swichcont = "menu";
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
}
