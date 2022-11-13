using LibreriaTransporte.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaTransporte;

namespace LibreriaTransporte.Models
{
    public class Azafata : Persona
    {
        public Azafata(int tripulanteId, string nombre, string apellido) : base(tripulanteId, nombre, apellido)
        {
            IsAbordo = false;
        }
        public bool IsAbordo { get; set; }
    }
}