using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class TextOperations
    {
        /// <summary>
        /// Cuenta la cantidad de letras que tiene una palabra.
        /// </summary>
        /// <param name="palabra">Palabra que se va a contar</param>
        /// <returns>Cantidad de letras</returns>
        public static int ContarLetras(string palabra)
        {
            int totalLetras = palabra.Length;
            return totalLetras;
        }
        /// <summary>
        /// Cuenta la cantidad de palabras que contiene el texto
        /// </summary>
        /// <param name="texto">Texto que se va a contar</param>
        /// <returns>Cantidad de palabras</returns>
        public static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(' ');
            int totalPalabras = 0;
            foreach (string palabra in palabras)
            {
                totalPalabras++;
            }
            return totalPalabras;
        }
        /// <summary>
        /// Cuenta la cantidad de vocales quecontiene una palabra.
        /// </summary>
        /// <param name="palabra">Palabra que se va a contar</param>
        /// <returns>Cantidad de vocales</returns>
        public static int ContarVocales(string palabra)
        {
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int longitud = palabra.Length;
            int totalVocales = 0;
            for (int i = 0; i < longitud; i++)
            {
                char letra = palabra[i];
                foreach (char vocal in vocales)
                {
                    if (letra == vocal)
                    {
                        totalVocales++;
                    }
                }
            }
            return totalVocales;
        }
        /// <summary>
        /// Cuenta la cantidad de consonantes que contiene una palabra.
        /// </summary>
        /// <param name="palabra">Palabra que se va a contar</param>
        /// <returns>Cantidad de consonantes</returns>
        public static int ContarConsonantes(string palabra)
        {
            string vocales = "aeiou";
            int contador = 0;
            foreach (char letra in palabra.ToLower())
            {
                if (!vocales.Contains(letra))
                {
                    contador++;
                }
            }
            return contador;
            
        }
        /// <summary>
        /// Reemplaza el carácter original por el indicado.
        /// </summary>
        /// <param name="palabra">Palabra que se va a modificar</param>
        /// <param name="original">Caracter original de la palabra que será reemplazado</param>
        /// <param name="nuevo">Caracter nuevo por el cual se reemplazará el original</param>
        /// <returns>Una nueva palabra con las modificaciones</returns>
        public static string ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            string palabraNueva = "";
            int i = 0;
            foreach (char letra in palabra)
            {
                char caracterAgregado = letra;
                if (letra == original)
                {
                    caracterAgregado = nuevo;
                }
                palabraNueva += caracterAgregado;
                i++;

            }
            return palabraNueva;

        }
        /// <summary>
        /// Convierte, si es posible, un texto en un número entero.
        /// </summary>
        /// <param name="texto">Texto que se intentará convertir en un número entero.</param>
        /// <param name="numeroEntero">El número entero si la conversión es exitosa.</param>
        /// <returns>
        /// True si la conversión es exitosa, de lo contrario, False.
        /// El número entero resultante se almacena en 
        /// la variable "numeroEntero" si la conversión es exitosa.
        /// </returns>
        public static bool ConvertirStringAEntero(string texto, out int numeroEntero)
        {
            bool exito = int.TryParse(texto, out numeroEntero);

            if (!exito)
            {
                Console.WriteLine("El formato del texto no es válido para convertir a entero.");
            }

            return exito;
        }
        /// <summary>
        /// Recibe un string y lo guarda en un StringBuilder.
        /// </summary>
        /// <param name="palabra">Palabra que será guardada en un StringBuilder</param>
        /// <returns>Un StringBuilder con la palabra guardada</returns>
        public static StringBuilder ConvertirStringASB(string palabra)
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append(palabra);

            return mensaje;
        }
        /// <summary>
        /// Recibe un párrafo y guarda cada frase en una línea nueva de un StringBuilder.
        /// </summary>
        /// <param name="parrafo">Párrafo que será guardado en un StringBuilder</param>
        /// <returns>Un StringBuilder con cada una frase del parrafo por linea </returns>
        public static StringBuilder ConvertirParrafoASB(string parrafo)
        {
            StringBuilder mensaje = new StringBuilder();
            char[] arrayParrafo = parrafo.ToCharArray();
            char separador = '.';

            foreach (char caracter in arrayParrafo)
            {
                if (caracter != separador)
                {
                    mensaje.Append(caracter);
                }
                else
                {
                    mensaje.Append(caracter);
                    mensaje.AppendLine();
                }
            }
            return mensaje;
        }
        /// <summary>
        /// Muestra por consola el mensaje y el texto recibido.
        /// </summary>
        /// <param name="mensaje">Mensaje que mostraremos por consola.</param>
        /// <param name="texto">Texto que mostraremos por consola.</param>
        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine("Mensaje recibido: {0} \n",mensaje);
            Console.WriteLine("Texto recibido: {0} \n", texto);
        }
        /// <summary>
        /// Muestra por consola el texto recibido.
        /// </summary>
        /// <param name="texto">Texto recibido que se mostrará por consola.</param>
        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }
    }
}