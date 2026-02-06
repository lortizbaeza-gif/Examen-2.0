using peliculasinfo.core;
using System.Collections.Generic;
using System.Linq;

namespace peliculasinfo.application
{
    public interface IConsultarActoresPeliculasTerror
    {
        List<Actor> Ejecutar();
    }

    public class ConsultarActoresPeliculasTerror : IConsultarActoresPeliculasTerror
    {
        private readonly IConsultarPeliculas _consultarPeliculas;

        public ConsultarActoresPeliculasTerror(IConsultarPeliculas consultarPeliculas)
        {
            _consultarPeliculas = consultarPeliculas;
        }

        public List<Actor> Ejecutar()
        {
            var todasLasPeliculas = _consultarPeliculas.Ejecutar();
            return todasLasPeliculas
                .Where(p => p.Tipo == "Terror")
                .SelectMany(p => p.Actores)
                .Distinct()
                .ToList();
        }
    }
}
