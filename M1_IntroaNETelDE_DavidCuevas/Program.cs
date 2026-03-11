namespace M1_IntroaNETelDE_DavidCuevas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GuiaInteracticaPrimerEntornoCSharp();
        }

        #region Ejercicio 1
        static void HolaMundoAmpliado()
        {
            Console.Clear();
            Console.WriteLine("1. Hola Mundo ampliado\n");
            Console.WriteLine("Nombre: David");
            Console.WriteLine("Curso: Tecnologias NET");
            Console.WriteLine("Mensaje: Bienvenido al curso");
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 2
        static void PresentacionPorConsola()
        {
            Console.Clear();
            Console.WriteLine("2. Presentación personal por consola\n");
            Console.WriteLine("Nombre: David");
            Console.WriteLine("Edad: 32");
            Console.WriteLine("Ciudad: Sevilla");
            Console.WriteLine("Aficion: Fubol");
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 3
        static void TablaInformativaTecnologias()
        {
            Console.Clear();
            Console.WriteLine("3. Tabla informativa de tecnologías\n");
            Dictionary<string, string> tecnologiasYDescripcion = new Dictionary<string, string> {
                {"C#", "Se va a utilzar c# como lenguaje" },
                {".NET","Tecnologias NET" },
                {"CLR","Usaremos CLR" },
                {"IL","IL estará en los proyectos" },
                {"JIT","Introducción a JIT" }
            };
            foreach (KeyValuePair<string, string> item in tecnologiasYDescripcion)
            {
                Console.WriteLine($"Nombre: {item.Key}, Descripcion: {item.Value}");
            }
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 4
        static void ComparaticaCSharpYJava()
        {
            Console.Clear();
            Console.WriteLine("4. Comparativa C# vs Java\n");
            Console.WriteLine("Similitudes entre C# y Java");
            Console.WriteLine("1. Orientación a Objetos: Ambos soportan encapsulamiento, herencia, polimorfismo e interfaces");
            Console.WriteLine("2. Sintaxis: La sintaxis es muy similar, lo que facilita el cambio entre ellos. Ambos usan ; para separar instrucciones y {} para definir bloques");
            Console.WriteLine("3. Ejecución: Utilizan compilación Just-in-Time (JIT) y generan código intermedio (Bytecode en Java, MSIL en C#).");
            Console.WriteLine("4. Gestión de Memoria: Ambos cuentan con garbage collector automático.");
            Console.WriteLine("5. Aplicaciones: Son lenguajes versátiles, utilizados para aplicaciones empresariales, de escritorio y web. ");
            Console.WriteLine("\nDiferencias entre C# y Java");
            Console.WriteLine("1. Ecosistema: C# está integrado profundamente con el ecosistema de Microsoft (.NET), mientras que Java es más multiplataforma.");
            Console.WriteLine("2. Concisión: C# tiende a ser menos verboso que Java, a menudo permitiendo escribir menos código para funcionalidades similares.");
            Console.WriteLine("3. Funcionalidades: C# ha evolucionado rápidamente con características modernas (como LINQ) integradas más pronto, mientras Java ha mantenido un ritmo más estable.");
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 5
        static void SimulacionFlujoCompilacion()
        {
            Console.Clear();
            Console.WriteLine("5. Simulador del flujo de compilación\n");
            Console.WriteLine("1 Primero se traduce el código a un lenguaje intermedio");
            Console.WriteLine("2 Luego se convierte en instrucciones que el procesador entiende en tiempo de ejecución");
            Console.WriteLine("3 Cuando inicias la compilación, el compilador de C# realiza los siguientes pasos: ");
            Console.WriteLine("3.1 Análisis y Verificación: Se comprueba la sintaxis, se gestionan las directivas de preprocesamiento y se valida la semántica del código.");
            Console.WriteLine("3.2 Generación de MSIL: Si no hay errores, el código se traduce a Microsoft Intermediate Language (MSIL) o CIL (Common Intermediate Language). Este código es independiente de la CPU.");
            Console.WriteLine("3.3 Creación del Ensamblado: El MSIL se empaqueta junto con metadatos y un manifiesto en un archivo ensamblado con extensión .exe o .dll");
            Console.WriteLine("4 Al ejecutar el programa, interviene el Common Language Runtime (CLR) de .NET: ");
            Console.WriteLine("4.1 Carga del CLR: El sistema operativo inicia el entorno de ejecución de .NET.");
            Console.WriteLine("4.2 Compilación JIT (Just-In-Time): El compilador JIT toma el código MSIL y lo traduce en código máquina nativo específico para la arquitectura del procesador (x64, ARM, etc.) justo antes de que se necesite ejecutar.");
            Console.WriteLine("4.3 Ejecución Gestionada: El CLR supervisa la ejecución, encargándose de tareas como la gestión de memoria (Garbage Collection), el manejo de excepciones y la seguridad de tipos.");
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 6
        static void ExploradorTextualProyectoConsole()
        {
            Console.Clear();
            Console.WriteLine("6. Explorador textual de un proyecto Console\n");
            Console.WriteLine("bin");
            Console.WriteLine("  debug");
            Console.WriteLine("    net6.0");
            Console.WriteLine("obj");
            Console.WriteLine("  debug");
            Console.WriteLine("  project.assets");
            Console.WriteLine("    net6.0");
            Console.WriteLine("Program.cs");
            Console.WriteLine("proyecto_consola.csproj");
            Console.WriteLine("proyecto_consola.sln");
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 7
        static void MenuDeEntornoDeDesarrollo()
        {
            Console.Clear();
            Console.WriteLine("7. Menú “Entorno de desarrollo”\n");
            Console.WriteLine("" +
                "1. ¿Qué es Visual Studio?\n" +
                "2. Elementos principales del IDE\n" +
                "3. Cómo ejecutar con F5 y Ctrl+F5\n" +
                "4. Salir");
            string texto = Console.ReadLine();
            if (texto == "1" || texto == "2" || texto == "3" || texto == "4")
            {
                switch (texto)
                {
                    case "1":
                        Console.WriteLine("Visual studio es un entorno de desarrollo");
                        break;
                    case "2":
                        Console.WriteLine("Descripcion Elementos principales del IDE");
                        break;
                    case "3":
                        Console.WriteLine("Para ejecutar debugeando pulsar F5, para ejecutar sin debug Ctrl + F5");
                        break;
                    case "4":
                        Console.WriteLine("Salir");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"La opcion seleccionada: {texto} no es valida");
                //throw new Exception("Opcion invalida");
            }
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 8
        static void GeneradorDeNormasDeEstilo()
        {
            Console.Clear();
            Console.WriteLine("8. Generador de normas de estilo\n");
            Console.WriteLine("" +
                           "1. Ejemplos de recomendaciones de nombres de clase\n" +
                           "2. Ejemplos de recomendaciones de nombres de metodos\n" +
                           "3. Ejemplos de recomendaciones de nombres de variables\n" +
                           "4. Ejemplos de recomendaciones de comentarios");
            string texto = Console.ReadLine();
            if (texto == "1" || texto == "2" || texto == "3" || texto == "4")
            {
                switch (texto)
                {
                    case "1":
                        Console.WriteLine("Ejemplos de clase: Libro, Persona, Profesor");
                        break;
                    case "2":
                        Console.WriteLine("Ejemplos de metodos: CalcularEdad, DescargarDocumento, FormatearTexto");
                        break;
                    case "3":
                        Console.WriteLine("Ejemplos de variables: persona, textoSinFormato, edadMediaDeClase");
                        break;
                    case "4":
                        Console.WriteLine("Para comentar código usar // al comienzo de la linea o /* y */ al" +
                            "comentar bloques grandes de codigo en varias lineas o una misma linea");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"La opcion seleccionada: {texto} no es valida, por favor, seleccione otra opcion");
                GeneradorDeNormasDeEstilo();
            }
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 9
        static void AsistenteInstalacionVisualStudio()
        {
            Console.Clear();
            Console.WriteLine("9. Proyecto: Asistente de instalación de Visual Studio”\n");
            Console.WriteLine("Asistente instalacion Visual Studio”\n");
            Console.WriteLine("Paso 1: Compruebe su sistema operativo, tiene que ser Windwos 10/11 actualizado, luego pulse ENTER”\n");
            Console.ReadLine();
            Console.WriteLine("Paso 2: Compruebe que tiene almenos 8Gb de RAM utiles, luego pulse Enter”\n");
            Console.ReadLine();
            Console.WriteLine("Pase 3: Seleccionar cargas de trabajo, luego pulse ENTER”\n");
            Console.ReadLine();
            Console.WriteLine("Paso 4: Instale el SDK más reciente para .NET, luego pulse ENTER”\n");
            Console.ReadLine();
            Console.WriteLine("Paso 5: Abra Visual Studio Code, luego pulse ENTER para cerrar el asistente”\n");
            Console.ReadLine();
            Console.WriteLine("----------------------------");
        }
        #endregion
        #region Ejercicio 10
        static void GuiaInteracticaPrimerEntornoCSharp()
        {
            Console.Clear();
            Console.WriteLine("10. Proyecto: Guía interactiva “Mi primer entorno C#\n");
            Console.WriteLine("" +
                "1. Hola Mundo ampliado\n" +
                "2. Presentación personal\n" +
                "3. Tabla tecnologías .NET\n" +
                "4. Comparativa C# vs Java\n" +
                "5. Flujo de compilación\n" +
                "6. Estructura de proyecto\n" +
                "7. Entorno de desarrollo\n" +
                "8. Normas de estilo\n" +
                "9. Asistente instalación Visual Studio\n" +
                "10. Guía interactiva C#\n" +
                "0. Salir\n");
            string seleccion = Console.ReadLine() ?? "0";
            checkSeleccionDel1al10(seleccion);
            switch (seleccion)
            {
                case "1":
                    HolaMundoAmpliado();
                    continuarOFinalizar();
                    break;
                case "2":
                    PresentacionPorConsola();
                    continuarOFinalizar();
                    break;
                case "3":
                    TablaInformativaTecnologias();
                    continuarOFinalizar();
                    break;
                case "4":
                    ComparaticaCSharpYJava();
                    continuarOFinalizar();
                    break;
                case "5":
                    SimulacionFlujoCompilacion();
                    continuarOFinalizar();
                    break;
                case "6":
                    ExploradorTextualProyectoConsole();
                    continuarOFinalizar();
                    break;
                case "7":
                    MenuDeEntornoDeDesarrollo();
                    continuarOFinalizar();
                    break;
                case "8":
                    GeneradorDeNormasDeEstilo();
                    continuarOFinalizar();
                    break;
                case "9":
                    AsistenteInstalacionVisualStudio();
                    continuarOFinalizar();
                    break;
                case "10":
                    Console.WriteLine("Ya está en el menú interactivo de C#, selecione otra opción, por favor");
                    GuiaInteracticaPrimerEntornoCSharp();
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
                GuiaInteracticaPrimerEntornoCSharp();
            }
        }
        static void continuarOFinalizar()
        {
            Console.WriteLine("¿Desea elegir otra opcion? Responda s/n");
            string continuacion = (Console.ReadLine() ?? "n").ToLower();
            if(continuacion != "s" &&  continuacion != "n")
            {
                Console.WriteLine("Opcion no valida: introduzca s o n");
                continuarOFinalizar();
                
            }
            else 
            {
                if (continuacion == "s")
                {
                    Console.Clear();
                    GuiaInteracticaPrimerEntornoCSharp();
                }
            }

        }
        #endregion
    }
}