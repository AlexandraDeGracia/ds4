// See https://aka.ms/new-console-template for more information
using System.Text;
using SuperheroesApp.Models;
Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.nombre = "Volar";
poderVolar.description = "Capacidad para volar";
poderVolar.Nivel = NivelPoder.NivelDOS;

var superFuerza = new SuperPoder();
superFuerza.nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.Niveltres;
var superman = new SuperHeroe();
var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.Identidad = "Clark Kent";
superman2.PuedeVolar = true;
Console.WriteLine(superman == superman2);

SuperHeroRecord superHeroRecord = new (1, "superman", "Clark kent");
SuperHeroRecord superHeroRecord2 = new(1, "superman", "Clark kent");

Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;

string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);



class SuperPoder
{
    public string nombre;
    public string description;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDOS,
    Niveltres
}
public record SuperHeroRecord(int Id, string Nombre,string Identidad);