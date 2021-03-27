using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Tarea:Comparador
    {
        protected string Nombre;
        protected string Duracion;
        protected string Porcentaje;
        protected string Programador;

        public Tarea() {
            Nombre = "";
        
        }

        public Tarea(string nombre)
        {
            Nombre = nombre;

        }


        public Tarea(string nombre, string duracion, string porcentaje, string programador)
        {
            Nombre = nombre;
            Duracion = duracion;
            Porcentaje = porcentaje;
            Programador = programador;


        }
        public string nombre() {

            return Nombre;
        }
        public void nombre(string nombre)
        {

            Nombre=nombre;
        }
        public string duracion()
        {

            return Duracion;
        }
        public void duracion(string duracion)
        {

            Duracion = duracion;
        }
        public string porcentaje()
        {

            return Porcentaje;
        }
        public void porcentaje(string porcentaje)
        {

            Porcentaje = porcentaje;
        }
        public string programador()
        {

            return Programador;
        }
        public void programador(string programador)
        {

            Programador = programador;
        }
       public bool igualQue(Object q){
            
            if (this.Nombre.CompareTo(((Tarea)q).nombre())==0 ) {
                return true;
            }
            
            return false;
        }
       public bool menorQue(Object q) {
            if (this.Nombre.CompareTo(((Tarea)q).nombre()) < 0)
            {
                return true;
            }

            return false;
        
        }
       public bool menorIgualQue(Object q) {
            if (this.Nombre.CompareTo(((Tarea)q).nombre()) <= 0)
            {
                return true;
            }

            return false;
        }
       public bool mayorQue(Object q) {
            if (this.Nombre.CompareTo(((Tarea)q).nombre()) > 0)
            {
                return true;
            }

            return false;
        }
       public bool mayorIgualQue(Object q) {
            if (this.Nombre.CompareTo(((Tarea)q).nombre()) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
