using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.domain;
using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.controllers
{
    internal class GestionController
    {
		internal void SerializaEstadoJuego(EstadoJuego estadoJuego, String nombreFichero)
		{
			Serializar serializar = new Serializar();
			serializar.SerializaEstadoJuego(estadoJuego, nombreFichero);
		}

		internal EstadoJuego? DeserializaEstadoJuego(String nombreFichero)
		{
			Deserializar deserializar = new Deserializar();
			return deserializar.DeserializaEstadoJuego(nombreFichero);
		}
	}
}
