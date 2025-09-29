using Superheroapp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroapp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Identidad secreta: {superHeroe.IdentidadSecreta}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
        }
    }
}
