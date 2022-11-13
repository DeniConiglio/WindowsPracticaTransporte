using LibreriaTransporte.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransporte.Models
{
    public class Copiloto : Persona
    {
        public Copiloto(int tripulanteId, string nombre, string apellido) : base(tripulanteId, nombre, apellido)
        {
        }
    }
}