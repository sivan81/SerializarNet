using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.domain;
using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.service
{
    internal class Deserializar
    {
        internal EstadoJuego? DeserializaEstadoJuego(String nombreFichero)
        {
            EstadoJuego? estadoJuego = null;

            RecuperarDatos recuperarDatos = new RecuperarDatos();
            String contenido = recuperarDatos.Leer(nombreFichero);
            estadoJuego = JsonSerializer.Deserialize<EstadoJuego>(contenido);

            return estadoJuego;
        }
    }
}
