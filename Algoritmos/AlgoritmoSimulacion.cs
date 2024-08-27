using PruebaPrintRafa19_Agosto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPrintRafa19_Agosto.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaGenerada = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaGenerada.Add(5 * (i + 1));
            }

            return listaGenerada;
        }
        public List<int> AlgoritmoCuadradoMedio(int n)
        {
            List<int> listaSalida = new List<int>();
            int pseudoaleatorio = n;

            while (true)
            {
                // Calculate the square of n
                int cuadrado = n * n;

                // Convert the squared number to a string
                string cadena = cuadrado.ToString();

                // Ensure that the string has at least 3 characters
                if (cadena.Length < 3)
                {
                    throw new ArgumentException("The squared number does not have enough digits to perform the algorithm.");
                }

                // Extract the middle portion of the string
                int middleStart = (cadena.Length - 3) / 2;  // Start in the middle minus 1
                string subcadena = cadena.Substring(middleStart, 3);

                // Convert the substring back to an integer
                pseudoaleatorio = Convert.ToInt32(subcadena);

                // Check if the value already exists in the list
                if (listaSalida.Contains(pseudoaleatorio))
                {
                    break;  // Stop the loop if a duplicate is found
                }

                // Add the result to the list
                listaSalida.Add(pseudoaleatorio);

                // Use the pseudoaleatorio for the next iteration
                n = pseudoaleatorio;
            }

            return listaSalida;
        }

    }

}


