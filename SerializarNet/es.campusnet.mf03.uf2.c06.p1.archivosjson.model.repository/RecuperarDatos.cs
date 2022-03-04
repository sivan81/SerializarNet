using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.repository
{
    class RecuperarDatos
    {
        internal String Leer(String fichero)
        {
            String contenido = File.ReadAllText(fichero);
            return contenido;
        }
    }
}
