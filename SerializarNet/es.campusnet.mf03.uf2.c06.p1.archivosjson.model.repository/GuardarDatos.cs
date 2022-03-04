using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.repository
{
    class GuardarDatos
    {

        internal void Guardar(String fichero, String contenido)
        {
            File.WriteAllText(fichero, contenido);
        }

    }
}
