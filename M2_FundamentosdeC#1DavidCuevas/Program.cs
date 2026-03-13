using System;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace M2_FundamentosdeC_2DavidCuevas
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
                "1. Ficha de usuario\n" +
                "2. Calculadora de suma y resta\n" +
                "3. Conversor de tipos\n" +
                "4.Analizador de número\n" +
                "5. Conversor de edad\n" +
                "6. Calculadora de media de notas\n" +
                "7. Conversor euros a dólares\n" +
                "8. Detector de número par o impar\n" +
                "9. Proyecto: Calculadora profesional básica\n" +
                "10. Proyecto: Gestor de datos personales\n" +
                "0. Salir\n");
            string seleccion = Console.ReadLine() ?? "0";
            checkSeleccionDel1al10(seleccion);
            switch (seleccion)
            {
                case "1":
                    CrearFichaUsuario();
                    continuarOFinalizar();
                    break;
                case "2":
                    CalculadoraDeSUmaYResta();
                    continuarOFinalizar();
                    break;
                case "3":
                    ConversorDeTipos();
                    continuarOFinalizar();
                    break;
                case "4":
                    AnalizadorDeNumeros();
                    continuarOFinalizar();
                    break;
                case "5":
                    ConversorEdad();
                    continuarOFinalizar();
                    break;
                case "6":
                    CalculadoraMediaNotas();
                    continuarOFinalizar();
                    break;
                case "7":
                    ConversorEurosADolares();
                    continuarOFinalizar();
                    break;
                case "8":
                    DetectorDeParEImpar();
                    continuarOFinalizar();
                    break;
                case "9":
                    CalcladoraPersonal();
                    continuarOFinalizar();
                    break;
                case "10":
                    GestorDatosPersonales();
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
        #region Ejercicio1
        static void CrearFichaUsuario()
        {
            Console.Clear();
            Console.WriteLine("1. Fundamentos del Lenguaje C#");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduce nombre de usuario:");
            string nombre = Console.ReadLine() ?? "";
            while (checkNombre(nombre)) 
            {
                Console.WriteLine("Introduzca un nombre valido");
                nombre = Console.ReadLine() ?? ""; 
            } 
            Console.WriteLine("Introduce edad:");
            string edad = Console.ReadLine() ?? "";
            while (checkEdad(edad))
            {
                Console.WriteLine("Introduzca una edad valida");
                edad = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Introduce altura:");
            string altura = Console.ReadLine() ?? "";
            while (checkAltura(altura))
            {
                Console.WriteLine("Introduzca una altura valida");
                altura = Console.ReadLine() ?? "";
            }
            Console.WriteLine("¿Es estudiante el usuario?: (si se deja en blanco se considera que no lo es)");
            string esEstudianteText = Console.ReadLine() ?? "";
            bool esEstudianteFormated = EsEstudianteFormated(esEstudianteText);
            Usuario user = new Usuario(nombre, int.Parse(edad), double.Parse(altura), esEstudianteFormated);
            Console.WriteLine($"Datos del usuario introducidos:\n" +
                $"Nombre: {nombre}, con inicial: {nombre[0]}\nEdad: {edad}\nALtura: {altura}\n¿Es estudiante?: {esEstudianteFormated}");
        }
        static bool checkNombre(string nombre)
        {
            return string.IsNullOrEmpty(nombre);
        }
        static bool checkEdad(string edad)
        {
            bool edadValida = int.TryParse(edad, out int edadInt);
            return !edadValida || edadInt <= 0;
        }
        static bool checkAltura(string altura)
        {
            bool alturaValida = double.TryParse(altura, out double alturaInt);
            return !alturaValida || alturaInt <= 0;
        }
        static bool EsEstudianteFormated(string esEstudiante)
        {
            bool result = false;
            switch (esEstudiante.ToLower())
            {
                case "s":
                    result = true; break;
                case "t":
                    result = true; break;
                case "true":
                    result = true; break;
                case "si":
                    result = true; break;
                default:
                    result = false; break;
            }
            return result;
        }
        #endregion
        #region Ejercicio 2
        static void CalculadoraDeSUmaYResta()
        {
            Console.Clear();
            Console.WriteLine("2. Calculadora de suma y resta");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca el primer numero: (si se deja vacío se considerará 0)");
            string primerNumero = string.IsNullOrEmpty(Console.ReadLine()) ? "0" : Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca el segundo numero:");
            string segundoNumero = Console.ReadLine() ?? "";
            if (checkSegundoNumero(segundoNumero))
            {
                Console.WriteLine("Introduzca un numero valido que no sea 0");
                segundoNumero = Console.ReadLine() ?? "";
            }
            Console.WriteLine($"Primer numero: {primerNumero}, Segundo numero: {segundoNumero}\n" +
                $"Suma: {int.Parse(primerNumero) + int.Parse(segundoNumero)}\n" +
                $"Resta: {int.Parse(primerNumero) - int.Parse(segundoNumero)}\n" +
                $"Multiplicacion: {int.Parse(primerNumero) * int.Parse(segundoNumero)}\n" +
                $"Division: {int.Parse(primerNumero) / int.Parse(segundoNumero)}\n");
        }
        static bool checkSegundoNumero(string numeroTexto)
        {
            bool numeroValido = int.TryParse(numeroTexto, out int numeroInt);
            bool resultado = !numeroValido || numeroInt <= 0;
            if (resultado) Console.WriteLine("Introduzca un numero valido o mayor a cero:");
            return resultado;
        }
        #endregion
        #region Ejercicio 3
        //TODO: Mejorar los while para que sean más optimos
        static void ConversorDeTipos()
        {
            Console.Clear();
            Console.WriteLine("3. Conversor de tipos");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca el primer numero:");
            string textoEnConsola = Console.ReadLine() ?? "";
            bool textoConsolaok = !int.TryParse(textoEnConsola, out int primerInt);
            while(textoConsolaok) 
            { 
                Console.WriteLine("Introduzca un numero entero valido");
                textoEnConsola = Console.ReadLine() ?? "";
                textoConsolaok = !int.TryParse(textoEnConsola, out int primerInt2);
                primerInt = primerInt2;
            }
            Console.WriteLine("Introduzca el segundo numero:");
            string textoEnConsola2 = Console.ReadLine() ?? "";
            bool textoConsola2ok = !double.TryParse(textoEnConsola2.Replace(',', '.'), CultureInfo.InvariantCulture, out double segundoDouble);
            while(textoConsola2ok) 
            { 
                Console.WriteLine("Introduzca un numero real valido");
                textoEnConsola2 = Console.ReadLine() ?? "";
                textoConsola2ok = !double.TryParse(textoEnConsola2.Replace(',', '.'), CultureInfo.InvariantCulture, out double segundoDouble2);
                segundoDouble = segundoDouble2;
            }
            Console.WriteLine($"Primer valor introducido: {primerInt}, Segundo valor introducido: {segundoDouble}\n" +
                $"Conversion de int {primerInt} a double -> {(double)primerInt}\n" +
                $"Conversion de double {segundoDouble} a int -> {(int)segundoDouble}");
        }
        #endregion
        #region Ejercicio 4
        //TODO: Mejorar while
        static void AnalizadorDeNumeros()
        {
            Console.Clear();
            Console.WriteLine("4. Analizador de número");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca un numero entero:");
            string textoEnConsola = Console.ReadLine() ?? "";
            bool textoEnConsolaok = !int.TryParse(textoEnConsola, out int primerInt);
            while (textoEnConsolaok) 
            { 
                Console.WriteLine("Introduzca un numero entero valido");
                textoEnConsola = Console.ReadLine() ?? "";
                textoEnConsolaok = !int.TryParse(textoEnConsola, out int primerInt2);
                primerInt = primerInt2;
            }
            Console.WriteLine($"Numero introducido: {primerInt}\n" +
                $"Es mayor que 0: {primerInt > 0}\n" +
                $"Es menor que 100: {primerInt < 100}\n" +
                $"Es igual a 50: {primerInt == 50}\n" +
                $"Es distinto de 10: {primerInt != 10}\n" +
                $"Es mayor a 0 y menor a 100: {primerInt > 0 && primerInt < 100}\n" +
                $"Es par y multiplo de 3: {primerInt % 2 == 0 && primerInt % 3 == 0}\n");
        }
        #endregion
        #region Ejercicio 5
        static void ConversorEdad()
        {
            Console.Clear();
            Console.WriteLine("5. Conversor de edad");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca su fecha de nacimiento con formato dd/mm/yyyy");
            string textoIntroducido = Console.ReadLine() ?? "";
            DateTime fecha = DateTime.ParseExact(textoIntroducido, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            int anyoDiferencia = DateTime.Now.Year - fecha.Year;
            if (fecha.Date > DateTime.Now.AddYears(-anyoDiferencia)) anyoDiferencia--;
            Console.WriteLine($"Tu fecha de naciemiento es: {fecha} y tu edad es: {anyoDiferencia}");
        }
        #endregion
        #region Ejercicio 6
        static void CalculadoraMediaNotas()
        {
            Console.Clear();
            Console.WriteLine("6. Calculadora de media de notas");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca la primera nota:");
            string texto1 = Console.ReadLine() ?? "";
            bool texto1ok = !double.TryParse(texto1.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota1);
            //TODO; Mejorar esto
            while (texto1ok) 
            { 
                Console.WriteLine("Introduzca una nota correcta");
                texto1 = Console.ReadLine() ?? "";
                texto1ok = !double.TryParse(texto1.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota12);
                nota1 = nota12;
            }
            Console.WriteLine("Introduzca la segunda nota:");
            string texto2 = Console.ReadLine() ?? "";
            bool texto2ok = !double.TryParse(texto2.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota2);
            //TODO: Mejorar
            while (texto2ok)
            { 
                Console.WriteLine("Introduzca una nota correcta");
                texto2 = Console.ReadLine() ?? "";
                texto2ok = !double.TryParse(texto2.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota22);
                nota2 = nota22;
            }
            Console.WriteLine("Introduzca la tercera nota:");
            string texto3 = Console.ReadLine() ?? "";
            bool texto3ok = !double.TryParse(texto3.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota3);
            //TODO: Mejorar
            while (texto3ok) 
            { 
                Console.WriteLine("Introduzca una nota correcta");
                texto3 = Console.ReadLine() ?? "";
                texto3ok = !double.TryParse(texto3.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota32);
                nota3 = nota32;
            }
            Console.WriteLine($"Las notas introducidas son: {nota1}, {nota2} y {nota3}\n" +
                $"La media de las notas es: {(nota1 + nota2 + nota3) / 3:F2}\n" +
                $"¿Está aprobado?: {((nota1 + nota2 + nota3) / 3)>5}");
        }
        #endregion
        #region Ejercicio 7
        static void ConversorEurosADolares()
        {
            Console.Clear();
            Console.WriteLine("7. Conversor euros a dólares");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Conversor de euros a dolares");
            Console.WriteLine("Vamos a suponer que la conversion es 1:1.5 es decir 1 euro son 1,5 dolares");
            Console.WriteLine("Introduzca la cuantía en euros a convertir:");
            string cuantiaTexto = Console.ReadLine() ?? "0";
            bool cuantiaTextook = !double.TryParse(cuantiaTexto.Replace(',', '.'), CultureInfo.InvariantCulture, out double cuantia);
            //TODO: Mejorar
            while (cuantiaTextook) 
            { 
                Console.WriteLine("Introduzca una nota correcta");
                cuantiaTexto = Console.ReadLine() ?? "0";
                cuantiaTextook = !double.TryParse(cuantiaTexto.Replace(',', '.'), CultureInfo.InvariantCulture, out double cuantia2);
                cuantia = cuantia2;
            }
            Console.WriteLine($"Cuantia introducida: {cuantia}€ a un ratio de 1:1.5 son {cuantia*1.5:F2}$");
        }
        #endregion
        #region Ejercicio 8
        static void DetectorDeParEImpar()
        {
            Console.Clear();
            Console.WriteLine("8. Detector de número par o impar");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca un numero para saber si es par o impar:");
            string numeroTexto = Console.ReadLine() ?? "0";
            bool numeroTextook = !int.TryParse(numeroTexto, out int numero);
            while (numeroTextook)
            { 
                Console.WriteLine("Introduzca una nota correcta (Numero entero)");
                numeroTexto = Console.ReadLine() ?? "0";
                numeroTextook = !int.TryParse(numeroTexto, out int numero2);
                numero = numero2;
            }
            string parImpar = numero % 2 == 0 ? "par" : "impar";
            string positivoNegativo = numero < 0 ? "negativo" : "positivo";
            Console.WriteLine($"El número introducido: {numero} es {parImpar} y {positivoNegativo}");
        }
        #endregion
        #region Ejercicio 9
        static void CalcladoraPersonal()
        {
            Console.Clear();
            Console.WriteLine("9. Proyecto: Calculadora profesional básica");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca el primer numero: (si se deja vacío se considerará 0), si no es numero entero volverá a pedirlo234");
            string primerNumero = string.IsNullOrEmpty(Console.ReadLine()) ? "0" : Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca el segundo numero:");
            string segundoNumero = Console.ReadLine() ?? "";
            while (checkSegundoNumero(segundoNumero))
            {
                segundoNumero = Console.ReadLine() ?? "";
            } 
            Console.WriteLine($"Primer numero: {primerNumero}, Segundo numero: {segundoNumero}\n" +
                $"Suma: {int.Parse(primerNumero) + int.Parse(segundoNumero)}\n" +
                $"Resta: {int.Parse(primerNumero) - int.Parse(segundoNumero)}\n" +
                $"Multiplicacion: {int.Parse(primerNumero) * int.Parse(segundoNumero)}\n" +
                $"Division: {int.Parse(primerNumero) / int.Parse(segundoNumero)}\n");
        }
        #endregion
        #region Ejercicio 10
        //TODO: Mejorar proyecto
        static void GestorDatosPersonales()
        {
            Console.Clear();
            Console.WriteLine("10. Proyecto: Gestor de datos personales");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca nombre:");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca edad:");
            string edadTexto = Console.ReadLine() ?? "";
            bool edadTextook = !int.TryParse(edadTexto, out int edad);
            while (edadTextook)
            { 
                Console.WriteLine("Introduczca una edad valida");
                edadTexto = Console.ReadLine() ?? "";
                edadTextook = !int.TryParse(edadTexto, out int edad2);
                edad = edad2;
            }
            Console.WriteLine("Introduzca ciudad:");
            string ciudad = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca salarioMensual:");
            string salarioMensualTexto = Console.ReadLine() ?? "";
            bool salarioMensualTextook = !double.TryParse(salarioMensualTexto, out double salarioMensual);
            while (salarioMensualTextook) 
            {
                Console.WriteLine("Introduzca un Salario Mensual correcto:");
                salarioMensualTexto = Console.ReadLine() ?? "";
                salarioMensualTextook = !double.TryParse(salarioMensualTexto, out double salarioMensual2);
                salarioMensual = salarioMensual2;
            }
            Console.WriteLine("Introduzca año de nacimiento:");
            string nacimientoTexto = Console.ReadLine() ?? "";
            bool nacimientoTextook = !DateTime.TryParse(nacimientoTexto, out DateTime nacimiento);
            while (nacimientoTextook) 
            { 
                Console.WriteLine("Introduzca una fecha correcta con formato dd/MM/yyyy");
                nacimientoTexto = Console.ReadLine() ?? "";
                nacimientoTextook = !DateTime.TryParse(nacimientoTexto, out DateTime nacimiento2);
                nacimiento = nacimiento2;
            }
            Persona persona = new Persona(nombre, edad, ciudad, salarioMensual, nacimiento);
            //Console.WriteLine($"Datos personales introducidos:\n" +
            //    $"Nombre: {persona)}\nEdad: {persona.");
            Console.WriteLine("TODO");
        }
        #endregion
    }
}