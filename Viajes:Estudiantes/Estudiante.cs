using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBotta
{
    class Estudiante
    {
        private string  nombre;
        private int edad;
        private int legajo;
        private double promedio;
        private bool sexo;

        public Estudiante() 
        {
            this.nombre = "";
            this.edad = 0;
            this.legajo = 0;
            this.promedio = 0;
            this.sexo = false;
        }

        public string  pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       
        public int pLegajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
          
       public int pEdad
        {
            get { return edad; }
            set { edad = value; }
        }

      
        public bool pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
         
        public double pPromedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public string MostrarEstudiante() 
        {
            string aux = "Estudiante ";
            aux += "| Nombre:" + nombre + "| Legajo:" + legajo + "| Edad:" + edad;

            if (edad >= 18)

                aux += "| Mayor de edad";
            else
                aux+=  "| Menor de edad";

           



            if (sexo)
                  aux += "| Sexo Masculino";

            else
                    aux += "| Sexo Femenino";
             
            aux += "| Promedio:" + promedio;
             return aux;   
        }

    }
}
