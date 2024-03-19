using Computadora.DAL.Computadora.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.MODELOS;


namespace Computadora.DAL
{
    
   public class ComputadoraDAL
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "SELECT * FROM computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
       
        public void InsertarComputadoraDal(computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.NOMBRE + "'," + "'" + computadora.DESCRIPCION + "'," + "'" + computadora.PRECIO + "'," + "'" + computadora.FECHAFABRICACION + "')";
            conexion.Ejecutar(consulta);
        }
    }
    
}
