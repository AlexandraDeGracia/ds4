using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesApp.Models
{
    class SuperHeroe
    {
        public int Id = 1;
        public string Nombre;
        public string Identidad;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
            UsarSuperPoderes();
        }

        // 🔹 Cambié void -> string
       public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} está usando el super poder {item.nombre}");
            }
            return sb.ToString();
        }
    }
}
