using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFloat
{
    class Program
    {
        public static float[] listaFlotantes = new float[] {2f, 2.1f, 2.2f, 2.3f};
        

        /// <summary>
        /// Preguntar Cuántos números ingresar para un array con coma flotante
        /// </summary>
        /// <returns>int num</returns>
        public static int PreguntarCuantosDatosIntroducir()
        {
            int num;
            try
            {
                Console.WriteLine("Cuantos datos o números con coma flotante va a introducir");
                return num = int.Parse(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("No es un número válido repita.");
                return PreguntarCuantosDatosIntroducir();
            }
        }

        /// <summary>
        /// Crear un nuevo array con una dimensión equivalente a la suma
        /// del array constante + los nuevos a ingresar
        /// </summary>
        /// <param name="numEspacios"></param>
        /// <returns>float[] array</returns>
        public static float[] RedimensionarArray(int numEspacios)
        {
            int redimension = listaFlotantes.Count() + numEspacios;
            float[] nuevoArray = new float[redimension];
            return nuevoArray;

        }

        /// <summary>
        /// Ingresar solo números que se puedan convertir en coma flotante
        /// o finalizar con palabra 'fin'
        /// </summary>
        /// <returns>string num</returns>
        public static string IngresarFloat()
        {
            float num;
            string entregado;
                Console.WriteLine("Ingresa un numero Flotante");
            entregado = Console.ReadLine();

            if (entregado == "fin") return entregado;
            
            if (!float.TryParse(entregado, out num))
            {
                Console.WriteLine("No es un número flotante");
                return IngresarFloat();
            } 
            ExisteEnListaFlotantes(num);
            return entregado;
        }

        /// <summary>
        /// Compreueva si existe un número en array 
        /// </summary>
        /// <param name="num"></param>
        public static void ExisteEnListaFlotantes(float num)
        {
            if (listaFlotantes.Contains(num)) Console.WriteLine("el Número existe en lista");
        }

        public static float[] CrearNuevoArray(float[] array)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                string entregado = IngresarFloat();
                if (entregado == "fin") break;
                float.TryParse(entregado,out array[i]);
                
            }

            return array;
        }

        /// <summary>
        /// Pregunta si quiere repetir la operación de nuevo array, si o no
        /// </summary>
        /// <returns>bool sino</returns>
        public static bool RepetirOperacion()
        {
            Console.WriteLine("Desea repetir la operación¿? [si] [no]");
            return Console.ReadLine() == "si" ? true : false;
        }
        static void Main(string[] args)
        {
            int numDatosAIntroducir;
            float[] nuevoArray;
            float nuevoFloat;
            bool repetir = true;
            while (repetir == true)
            {
                numDatosAIntroducir = PreguntarCuantosDatosIntroducir();
                nuevoArray = RedimensionarArray(numDatosAIntroducir);
                nuevoArray = CrearNuevoArray(nuevoArray);

                Console.WriteLine("Tu lista es: ");
                foreach (var item in nuevoArray)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nLa lista era: ");
                foreach (var item in listaFlotantes)
                {
                    Console.WriteLine(item);
                }
                repetir = RepetirOperacion();
                
            }
            
        }
    }
}
