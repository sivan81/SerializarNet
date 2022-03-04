﻿using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.domain;
using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.service
{
    class Serializar
    {
        internal void SerializaEstadoJuego(EstadoJuego estadoJuego, String nombreFichero)
        {
            String contenidoJson = JsonSerializer.Serialize(estadoJuego);
            GuardarDatos guardarDatos = new GuardarDatos();
            guardarDatos.Guardar(nombreFichero, contenidoJson);
        }
    }
}
