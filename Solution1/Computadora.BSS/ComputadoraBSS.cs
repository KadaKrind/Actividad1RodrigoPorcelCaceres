using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Computadora.DAL;
using Computadora.MODELOS;



namespace Computadora.BSS
{
    public class ComputadoraBSS
    {
        ComputadoraDAL dal = new ComputadoraDAL();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
    }
}
