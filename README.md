# SerializarNet

SerializarNet es un proyecto que muestra ejemplos de serialización y deserialización de objetos en .NET utilizando diferentes formatos, como XML, JSON y binario.

## Estructura del proyecto

El repositorio está organizado de la siguiente manera:

- **`SerializarNet`**: Carpeta principal del proyecto.
  - **`SerializarNet.sln`**: Solución del proyecto.
  - **`SerializarNet.Core`**: Biblioteca de clases que contiene las clases y utilidades relacionadas con la serialización y deserialización de objetos.
    - **`Serializador.cs`**: Clase que proporciona métodos para serializar y deserializar objetos en diferentes formatos.
  - **`SerializarNet.Tests`**: Proyecto de pruebas unitarias para la biblioteca `SerializarNet.Core`.
    - **`SerializadorTests.cs`**: Clase de pruebas que verifica la funcionalidad del `Serializador`.
  - **`SerializarNet.ConsoleApp`**: Aplicación de consola que muestra ejemplos de uso de la biblioteca `SerializarNet.Core`.
    - **`Program.cs`**: Archivo principal de la aplicación de consola que contiene el código de muestra.

## Uso

Puedes utilizar la biblioteca `SerializarNet.Core` en tus propios proyectos para realizar la serialización y deserialización de objetos en diferentes formatos. La clase `Serializador` proporciona métodos como `SerializarXml`, `SerializarJson` y `SerializarBinario` para convertir objetos en cadenas XML, JSON y binarias, respectivamente. Asimismo, los métodos `DeserializarXml`, `DeserializarJson` y `DeserializarBinario` permiten convertir las cadenas en objetos nuevamente.

La aplicación de consola `SerializarNet.ConsoleApp` proporciona ejemplos de uso de la biblioteca. Puedes ejecutarla para ver los resultados de los diferentes escenarios de serialización y deserialización.

## Repositorio de solo lectura

Este repositorio es de solo lectura. No se aceptarán modificaciones directas en el repositorio original. Si deseas contribuir con mejoras o correcciones, por favor, crea una bifurcación (fork) del repositorio y trabaja en tu propia copia. Luego, puedes enviar una solicitud de extracción (pull request) para que se revisen tus cambios. Agradecemos tu interés en el proyecto y tus posibles contribuciones.
