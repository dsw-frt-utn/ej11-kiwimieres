using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var alumno1 = new Alumno(15, "Juan", 9);
        var alumno2 = new Alumno(16, "María", 7);
        var alumno3 = new Alumno(17, "Pedro", 8);

        var lista = new CasoList();
        lista.AgregarAlumno(alumno1);
        lista.AgregarAlumno(alumno2);
        lista.AgregarAlumno(alumno3);

        Console.WriteLine("Lista de alumnos:");
        MostrarLista(lista.RetornarLista());
        static void MostrarLista(List<Alumno> lista)
        {
            foreach (var alumno in lista)
            {
                Console.WriteLine(alumno.ToString());
            }
        }
        var alumnoBuscado = lista.BuscarPorNombre("Juan");
        Console.WriteLine($"Alumno buscado por nombre: {alumnoBuscado?.ToString()}");

        var alumnoNoExistente = lista.BuscarPorNombre("Camila");
        Console.WriteLine($"Alumno no existente: {alumnoNoExistente?.ToString() ?? "No existe"}");

        lista.EliminarAlumno(alumno3);
        MostrarLista(lista.RetornarLista());

        lista.EliminarAlumnoPorPosicion(0);
        MostrarLista(lista.RetornarLista());
    }

    

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var alumno1 = new Alumno(15, "Juan", 9);
        var alumno2 = new Alumno(16, "María", 7);
        var alumno3 = new Alumno(17, "Pedro", 8);

        var diccionario = new CasoDictionary();

        diccionario.AgregarAlumno(alumno1);
        diccionario.AgregarAlumno(alumno2);
        diccionario.AgregarAlumno(alumno3);

        static void MostrarDiccionario(Dictionary<int, Alumno> diccionario)
        {
            foreach (var d in diccionario)
            {
                Console.WriteLine($"Clave: {d.Key}, Alumno: {d.Value}");
            }
        }

        MostrarDiccionario(diccionario.RetornarDiccionario());

        var alumnoBuscadoPorClave = diccionario.BuscarAlumno(15);
        Console.WriteLine($"Alumno buscado por clave: {alumnoBuscadoPorClave?.ToString()}");

        var alumnoNoExistentePorClave = diccionario.BuscarAlumno(20);
        Console.WriteLine($"Alumno no existente por clave: {alumnoNoExistentePorClave?.ToString() ?? "No existe"} ");

        diccionario.EliminarAlumno(16);
        MostrarDiccionario(diccionario.RetornarDiccionario());

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        var libro1 = new Libro(10, "El Quijote", 500);
        var libro2 = new Libro(20, "Harry Potter", 300);
        var libro3 = new Libro(30, "El señor de los anillos", 400);
        var libro4 = new Libro(40, "Martin Fierro", 350);

        var lista = new List<Libro> { libro1, libro2, libro3, libro4 };
        //1
        var primerLibro = CasoLinq.GetPrimero(lista);
        Console.WriteLine($"Primer libro: {primerLibro?.ToString()}");
        //2
        var ultimoLibro = CasoLinq.GetUltimo(lista);
        Console.WriteLine($"Último libro: {ultimoLibro?.ToString()}");
        //3
        var totalPrecios = CasoLinq.GetTotalPrecios(lista);
        Console.WriteLine($"Total de precios: {totalPrecios}");
        //4
        var promedioPrecios = CasoLinq.GetPromedioPrecios(lista);
        Console.WriteLine($"Promedio de precios: {promedioPrecios}");
        //5
        var listaOrdenadaPorId = CasoLinq.GetListById(lista);
        Console.WriteLine($"Lista ordenada por ID mayor a 15:");
        static void MostrarLista(List<Libro> lista)
        {
            foreach (var libro in lista)
            {
                Console.WriteLine(libro.ToString());
            }
        }
        MostrarLista(listaOrdenadaPorId);
        //6
        var titulosLibros = CasoLinq.GetLibros(lista);
        Console.WriteLine($"Títulos de los libros:");
        static void MostrarTitulos(List<string> titulos)
        {
            foreach (var titulo in titulos)
            {
                Console.WriteLine(titulo);
            }
        }
        MostrarTitulos(titulosLibros);
        //7
        var libroMayorPrecio = CasoLinq.GetMayorPrecio(lista);
        Console.WriteLine($"Libro con mayor precio: {libroMayorPrecio?.ToString()}");
        //8
        var libroMenorPrecio = CasoLinq.GetMenorPrecio(lista);
        Console.WriteLine($"Libro con menor precio: {libroMenorPrecio?.ToString()}");
        //9
        var librosMayorPromedio = CasoLinq.GetMayorPromedio(lista);
        MostrarLista(librosMayorPromedio);
        //10
        var librosDescendente = CasoLinq.GetLibrosDescendente(lista);
        MostrarLista(librosDescendente);


    }
}
