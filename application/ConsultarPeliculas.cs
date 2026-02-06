using peliculasinfo.core;
using System.Collections.Generic;

namespace peliculasinfo.application
{
    public interface IConsultarPeliculas
    {
        List<Pelicula> Ejecutar();
    }

    public class ConsultarPeliculas : IConsultarPeliculas
    {
        public List<Pelicula> Ejecutar()
        {
            // Sample Data
            var actores1 = new List<Actor>
            {
                new Actor { Nombre = "Actor 1", Pais = "USA", Genero = "Masculino", Edad = 40 },
                new Actor { Nombre = "Actor 2", Pais = "UK", Genero = "Femenino", Edad = 35 }
            };

            var actores2 = new List<Actor>
            {
                new Actor { Nombre = "Actor 3", Pais = "Australia", Genero = "Masculino", Edad = 30 },
                new Actor { Nombre = "Actor 4", Pais = "Canada", Genero = "Femenino", Edad = 25 }
            };

            var peliculas = new List<Pelicula>();
            for (int i = 1; i <= 25; i++)
            {
                peliculas.Add(new Pelicula
                {
                    Nombre = $"Pelicula {i}",
                    AnioEstreno = 2000 + i,
                    Tipo = i % 3 == 0 ? "Accion" : (i % 3 == 1 ? "Terror" : "Comedia"),
                    Sinopsis = $"Sinopsis de la pelicula {i}",
                    Actores = i % 2 == 0 ? actores2 : actores1,
                    Calificacion = (i % 5 == 0) ? 10 : (i % 5) + 5
                });
            }
            return peliculas;
        }
    }
}
