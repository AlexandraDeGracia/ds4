// See https://aka.ms/new-console-template for more information
using Superheroapp;
using Superheroapp.Models;
using SuperheroesApp.Models;
using System.Text;
using System.Text;
Console.WriteLine("Hello, World!");

var imprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.nombre = "Volar";
poderVolar.description = "Capacidad para volar";
poderVolar.Nivel = NivelPoder.NivelDOS;

var superFuerza = new SuperPoder();
superFuerza.nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.Niveltres;

var regeneracion = new SuperPoder();
regeneracion.nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.Niveltres;


var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.Identidad = "Clark Kent";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);

Console.WriteLine(superman); 

SuperHeroRecord superHeroRecord = new(1, "superman", "Clark kent");
SuperHeroRecord superHeroRecord2 = new(1, "superman", "Clark kent");
Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.Identidad = "Logan";
wolverine.PuedeVolar = false;

imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;

string resulWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resulWolverinePoderes);

string accionAntieroe = wolverine.RealizarAccionDeAntiheroe("Atacar a la policia");
Console.WriteLine(accionAntieroe);
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

public record SuperHeroRecord(int Id, string Nombre, string Identidad);
