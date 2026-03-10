# Ejercicio 2 – Tarifas de envío (SOLID + OCP) - SOLUCION

## Identificacion por qué está cerrado a modificación y abierto a extensión.
Está cerrado a modificación porque las funciones básicas están implementadas de una forma sencilla que hace que
funcione el proyecto, haciendo que cualquier modificación de este código provocará que algo deje de funcionar. 
Por eso no está abierto a modificación.
Y está abierto a extensión porque podemos añadir nuevas funcionalidades en las clases sin provocar que se
rompa nada que ya esté funcionando correctamente, por lo que tenemos una base solida que no falla.

## Añadida clase `EnvioRecogidaTienda`
La clase EnvioRecogidaTienda se ha implementado en base a las clases hermanas, el costo de la tarifa será 0
Necesitamos que EnvioRecogidaTienda tambien implmente el método CalcularCoste(importe)

## No hace falta ningun cambio en program.cs
