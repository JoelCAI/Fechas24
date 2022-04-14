using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas24
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            Validador.ValidarFecha("\n Ingrese una Fecha");

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }

        public static int cantidad = 1;
    }
}
