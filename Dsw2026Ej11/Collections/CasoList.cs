using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)//
//Incluir un método para agregar alumnos a la lista//
//Incluir un método para retornar la lista//
//Incluir un método para buscar un alumno por nombre//
//Incluir un método para eliminar un alumno (debe recibir un alumno)//
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _listaAlumno = new List<Alumno>();

    public void AgregarAlumno(Alumno alumnoNuevo)
    {
        _listaAlumno.Add(alumnoNuevo);

    }

    public List<Alumno> RetornarLista()
    {
        return _listaAlumno;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return _listaAlumno.Find(a => a.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumnoABorrar)
    {
        _listaAlumno.Remove(alumnoABorrar);
        
    }

    public void EliminarAlumnoPorPosicion(int posicionABorrar)
    {
        _listaAlumno.RemoveAt(posicionABorrar);

    }


}
