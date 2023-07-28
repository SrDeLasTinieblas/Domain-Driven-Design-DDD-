# Ejemplo de Arquitectura DDD en .NET Web API

Este es un proyecto de ejemplo que muestra cómo implementar la arquitectura Domain-Driven Design (DDD) en una API web utilizando .NET y ASP.NET Core.

![Imagen](ruta/a/imagen.png) (Reemplaza 'ruta/a/imagen.png' con la ruta de la imagen que desees mostrar)

## ¿Qué es DDD?

**Domain-Driven Design (DDD)** es una metodología de diseño de software que se centra en el dominio del negocio y busca estructurar la aplicación en torno a conceptos y abstracciones del dominio.

### Principios de DDD:

1. **Ubicación de la lógica del negocio**: La lógica del negocio y las reglas específicas del dominio se encuentran en el corazón de la aplicación y se aíslan de las preocupaciones técnicas.
2. **Modelado del Dominio**: Los conceptos clave del negocio son modelados como entidades, objetos de valor y agregados.
3. **Bounded Contexts**: El dominio se divide en contextos acotados que delimitan y aíslan la lógica del negocio para facilitar el mantenimiento y la evolución.
4. **Ubiquitous Language**: Emplear un lenguaje común y compartido entre los miembros del equipo de desarrollo y los expertos del dominio.

## Estructura del Proyecto

El proyecto sigue una estructura de carpetas comúnmente utilizada en aplicaciones ASP.NET Core basadas en DDD:

- `Domain`: Contiene las entidades, objetos de valor y agregados que representan el modelo de dominio de la aplicación.
- `Application`: Aquí se encuentran los servicios de aplicación y los View Models utilizados para la interacción con la API.
- `Infrastructure`: Contiene la implementación de las interfaces de repositorio y cualquier lógica de persistencia necesaria.
- `Presentation`: En esta carpeta se encuentra el controlador de la API y los View Models específicos para la presentación de datos.

## Tecnologías Utilizadas

- .NET 6
- ASP.NET Core 6
- Entity Framework Core (EF Core) para la persistencia de datos
- Microsoft SQL Server como base de datos

## Instrucciones de Uso

1. Clona el repositorio a tu máquina local usando `git clone`.
2. Abre la solución en Visual Studio o Visual Studio Code.
3. Verifica y actualiza la cadena de conexión de la base de datos en `appsettings.json` del proyecto `Presentation`.
4. Ejecuta la migración inicial para crear la base de datos utilizando el comando `dotnet ef database update`.
5. Ejecuta la aplicación utilizando `dotnet run`.
6. Accede a la API a través de `https://localhost:{PUERTO}/api/productos` en tu navegador o herramienta de cliente API, donde `{PUERTO}` es el puerto en el que se está ejecutando la aplicación.

## Contribuciones

¡Las contribuciones son bienvenidas! Si tienes ideas de mejora, sugerencias o correcciones, no dudes en abrir un pull request o crear un issue.

## Capturas de Pantalla (opcional)

_(Si deseas mostrar capturas de pantalla de la API en funcionamiento o diagramas de la arquitectura, este es el lugar para hacerlo)_

## Licencia

Este proyecto está bajo la Licencia MIT. Puedes consultar el archivo [LICENSE](./LICENSE) para obtener más detalles.

---
