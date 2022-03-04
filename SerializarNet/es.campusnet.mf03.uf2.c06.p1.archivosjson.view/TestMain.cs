using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.controllers;
using SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.model.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarNet.es.campusnet.mf03.uf2.c06.p1.archivosjson.view
{
    public class TestMain
    {

		private static String NOMBRE_FICHERO = "D:/Mega/DAM/Primer Curso/SegundoSemestre/M3UF2/pruebas/EstadoJuegoNET.json";

		public static void Main()
        {
			//Serializar();
			Deserializar();
		}


		private static void Serializar()
		{
			EstadoJuego estadoJuego = new EstadoJuego();
			estadoJuego.AliasJugador= "JJJ";
			estadoJuego.CoordenadaX=22;
			estadoJuego.CoordenadaY=345;
			estadoJuego.CoordenadaZ=10;
			estadoJuego.NumeroPantalla=11;

			GestionController gestionController = new GestionController();

			gestionController.SerializaEstadoJuego(estadoJuego, NOMBRE_FICHERO);

			Console.WriteLine("Fichero generado");
		}

		private static void Deserializar()
		{
			GestionController gestionController = new GestionController();
			EstadoJuego estadoJuego = gestionController.DeserializaEstadoJuego(NOMBRE_FICHERO);
			Console.WriteLine(estadoJuego);
		}
	}
}
