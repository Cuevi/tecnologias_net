using GestorAcademiaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Utils
{
    public class Inicializacion
    {
        public static void DataPersistance()
        {
            AlumnosIniciales();
            CursosIniciales();
            InscripcionesIniciales();
        }

        public static void ImportData()
        {
            importAlumnosData();
            importCursosData();
            importInscripcionesData();
        }
        #region Iniciales

        public static void AlumnosIniciales()
        {
            Alumno alumno1 = new Alumno("David", "david@mail.com", [10, 1, 7, 3, 1]);
            Alumno alumno2 = new Alumno("Manuel", "Manuel@mail.com", [1, 1]);
            Alumno alumno3 = new Alumno("Elena", "Elena@mail.com", []);
            Alumno alumno4 = new Alumno("Jesus", "Jesus@mail.com", [6, 3, 1, 3]);
            Alumno alumno5 = new Alumno("Maria", "Maria@mail.com", [8]);
            List<Alumno> listaAlumnos = new List<Alumno> { alumno1, alumno2, alumno3, alumno4, alumno5 };

            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Alumnos.json";
            string jsonString = JsonSerializer.Serialize(listaAlumnos);
            File.WriteAllText(jsonFilePath, jsonString);
        }
        public static void CursosIniciales()
        {
            Curso curso1 = new Curso("Formacion tecnologias NET", 512);
            Curso curso2 = new Curso("Curso Java", 35);
            Curso curso3 = new Curso("JavaScript", 213);
            Curso curso4 = new Curso("Formacion Aplicaciones Web", 423);
            Curso curso5 = new Curso("Iniciacion al Software", 120);
            List<Curso> listaCursos = new List<Curso> { curso1, curso2, curso3, curso4, curso5 };

            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Cursos.json";
            string jsonString = JsonSerializer.Serialize(listaCursos);
            File.WriteAllText(jsonFilePath, jsonString);
        }
        public static void InscripcionesIniciales()
        {
            Inscripcion inscripion1 = new Inscripcion("david@gmail.com", "Nombre curso1", DateTime.Now, DateTime.Now.AddDays(15));
            Inscripcion inscripion2 = new Inscripcion("manuel@gmail.com", "Nombre curso 3", DateTime.Now, DateTime.Now.AddDays(15));
            Inscripcion inscripion3 = new Inscripcion("maria@gmail.com", "Nombre curso 4", DateTime.Now, DateTime.Now.AddDays(15));
            Inscripcion inscripion4 = new Inscripcion("jesus@gmail.com", "Nombre curso 6", DateTime.Now, DateTime.Now.AddDays(15));
            Inscripcion inscripion5 = new Inscripcion("jesus@gmail.com", "Nombre curso 7", DateTime.Now, DateTime.Now.AddDays(15));
            List<Inscripcion> listaInscripcions = new List<Inscripcion> { inscripion1, inscripion2, inscripion3, inscripion4, inscripion5 };

            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Inscripciones.json";
            string jsonString = JsonSerializer.Serialize(listaInscripcions);
            File.WriteAllText(jsonFilePath, jsonString);
        }
        #endregion
        #region Imports
        public static void importAlumnosData()
        {
            string importedJsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\AlumnosImport.json";
            var dataFromJson = JsonSerializer.Deserialize<List<Alumno>>(File.ReadAllText(importedJsonFilePath));
            List<Alumno> alumnosImportados = new();
            foreach (Alumno item in dataFromJson)
            {
                alumnosImportados.Add(item);
            }
            string importedJsonFilePath2 = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Alumnos.json";
            var dataFromJson2 = JsonSerializer.Deserialize<List<Alumno>>(File.ReadAllText(importedJsonFilePath2));
            List<Alumno> alumnosImportados2 = new();
            foreach (Alumno item in dataFromJson2)
            {
                alumnosImportados2.Add(item);
            }
            var listaUnidaAlumnos = alumnosImportados2.Concat(alumnosImportados);
            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Alumnos.json";
            string jsonString = JsonSerializer.Serialize(listaUnidaAlumnos);
            File.WriteAllText(jsonFilePath, jsonString);
        }

        public static void importCursosData()
        {
            string importedJsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\CursosImport.json";
            var dataFromJson = JsonSerializer.Deserialize<List<Curso>>(File.ReadAllText(importedJsonFilePath));
            List<Curso> cursosImportados = new();
            foreach (Curso item in dataFromJson)
            {
                cursosImportados.Add(item);
            }
            string importedJsonFilePath2 = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Cursos.json";
            var dataFromJson2 = JsonSerializer.Deserialize<List<Curso>>(File.ReadAllText(importedJsonFilePath2));
            List<Curso> cursosImportados2 = new();
            foreach (Curso item in dataFromJson2)
            {
                cursosImportados2.Add(item);
            }
            var listaUnidaCursos = cursosImportados2.Concat(cursosImportados);
            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Cursos.json";
            string jsonString = JsonSerializer.Serialize(listaUnidaCursos);
            File.WriteAllText(jsonFilePath, jsonString);
        }

        public static void importInscripcionesData()
        {
            string importedJsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\InscripcionesImport.json";
            var dataFromJson = JsonSerializer.Deserialize<List<Inscripcion>>(File.ReadAllText(importedJsonFilePath));
            List<Inscripcion> inscripcionesImportados = new();
            foreach (Inscripcion item in dataFromJson)
            {
                inscripcionesImportados.Add(item);
            }
            string importedJsonFilePath2 = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Inscripciones.json";
            var dataFromJson2 = JsonSerializer.Deserialize<List<Inscripcion>>(File.ReadAllText(importedJsonFilePath2));
            List<Inscripcion> inscripcionesImportados2 = new();
            foreach (Inscripcion item in dataFromJson2)
            {
                inscripcionesImportados2.Add(item);
            }
            var listaUnidaInscripciones = inscripcionesImportados2.Concat(inscripcionesImportados);
            string jsonFilePath = "C:\\Users\\usuario_manana\\source\\repos\\Proyectos_net\\proyectos_net\\GestorAcademiaApp\\Persistence\\Inscripciones.json";
            string jsonString = JsonSerializer.Serialize(listaUnidaInscripciones);
            File.WriteAllText(jsonFilePath, jsonString);
        }

        #endregion
    }
}
