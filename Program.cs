using System;
using System.Linq;
using peliculasinfo.application;
using peliculasinfo.core;

public class Program
{
    public static void Main(string[] args)
    {
        IConsultarPeliculas consultarPeliculas = new ConsultarPeliculas();

        Console.WriteLine("Todas las peliculas:");
        var todas = consultarPeliculas.Ejecutar();
        todas.ForEach(p => Console.WriteLine($"- {p.Nombre}"));

        Console.WriteLine("\nPeliculas de Accion:");
        IConsultarPeliculasAccion consultarPeliculasAccion = new ConsultarPeliculasAccion(consultarPeliculas);
        var accion = consultarPeliculasAccion.Ejecutar();
        accion.ForEach(p => Console.WriteLine($"- {p.Nombre}"));

        Console.WriteLine("\nActores en peliculas de terror:");
        IConsultarActoresPeliculasTerror consultarActoresPeliculasTerror = new ConsultarActoresPeliculasTerror(consultarPeliculas);
        var actoresTerror = consultarActoresPeliculasTerror.Ejecutar();
        actoresTerror.ForEach(a => Console.WriteLine($"- {a.Nombre}"));

        Console.WriteLine("\nActores Australianos:");
        IConsultarActoresAustralianos consultarActoresAustralianos = new ConsultarActoresAustralianos(consultarPeliculas);
        var actoresAustralianos = consultarActoresAustralianos.Ejecutar();
        actoresAustralianos.ForEach(a => Console.WriteLine($"- {a.Nombre}"));

        Console.WriteLine("\nPeliculas con calificacion perfecta:");
        IConsultarPeliculasCalificacionPerfecta consultarPeliculasCalificacionPerfecta = new ConsultarPeliculasCalificacionPerfecta(consultarPeliculas);
        var calificacionPerfecta = consultarPeliculasCalificacionPerfecta.Ejecutar();
        calificacionPerfecta.ForEach(p => Console.WriteLine($"- {p.Nombre}"));
    }
}