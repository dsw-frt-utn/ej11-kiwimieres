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
    public List<Alumno> listaAlumno = new List<Alumno>();

    public void AgregarAlumno(Alumno alumnoNuevo)
    {
        listaAlumno.Add(alumnoNuevo);

    }

    public List<Alumno> RetornarLista()
    {
        return listaAlumno;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        foreach(Alumno alumno in listaAlumno)
        {
            if(alumno.Nombre == nombre)
            {
                return alumno;
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno alumnoABorrar)
    {
        foreach (Alumno alumno in listaAlumno)
        {
            if (alumno == alumnoABorrar)
            {
                listaAlumno.Remove(alumno);
            }
        }
        
    }

    public void EliminarAlumnoPorPosicion(int posicionABorrar)
    {
        foreach (Alumno alumno in listaAlumno)
        {
            if (alumno.Id == posicionABorrar)
            {
                listaAlumno.Remove(alumno);
            }
        }

    }


}
