using System;
using System.Globalization;

namespace FundamentosdeC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");
            SeleccionadorEjercicio();

        }
        #region SeleccionadorEjercicio
        static void SeleccionadorEjercicio()
        {
            Console.Clear();
            Console.WriteLine("Menú de ejercicios disponibles\n");
            Console.WriteLine("" +
                "1. Presentación con concatenación tradicional\n" +
                "2. Presentación con interpolación\n" +
                "3. Error clásico de concatenación\n" +
                "4. Formato de precio\n" +
                "5. Formato de porcentaje\n" +
                "6. Informe alineado en consola\n" +
                "7. Formato compuesto clásico\n" +
                "8. Proyecto: Ticket de compra\n" +
                "9. Proyecto: Nómina básica\n" +
                "10. Proyecto: Generador de informe personal formateado\n" +
                "0. Salir\n");
            string seleccion = Console.ReadLine() ?? "0";
            checkSeleccionDel1al10(seleccion);
            switch (seleccion)
            {
                case "1":
                    PresentacionConcatenada();
                    continuarOFinalizar();
                    break;
                case "2":
                    PresentacionConInterpolacion();
                    continuarOFinalizar();
                    break;
                case "3":
                    ErrorClasicoConcatenacion();
                    continuarOFinalizar();
                    break;
                case "4":
                    FormatoDePrecio();
                    continuarOFinalizar();
                    break;
                case "5":
                    FormatoDePorcentaje();
                    continuarOFinalizar();
                    break;
                case "6":
                    InformeAlineadoEnConsola();
                    continuarOFinalizar();
                    break;
                case "7":
                    FormatoCompuestoClasico();
                    continuarOFinalizar();
                    break;
                case "8":
                    ProyectoTicketsCompra();
                    continuarOFinalizar();
                    break;
                case "9":
                    NominaBasica();
                    continuarOFinalizar();
                    break;
                case "10":
                    GeneradorInformePersonal();
                    continuarOFinalizar();
                    break;
            }

        }
        static void checkSeleccionDel1al10(string texto)
        {
            List<string> opcionesValidas = new List<string>
            {
                "1","2","3","4","5","6","7","8","9","10","0"
            };
            if (!opcionesValidas.Contains(texto))
            {
                Console.WriteLine($"La opcion {texto} no es valida, por favor, seleccione otra");
                SeleccionadorEjercicio();
            }
        }
        static void continuarOFinalizar()
        {
            Console.WriteLine("¿Desea elegir otra opcion? Responda s/n");
            string continuacion = (Console.ReadLine() ?? "n").ToLower();
            if (continuacion != "s" && continuacion != "n")
            {
                Console.WriteLine("Opcion no valida: introduzca s o n");
                continuarOFinalizar();

            }
            else
            {
                if (continuacion == "s")
                {
                    Console.Clear();
                    SeleccionadorEjercicio();
                }
            }

        }
        #endregion
        #region Ejercicio 1
        static void PresentacionConcatenada()
        {
            Console.Clear();
            Console.WriteLine("1. Presentación con concatenación tradicional");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduzca su nombre:");
            string nombre = Console.ReadLine() ?? "";
            bool nombreok = string.IsNullOrEmpty(nombre);
            while (nombreok)
            {
                Console.WriteLine("Introduzca un nombre:");
                nombre = Console.ReadLine() ?? "";
                nombreok = string.IsNullOrEmpty(nombre);
            }
            Console.WriteLine("Introduzca su edad:");
            string nombreEdad = Console.ReadLine() ?? "";
            bool nombreEdadok = !int.TryParse(nombreEdad, out int edad);
            while (nombreEdadok)
            {
                Console.WriteLine("Introduzca una edad correcta:");
                nombreEdad = Console.ReadLine() ?? "";
                nombreEdadok = !int.TryParse(nombreEdad, out int edad2);
                edad = edad2;
            }
            Console.WriteLine("Introduzca su ciudad:");
            string nombreCiudad = Console.ReadLine() ?? "";
            bool nombreCiudadok = string.IsNullOrEmpty(nombreCiudad);
            while (nombreCiudadok)
            {
                Console.WriteLine("Introduzca un nombre de ciudad valido:");
                nombreCiudad = Console.ReadLine() ?? "";
                nombreCiudadok = string.IsNullOrEmpty(nombreCiudad);
            }
            Console.WriteLine("Los datos introducidos son nombre: " + nombre + ", edad: " + edad + ", ciudad: " + nombreCiudad); 
        }
        #endregion
        #region Ejercicio 2
        static void PresentacionConInterpolacion()
        {
            Console.Clear();
            Console.WriteLine("2. Presentación con interpolación");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduzca su nombre:");
            string nombre = Console.ReadLine() ?? "";
            bool nombreok = string.IsNullOrEmpty(nombre);
            while (nombreok)
            {
                Console.WriteLine("Introduzca un nombre:");
                nombre = Console.ReadLine() ?? "";
                nombreok = string.IsNullOrEmpty(nombre);
            }
            Console.WriteLine("Introduzca su edad:");
            string nombreEdad = Console.ReadLine() ?? "";
            bool nombreEdadok = !int.TryParse(nombreEdad, out int edad);
            while (nombreEdadok)
            {
                Console.WriteLine("Introduzca una edad correcta:");
                nombreEdad = Console.ReadLine() ?? "";
                nombreEdadok = !int.TryParse(nombreEdad, out int edad2);
                edad = edad2;
            }
            Console.WriteLine("Introduzca su ciudad:");
            string nombreCiudad = Console.ReadLine() ?? "";
            bool nombreCiudadok = string.IsNullOrEmpty(nombreCiudad);
            while (nombreCiudadok)
            {
                Console.WriteLine("Introduzca un nombre de ciudad valido:");
                nombreCiudad = Console.ReadLine() ?? "";
                nombreCiudadok = string.IsNullOrEmpty(nombreCiudad);
            }
            Console.WriteLine($"Los datos introducidos son nombre: {nombre} , edad: {edad} , ciudad: {nombreCiudad}");
        }
        #endregion
        #region Ejercicio 3
        static void ErrorClasicoConcatenacion()
        {
            Console.Clear();
            Console.WriteLine("3. Error clásico de concatenación");
            Console.WriteLine("----------------------");
            int a = 5, b = 3;
            Console.WriteLine("Cadena con concatenacion, numeros int a = 5 e int b = 3");
            Console.WriteLine("La suma es: " + a + b);
            Console.WriteLine("Cadena con interpolacion");
            Console.WriteLine($"La suma es: {a + b}");
            Console.WriteLine($"Los textos son distintos porque la concatenación lee los int y los imprime como string," +
                $"sin embargo, con interpolacion puedes realizar operaciones con variables y luego se imprimen por consola");
        }
        #endregion
        #region Ejercicio 4
        static void FormatoDePrecio()
        {
            Console.Clear();
            Console.WriteLine("4. Formato de precio");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduzca un numero:");
            string numeroDecimalTexto = Console.ReadLine() ?? "";
            bool numeroDecimalTextook = decimal.TryParse(numeroDecimalTexto.Replace('.', ','), out decimal numeroDecimal);
            while (!numeroDecimalTextook)
            {
                Console.WriteLine("Introduzca un numero correcto.");
                numeroDecimalTexto = Console.ReadLine() ?? "";
                numeroDecimalTextook = decimal.TryParse(numeroDecimalTexto.Replace('.', ','), out decimal numeroDecimal2);
                numeroDecimal = numeroDecimal2;
            }
            Console.WriteLine($"El decimal sin formato: {numeroDecimal}\n" +
                $"Numero decimal con dos decimales: {numeroDecimal:F2}\n" +
                $"Numero decimal como moneda: {numeroDecimal:C}");

        }
        #endregion
        #region Ejercicio 5
        static void FormatoDePorcentaje()
        {
            Console.Clear();
            Console.WriteLine("5. Formato de porcentaje");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduzca un numero:");
            string valorTexto = Console.ReadLine() ?? "";
            bool valorTextook = decimal.TryParse(valorTexto.Replace('.', ','), out decimal valor);
            while (!valorTextook) 
            {
                Console.WriteLine("Introduzca un valor correcto:");
                valorTexto = Console.ReadLine() ?? "";
                valorTextook = decimal.TryParse(valorTexto.Replace('.', ','), out decimal valor2);
                valor = valor2;
            }
            Console.WriteLine("Introduzca un descuento que quiera aplicar Ej 0,15:");
            string descuentoTexto = Console.ReadLine() ?? "";
            bool descuentoTextook = decimal.TryParse(descuentoTexto.Replace('.', ','), out decimal descuento) &&
                descuento < 1 && descuento > 0;
            while (!descuentoTextook)
            {
                Console.WriteLine("Introduzca un descuento correcto (0,15):");
                descuentoTexto = Console.ReadLine() ?? "";
                descuentoTextook = decimal.TryParse(descuentoTexto.Replace('.', ','), out decimal descuento2) &&
                descuento < 1 && descuento > 0;
                descuento = descuento2;
            }
            Console.WriteLine($"El valor introducido es: {valor} y el descuento: {descuento:P}\n" +
                $"El total con el descuento aplicado es: {valor*(1-descuento)}");
        }
        #endregion
        #region Ejercicio 6
        static void InformeAlineadoEnConsola()
        {
            Console.Clear();
            Console.WriteLine("6. Informe alineado en consola");
            Console.WriteLine("----------------------");
            Console.WriteLine("Productos que tenemos y sus precios");
            Console.WriteLine("Producto\t|\tPrecios\r\n" +
                "----------------------------------\r\nPan\t\t|\t0,50€\r\n" +
                "----------------------------------\r\nLeche\t\t|\t0,89€\r\n" +
                "----------------------------------\r\nHuevos\t\t|\t1.64€\t\t");
            
        }
        #endregion
        #region Ejercicio 7
        static void FormatoCompuestoClasico()
        {
            Console.Clear();
            Console.WriteLine("7. Formato compuesto clásico");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduce un nombre:");
            string nombre = Console.ReadLine() ?? "";
            bool nombreok = string.IsNullOrEmpty(nombre);
            while (nombreok)
            {
                Console.WriteLine("Introduzca un nombre:");
                nombre = Console.ReadLine() ?? "";
                nombreok = string.IsNullOrEmpty(nombre);
            }
            Console.WriteLine("Introduzca un salario:");
            string salarioTexto = Console.ReadLine() ?? "";
            bool salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario);
            while (!salarioTextook)
            {
                Console.WriteLine("Introduzca un salario valido:");
                salarioTexto = Console.ReadLine() ?? "";
                salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario2);
                salario = salario2;
            }
            Console.WriteLine("Nombre: {0}, Salario: {1}");
            Console.WriteLine("Nombre: {0}, Salario: {1}", nombre, salario);
        }
        #endregion
        #region Ejercicio 8
        static void ProyectoTicketsCompra()
        {
            Console.Clear();
            Console.WriteLine("8. Proyecto: Ticket de compra");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduce un nombre de producto:");
            string nombreProducto = Console.ReadLine() ?? "";
            bool nombreProductook = string.IsNullOrEmpty(nombreProducto);
            while (nombreProductook)
            {
                Console.WriteLine("Introduzca un nombre de producto:");
                nombreProducto = Console.ReadLine() ?? "";
                nombreProductook = string.IsNullOrEmpty(nombreProducto);
            }
            Console.WriteLine("Introduzca una cantidad:");
            string cantidadTexto = Console.ReadLine() ?? "";
            bool cantidadTextook = int.TryParse(cantidadTexto.Replace('.', ','), out int cantidad);
            while (!cantidadTextook)
            {
                Console.WriteLine("Introduzca un cantidad valida:");
                cantidadTexto = Console.ReadLine() ?? "";
                cantidadTextook = int.TryParse(cantidadTexto.Replace('.', ','), out int cantidad2);
                cantidad = cantidad2;
            }
            Console.WriteLine("Introduzca un precio unitario:");
            string precioTexto = Console.ReadLine() ?? "";
            bool precioTextook = double.TryParse(precioTexto, out double precio);
            while (!precioTextook)
            {
                Console.WriteLine("Introduzca un precio valido:");
                precioTexto = Console.ReadLine() ?? "";
                precioTextook = double.TryParse(precioTexto, out double precio2);
                precio = precio2;
            }   
            Console.WriteLine("Ticket de compra");
            Console.WriteLine($"Ticket de compra\r\n-------------------------------------------------------------------\r\n" +
                $"Producto\t|\tCantidad\t|\tSubtotal(IVA)\r\n" +
                $"-------------------------------------------------------------------\n" +
                $"{nombreProducto}\t\t|\t{cantidad,5}\t\t|\t{cantidad}*{precio:C2}(7%)\r\n" +
                $"{nombreProducto}\t\t|\t{cantidad,5}\t\t|\t{cantidad}*{precio:C2}(7%)\r\n" +
                $"-------------------------------------------------------------------\n" +
                $"Total\t\t|\t\t\t|{cantidad*precio*1.07*2
                ,17:C2}");
        }
        #endregion
        #region Ejercicio 9
        static void NominaBasica()
        {
            Console.Clear();
            Console.WriteLine("9. Proyecto: Nómina básica");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduzca un salario:");
            string salarioTexto = Console.ReadLine() ?? "";
            bool salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario);
            while (!salarioTextook)
            {
                Console.WriteLine("Introduzca un salario valido:");
                salarioTexto = Console.ReadLine() ?? "";
                salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario2);
                salario = salario2;
            }
            Console.WriteLine("Introduzca una retencion:");
            string retencionTexto = Console.ReadLine() ?? "";
            bool retencionTextook = int.TryParse(retencionTexto, out int retencion) && 
                retencion > 0 && retencion < 100;
            while (!retencionTextook)
            {
                Console.WriteLine("Introduzca una retencion valida (Entre 1 y 99):");
                retencionTexto = Console.ReadLine() ?? "";
                retencionTextook = int.TryParse(retencionTexto, out int retencion2) &&
                retencion > 0 && retencion < 100;
                retencion = retencion2;
            }
            Console.WriteLine($"Su salario es: {salario} y su retencion es {retencion}\n" +
                $"por lo tanto tiene un sueldo neto de: {salario * 100 - retencion}");
        }
        #endregion
        #region Ejercicio 10
        static void GeneradorInformePersonal()
        {
            Console.Clear();
            Console.WriteLine("10. Proyecto: Generador de informe personal formateado");
            Console.WriteLine("----------------------");
            Console.WriteLine("Introduce un nombre:");
            string nombre = Console.ReadLine() ?? "";
            bool nombreok = string.IsNullOrEmpty(nombre);
            while (nombreok)
            {
                Console.WriteLine("Introduzca un nombre:");
                nombre = Console.ReadLine() ?? "";
                nombreok = string.IsNullOrEmpty(nombre);
            }
            Console.WriteLine("Introduzca su edad:");
            string edadTexto = Console.ReadLine() ?? "";
            bool edadTextook = !int.TryParse(edadTexto, out int edad);
            while (edadTextook)
            {
                Console.WriteLine("Introduzca una edad correcta:");
                edadTexto = Console.ReadLine() ?? "";
                edadTextook = !int.TryParse(edadTexto, out int edad2);
                edad = edad2;
            }
            Console.WriteLine("Introduzca un salario:");
            string salarioTexto = Console.ReadLine() ?? "";
            bool salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario);
            while (!salarioTextook)
            {
                Console.WriteLine("Introduzca un salario valido:");
                salarioTexto = Console.ReadLine() ?? "";
                salarioTextook = double.TryParse(salarioTexto.Replace('.', ','), out double salario2);
                salario = salario2;
            }
            Console.WriteLine("Introduzca un porcentaje de ahorro:");
            string ahorroTexto = Console.ReadLine() ?? "";
            bool ahorroTextook = double.TryParse(ahorroTexto.Replace('.', ','), out double ahorro) &&
                ahorro > 0 && ahorro <1;
            while (!ahorroTextook)
            {
                //TODO: Checkear que a veces da error al meter el % de ahorro
                Console.WriteLine("Introduzca un porcentaje de ahorro valido (Entre 0 y 0,99:");
                ahorroTexto = Console.ReadLine() ?? "";
                ahorroTextook = double.TryParse(ahorroTexto.Replace('.',','), out double ahorro2) &&
                ahorro > 0 && ahorro < 1;
                ahorro = ahorro2;
            }
            Console.WriteLine("Introduzca su fecha de nacimiento con formato dd/mm/yyyy");
            string textoIntroducido = Console.ReadLine() ?? "";
            //TODO: Gestionar cuando se mete una fecha mal
            DateTime fecha = DateTime.ParseExact(textoIntroducido, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Concatenación: El nombre es "+ nombre + ", la edad es "+ edad+ " y la fecha de nacimiento "+ fecha);
            Console.WriteLine($"Interpolación + porcentaje: El ahorro es de {ahorro:P2}, y su salario de {salario:C2}");
        }
        #endregion

    }
}