using herramientas.calculos;
using herramientas.conectividad;
using logica_de_jugador;
using UnityEngine;

namespace logica_de_jugador {
    public class Jugador : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

public class Enemigo
{

}

#region Mundo
namespace herramientas {
    namespace calculos {
        public class Ejemplo {
            public void metodoEjemplo() {
                Jugador j;
            }
        }
    }
    namespace conectividad {
        public partial class Herramienta { 
            
        }
    }
}

#endregion Mundo

namespace jugabilidad {
    namespace niveles {
        public class Dificultad {
            public void metodoDificultad() {
                Ejemplo a;
            }
        }
    }
}