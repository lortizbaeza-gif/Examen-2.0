using peliculasinfo.core;
using System.Collections.Generic;
using System.Linq;

namespace peliculasinfo.application
{
    public interface IConsultarPeliculasCalificacionPerfecta
    {
        List<Pelicula> Ejecutar();
    }

    public class ConsultarPeliculasCalificacionPerfecta : IConsultarPeliculasCalificacionPerfecta
    {
        private readonly IConsultarPeliculas _consultarPeliculas;

        public ConsultarPeliculasCalificacionPerfecta(IConsultarPeliculas consultarPeliculas)
        {
            _consultarPeliculas = consultarPeliculas;
        }

        public List<Pelicula> Ejecutar()
        {
            var todasLasPeliculas = _consultarPeliculas.Ejecutar();
            return todasLasPeliculas.Where(p => p.Calificacion == 10).ToList();
        }
    }
}
