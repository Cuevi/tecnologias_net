using System;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
        IntroduccionNombre:
            Console.WriteLine("Introduce nombre de usuario:");
            string nombre = Console.ReadLine() ?? "";
            if (checkNombre(nombre)) goto IntroduccionNombre;
            IntroduccionEdad:
            Console.WriteLine("Introduce nombre edad:");
            string edad = Console.ReadLine() ?? "";
            if (checkEdad(edad)) goto IntroduccionEdad;
            IntroduccionAltura:
            Console.WriteLine("Introduce altura:");
            string altura = Console.ReadLine() ?? "";
            if (checkAltura(altura)) goto IntroduccionAltura;
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
        IntroducirSegundo:
            string segundoNumero = Console.ReadLine() ?? "";
            if (checkSegundoNumero(segundoNumero)) goto IntroducirSegundo;
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
        static void ConversorDeTipos()
        {
            Console.Clear();
            Console.WriteLine("3. Conversor de tipos");
            Console.WriteLine("------------------------------");
        IntroducirPrimerNumero:
            Console.WriteLine("Introduzca el primer numero:");
            string textoEnConsola = Console.ReadLine() ?? "";
            if (!int.TryParse(textoEnConsola, out int primerInt)) { Console.WriteLine("Introduzca un numero entero valido"); goto IntroducirPrimerNumero; }
        IntroducirSegundoNumero:
            Console.WriteLine("Introduzca el segundo numero:");
            string textoEnConsola2 = Console.ReadLine() ?? "";
            if (!double.TryParse(textoEnConsola2.Replace(',', '.'), CultureInfo.InvariantCulture, out double segundoDouble)) { Console.WriteLine("Introduzca un numero real valido"); goto IntroducirSegundoNumero; }
            Console.WriteLine($"Primer valor introducido: {primerInt}, Segundo valor introducido: {segundoDouble}\n" +
                $"Conversion de int {primerInt} a double -> {(double)primerInt}\n" +
                $"Conversion de double {segundoDouble} a int -> {(int)segundoDouble}");
        }
        #endregion
        #region Ejercicio 4
        static void AnalizadorDeNumeros()
        {
            Console.Clear();
            Console.WriteLine("4. Analizador de número");
            Console.WriteLine("------------------------------");
        IntroducirPrimerNumero:
            Console.WriteLine("Introduzca un numero entero:");
            string textoEnConsola = Console.ReadLine() ?? "";
            if (!int.TryParse(textoEnConsola, out int primerInt)) { Console.WriteLine("Introduzca un numero entero valido"); goto IntroducirPrimerNumero; }
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
            DateTime fecha = DateTime.ParseExact(textoIntroducido, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
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
        IntroducirPrimeraNota:
            Console.WriteLine("Introduzca la primera nota:");
            string texto1 = Console.ReadLine() ?? "";
            if (!double.TryParse(texto1.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota1)) { Console.WriteLine("Introduzca una nota correcta"); goto IntroducirPrimeraNota; }
        IntroducirSegundaNota:
            Console.WriteLine("Introduzca la segunda nota:");
            string texto2 = Console.ReadLine() ?? "";
            if (!double.TryParse(texto2.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota2)) { Console.WriteLine("Introduzca una nota correcta"); goto IntroducirSegundaNota; }
        IntroducirTercera:
            Console.WriteLine("Introduzca la tercera nota:");
            string texto3 = Console.ReadLine() ?? "";
            if (!double.TryParse(texto3.Replace(',', '.'), CultureInfo.InvariantCulture, out double nota3)) { Console.WriteLine("Introduzca una nota correcta"); goto IntroducirTercera; }
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
        IntroducirEuros:
            string cuantiaTexto = Console.ReadLine() ?? "0";
            if (!double.TryParse(cuantiaTexto.Replace(',', '.'), CultureInfo.InvariantCulture, out double cuantia)) { Console.WriteLine("Introduzca una nota correcta"); goto IntroducirEuros; }
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
        IntroducirNumero:
            string numeroTexto = Console.ReadLine() ?? "0";
            if (!int.TryParse(numeroTexto, out int numero)) { Console.WriteLine("Introduzca una nota correcta"); goto IntroducirNumero; }
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
            Console.WriteLine("Introduzca el primer numero: (si se deja vacío se considerará 0)");
            string primerNumero = string.IsNullOrEmpty(Console.ReadLine()) ? "0" : Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca el segundo numero:");
        IntroducirSegundo:
            string segundoNumero = Console.ReadLine() ?? "";
            if (checkSegundoNumero(segundoNumero)) goto IntroducirSegundo;
            Console.WriteLine($"Primer numero: {primerNumero}, Segundo numero: {segundoNumero}\n" +
                $"Suma: {int.Parse(primerNumero) + int.Parse(segundoNumero)}\n" +
                $"Resta: {int.Parse(primerNumero) - int.Parse(segundoNumero)}\n" +
                $"Multiplicacion: {int.Parse(primerNumero) * int.Parse(segundoNumero)}\n" +
                $"Division: {int.Parse(primerNumero) / int.Parse(segundoNumero)}\n");
        }
        #endregion
        #region Ejercicio 10
        static void GestorDatosPersonales()
        {
            Console.Clear();
            Console.WriteLine("10. Proyecto: Gestor de datos personales");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Introduzca nombre:");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca edad:");
        IntroducirEdad:
            string edadTexto = Console.ReadLine() ?? "";
            if(!int.TryParse(edadTexto, out int edad)){ Console.WriteLine("Introduczca una edad valida"); goto IntroducirEdad;}
            Console.WriteLine("Introduzca ciudad:");
            string ciudad = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca salarioMensual:");
        IntroducirSalarioMensual:
            string salarioMensualTexto = Console.ReadLine() ?? "";
            if(!double.TryParse(salarioMensualTexto, out double salarioMensual)) { Console.WriteLine("Introduzca un Salario Mensual correcto:"); goto IntroducirSalarioMensual; }
            Console.WriteLine("Introduzca año de nacimiento:");
        IntroducirNacimiento:
            string nacimientoTexto = Console.ReadLine() ?? "";
            if (!DateTime.TryParse(nacimientoTexto, out DateTime nacimiento)) { Console.WriteLine("Introduzca una fecha correcta con formato dd/MM/yyyy"); goto IntroducirNacimiento; }
            Persona persona = new Persona(nombre, edad, ciudad, salarioMensual, nacimiento);
            //Console.WriteLine($"Datos personales introducidos:\n" +
            //    $"Nombre: {persona)}\nEdad: {persona.");
            Console.WriteLine("POR TERMINAR");
        }
        #endregion
    }
}