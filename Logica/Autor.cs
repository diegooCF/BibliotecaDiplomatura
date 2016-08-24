using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        // metodos
        public int CalcularEdad(Entidades.Autor pAutor)
        {
            int intEdad;
            intEdad = DateTime.Today.Year - pAutor.FechaNacimiento.Year;
            return intEdad;
        }

        /// <summary>
        /// Descripcion : Agrega un autor a una lista generica
        /// Autor       : Curso .NET
        /// Fecha       : 13/07/2016
        /// </summary>
        /// <param name="pAutores">Lista de Autores</param>
        /// <param name="pAutor">entidades autor</param>
        public void Agregar(List<Entidades.Autor> pAutores, Entidades.Autor pAutor)
        {
            pAutores.Add(pAutor);
        }

        public void Agregar(Entidades.Autor pAutor)
        {
            try
            {
                Datos.Autor.Agregar(pAutor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public DataTable TraerTodos()
        {
            return Datos.Autor.TraerTodos();
        }
        public void Modificar(Entidades.Autor pAutor)
        {
            //Excepcion de try pasa a catch siempre
            if (pAutor.FechaNacimiento > DateTime.Today)
                throw new Exception("La fecha no puede ser posterior a la fecha actual");
            try
            {
                Datos.Autor.Modificar(pAutor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Entidades.Autor TraerAutor(int pCodigo)
        {
            try
            {
                return Datos.Autor.TraerAutor(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
