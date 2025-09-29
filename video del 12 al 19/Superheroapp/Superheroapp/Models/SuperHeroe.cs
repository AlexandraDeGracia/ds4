using Superheroapp.Models;
using Superheroapp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre;

        public int Id { get; set; } = 1;
        public override string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value.Trim(); }
        }

        public string Identidad { get; set; }
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }

        public string NombreEIdentidadSecreta
        {
            get { return $"{Nombre}({Identidad})"; }
        }

        private string _IdentidadSecreta;

        public string IdentidadSecreta
        {
            get { return Identidad; }
            set { Identidad = value; }
        }



        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} está usando el super poder {item.nombre}");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return NombreEIdentidadSecreta;
        }
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }
        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }

    }
}
