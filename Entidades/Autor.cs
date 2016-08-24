using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        // constructor predeterminado
        public Autor()
        {
            this.Nacionalidad = "Argentina";
        }
        // constructor sobrecargado
        public Autor(int pCodigo,string pApellido,string pNombre,DateTime pFecha,string pNacionalidad)
        {
            this.Codigo = pCodigo;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.FechaNacimiento = pFecha;
            this.Nacionalidad = pNacionalidad;
       

        }
        // atributos + propiedades
        private int codigo;
        // encapsulo
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string nacionalidad;
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
    }
}