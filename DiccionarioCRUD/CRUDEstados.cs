using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioCRUD
{
    public class CRUDEstados
    {
        public static Dictionary<int, Estado> _Estados = new Dictionary<int, Estado>();
        public static Dictionary<int, Estado> consultarTodos()
        {
            return _Estados;
        }

        public static void cosultarUno(int val)
        {
            try
            {
                Estado value;
                bool hvalue = _Estados.TryGetValue(val, out value);
                if (value.id == val)
                {
                    foreach (Estado s in _Estados.Values)
                    {
                        Console.Write($"{s.id}, ");
                        Console.Write($"{s.nombre}, ");
                        Console.Write($"{s.curp}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Id no encontrada");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void agredar(Estado estado)
        {
            try
            {
                _Estados.Add(estado.id, estado);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void actualizar(Estado estado)
        {
            _Estados[estado.id] = estado;
        }

        public static void eliminar(Estado estado)
        {
            _Estados.Remove(estado.id);
        }
    }
}
