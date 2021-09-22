using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Vuelo
    {

        public double Tarifa { get; set; }
        public string Destino { get; set; }
        public Copiloto copiloto { get; set; }
        public List<PersonalAsistencia> personalAsistencia { get; set; }
        public List<Pasajero> pasajero { get; set; }

    }
}
