# Ejercicio 3 – Exportación de informes (DIP + ISP)

## Qué trabaja
- Dependency Inversion Principle (DIP)
- Interface Segregation Principle (ISP)
- Interfaces pequeñas
- Bajo acoplamiento

## Enunciado
Una aplicación genera informes y puede exportarlos en distintos formatos.

El servicio de alto nivel debe depender de una abstracción (`IExportador`) y no de una implementación concreta.

## Tareas
1. Ejecuta el proyecto con exportación CSV y PDF.
2. Explica por qué `ServicioInformes` no depende de una clase concreta.
3. Añade `ExportadorJson`.
4. Comprueba que no es necesario modificar `ServicioInformes`.


## `ServicioInformes` dependencia
No depende de una clase concreta porque su constructor se basa en la interfaz de IExportador, la cual es implementada
por las distintas clases que usan sus métodos a su manera. En este caso, implementan Exportar cada una. Lo que
no afecta en absoluto a ServicioInformes

## Añadir ExportadorJson
Se ha añadido la clase ExportadorJson. Esta clase implementa IExportador y tiene su propia definición de 
Exportar (Método de la interfaz obligatorio de implementar). Se ha agregado a program.cs un ejemplo para usar
el ExportadorJson sin tener que modificar nada de ServicioInformes