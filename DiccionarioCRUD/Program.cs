using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioCRUD
{
    public class Program
    {
        static Estado objEstado = new Estado();
        public static Dictionary<int, Estado> _Estados = new Dictionary<int, Estado>();
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("SELECIONE UNA OPCION \n1.- Consultar Todos \n2.- Consultar Solo uno \n3.- Agregar  \n4.- Actualizar \n5.- Eliminar \n6.- Terminar");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 1\n\n");
                        _Estados = CRUDEstados.consultarTodos();
                        try
                        {
                            //if(!_Estados.Values = null)
                            Dictionary<int, Estado>.ValueCollection valores = _Estados.Values;

                            foreach (Estado s in _Estados.Values)
                            {
                                Console.Write($"{s.id}, ");
                                Console.Write($"{s.nombre}, ");
                                Console.Write($"{s.curp}");
                                Console.WriteLine();
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 2\n\n");
                        Console.WriteLine("Por favor ingrese el id del estado para consultar");
                        int val = Convert.ToInt32(Console.ReadLine());
                        CRUDEstados.cosultarUno(val);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        objEstado = new Estado();
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 3\n\n");
                        Console.WriteLine("Por favor digite el id");
                        objEstado.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor el nombre del estado");
                        objEstado.nombre = Console.ReadLine();
                        Console.WriteLine("Por favor digite el curp");
                        objEstado.curp = Console.ReadLine();
                        CRUDEstados.agredar(objEstado);
                        Console.WriteLine("Se ha agregado correctamente");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 4\n\n");
                        Console.WriteLine("Por favor digine el id del Estado que se requiere actualizar");
                        objEstado.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor el nuevo nombre del estado");
                        objEstado.nombre = Console.ReadLine();
                        Console.WriteLine("Por favor el nuevo curp del estado");
                        objEstado.curp = Console.ReadLine();
                        CRUDEstados.actualizar(objEstado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 5\n\n");
                        Console.WriteLine("Por favor digite el id del estado a eliminar");
                        objEstado.id = Convert.ToInt32(Console.ReadLine());
                        CRUDEstados.eliminar(objEstado);
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Usted a salido de la áplicación\n\n");

                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("La opcion seleccionada no existe\n\n");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "6");
        }
    }
}
