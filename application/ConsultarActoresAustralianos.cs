using peliculasinfo.core;
using System.Collections.Generic;
using System.Linq;

namespace peliculasinfo.application
{
    public interface IConsultarActoresAustralianos
    {
        List<Actor> Ejecutar();
    }

    public class ConsultarActoresAustralianos : IConsultarActoresAustralianos
    {
        private readonly IConsultarPeliculas _consultarPeliculas;

        public ConsultarActoresAustralianos(IConsultarPeliculas consultarPeliculas)
        {
            _consultarPeliculas = consultarPeliculas;
        }

        public List<Actor> Ejecutar()
        {
            var todasLasPeliculas = _consultarPeliculas.Ejecutar();
            return todasLasPeliculas
                .SelectMany(p => p.Actores)
                .Where(a => a.Pais == "Australia")
                .Distinct()
                .ToList();
        }
    }
}
