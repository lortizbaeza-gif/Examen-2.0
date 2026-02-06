using System.Collections.Generic;

namespace peliculasinfo.core
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public int AnioEstreno { get; set; }
        public string Tipo { get; set; }
        public string Sinopsis { get; set; }
        public List<Actor> Actores { get; set; }
        public double Calificacion { get; set; }
    }
}
