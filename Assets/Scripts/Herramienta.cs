using UnityEngine;

namespace herramientas.conectividad {
    public partial class Herramienta
    {
        public int contador;
        public int vida;
        public int calculoPuntaje()
        {
            int puntaje = contador * vida;
            return puntaje;
        }
    }
}