using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    public class Controlador
    {
        public String[] Nombres = new String[1000];
        public int Contador = 0;
        public int[] DNI = new int[1000];
        public double[] Notas = new double[1000];
        
        public void AgregarAlumno(string nombre, int dni, double nota)
        {
            Nombres[Contador] = nombre;
            DNI[Contador] = dni;
            Notas[Contador] = nota;
            Contador++; 
        }
        public void CalcularPromedio()
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i = 0; i < Contador; i++)
            {
                acumulador += Notas[i];
            }
            if (Contador > 0) 
            { 
                promedio = acumulador/ Contador;
            }
            
        }
    }
}
