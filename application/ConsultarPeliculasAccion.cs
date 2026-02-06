using peliculasinfo.core;
using System.Collections.Generic;
using System.Linq;

namespace peliculasinfo.application
{
    public interface IConsultarPeliculasAccion
    {
        List<Pelicula> Ejecutar();
    }

    public class ConsultarPeliculasAccion : IConsultarPeliculasAccion
    {
        private readonly IConsultarPeliculas _consultarPeliculas;

        public ConsultarPeliculasAccion(IConsultarPeliculas consultarPeliculas)
        {
            _consultarPeliculas = consultarPeliculas;
        }

        public List<Pelicula> Ejecutar()
        {
            var todasLasPeliculas = _consultarPeliculas.Ejecutar();
            return todasLasPeliculas.Where(p => p.Tipo == "Accion").ToList();
        }
    }
}
