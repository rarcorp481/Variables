using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Arreglo
    {
        public static int[] edades = new int[10];
        public static int pos = 0;
        /// <summary>
        /// Calcula el promedio de las edades en entero
        /// </summary>
        /// <returns></returns>
        public static int GetPromedioI()
        {
            int prom = 0;
            int suma = 0;

            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = suma / pos;
            return prom;
        }
        /// <summary>
        /// Calcula el promedio de las edades en Decimal
        /// </summary>
        /// <returns></returns>
        public static double GetPromedioD()
        {
            double prom = 0;
            double suma = 0;

            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = suma / pos;
            return prom;
        }
        /// <summary>
        /// Recoge la edad máxima del arreglo
        /// </summary>
        /// <returns></returns>
        public static int GetEdadMaxima()
        {
            int edadMaxima = 0;
            foreach (int edad in edades)
            {
                if (edad > edadMaxima) edadMaxima = edad;
            }
            return edadMaxima;
        }
        /// <summary>
        /// Recoge la edad mínima del arreglo
        /// </summary>
        /// <returns></returns>
        public static int GetEdadMinima()
        {
            int edadMinima = edades[0];

            for (int i = 1; i < pos; i++)
            {
                if (edades[i] < edadMinima) edadMinima = edades[i];
            }
            return edadMinima;
        }
        /// <summary>
        /// cuenta la cantidad de mayores de edad en el arreglo
        /// </summary>
        /// <returns></returns>
        public static int GetMayores()
        {
            int mayoresEdad = 0;

            foreach (int edad in edades)
            {
                if (edad >= 18) mayoresEdad++;
            }
            return mayoresEdad;
        }
        /// <summary>
        /// Cuenta la cantidad de menores de edad en el arreglo
        /// </summary>
        /// <returns></returns>
        public static int GetMenores()
        {
            int menoresEdad = 0;

            for (int i = 0; i < pos; i++)
            {
                if (edades[i] < 18) menoresEdad++;
            }
            return menoresEdad;
        }
    }
}
