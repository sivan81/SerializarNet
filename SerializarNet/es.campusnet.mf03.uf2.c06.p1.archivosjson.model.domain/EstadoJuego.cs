using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.domain
{
    public class EstadoJuego
    {

        public String? AliasJugador { get; set; }
        public int NumeroPantalla { get; set; }
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }
        public int CoordenadaZ { get; set; }

        public override String ToString()
        {
            return AliasJugador + " " + NumeroPantalla + " " + CoordenadaX + " " + CoordenadaY + " " + CoordenadaZ + " ";
        }

    }
}
