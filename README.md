# GEOWProyect
Implementación cqrs con flow - c# &amp; sql server xtreme practices

El proyecto GEOWDB es de tipo SQL Server y contiene el esquema necesario para que la aplicación chute

Cree la base de datos en su servidor SQL Server (nombre por defecto GEOWDB) y ejecute una comparación de esquemas.

GEOW es el proyecto de Windows compuesto por formularios de Windows. Revise la cadena de conexión a base de datos en el app.config de este proyecto.

Los datos maestros mínimos necesarios afectan a las tablas dbo.ActionFieldTypes y dbo.Orientations

En el proyecto GEOWDB, en la carpeta SCRIPTS dispone de los scripts SQL para alimentarlas

Al ejecutar la aplicación con muchas figuras se graban en la base de datos coordenadas de forma masiva. Por esto debe tener precauciones con respecto al espacio en disco disponible. 

Por favor, no ejecute la aplicación en entornos críticos. El consumo de recursos puede afectar fuertemente a otras aplicaciones en ejecución.





