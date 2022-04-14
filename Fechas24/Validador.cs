using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fechas24
{
    public class Validador
    {
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public const int cantidad = 1;
        public static void FechaValida(ref string[] arregloFecha)
        {
            /* "05/05/2009" */

            for (int i = 0; i < cantidad; i++)
            {
                string fechaUno;

                DateTime fecha2;
                string fecha3;

                do
                {

                    Console.WriteLine(" \n Ingrese la fecha " + (i + 1).ToString() + ": ");
                    Console.WriteLine(" \n El formato válido es: *dd/mm/aaaa hh:mm:ss* ");

                    fechaUno = Console.ReadLine();

                    if (fechaUno == "")
                    {
                        Console.Clear();
                        Console.WriteLine(" \n Ingrese un valor que no sea vacío por favor");
                    }

                    Regex re = new Regex("^(0?[1-9]|1[0-9]|2|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$");
                   
                    if (!re.IsMatch(fechaUno))
                    {
                        
                        Console.Clear();
                        Validador.FechaValida(ref arregloFecha);
                     
                        
                    }
   

                } while (fechaUno == "" );

                

                arregloFecha[i] = fechaUno;



            }

            string[] dateStrings = arregloFecha;

            DateTime dateValue;

            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out dateValue))
                    Console.WriteLine(" \n Fecha ingresada válida " +
                                      " \n Usted escribió *{0}* " +
                                      " \n Por lo tanto el sistema lo convirtio correctamente a: *{1}* ", dateString,
                                      dateValue, dateValue.Kind);
                else
                {
                    Console.Clear();
                    Console.WriteLine(" \n Fecha ingresada inválida " +
                                      " \n Ingrese un formato dd/mm/aaaa hh:mm:ss ");
                }


            }

        }

        public static void ValidarFecha(string mensaje)
        {
            bool ingresoCorrecto;
            DateTime fechaValida;
            
            do
            {
                
                Console.Clear();
                Console.WriteLine("\n Ingrese un formato válido.");
                Console.WriteLine("\n El formato correcto es *dd/mm/aaaa*.");
                Console.WriteLine("\n También puede ser *dd/mm/aaaa hh:mm:ss*.");
                Console.WriteLine(mensaje);
                string ingresoNacimiento = Console.ReadLine();

                ingresoCorrecto = DateTime.TryParse(ingresoNacimiento, out fechaValida);

                if (!ingresoCorrecto)
                {
                    continue;
                }
               

            } while (!ingresoCorrecto);

            Console.Clear();
            Console.WriteLine("\n Usted ingreso una fecha correcta que es *" + fechaValida + "*.");
            
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
