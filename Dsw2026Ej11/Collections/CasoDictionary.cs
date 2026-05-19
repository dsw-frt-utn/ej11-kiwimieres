using Dsw2026Ej11.Domain;
using System.Reflection.Metadata.Ecma335;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno//
//Incluir un método para agregar un alumno al diccionario//
//Incluir un método para buscar un alumno utilizando la clave//
//Incluir un método para retornar el diccionario//
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int,Alumno> _alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumnoNuevo)
    {
        _alumnos.Add(alumnoNuevo.Id, alumnoNuevo);
    }

    public Alumno? buscarAlumno(int clave)
    {
        if (_alumnos.ContainsKey(clave))
        {
            return _alumnos[clave];
        }

        return null;
    }
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _alumnos;
    }
    
    public void EliminarAlumno(int clave)
    {
        _alumnos.Remove(clave);
    }
}
